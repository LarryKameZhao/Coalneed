using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using Microsoft.Office.Interop.Word;
using DevExpress.XtraEditors;
using Coal_YearForecast;

using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using Auseft;
using System.Data.OleDb;
using DevExpress.XtraGrid.Views.Base;
using MyControl;

namespace Coal_YearForecast
{
    public partial class YearForecastCtl : DevExpress.XtraEditors.XtraUserControl
    {
        public YearForecastCtl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        #region 数据库接口
        private OleDbConnectionStringBuilder oleConnectionBuilder = new OleDbConnectionStringBuilder();

        private int m_UserID = 0;
        /// <summary>
        /// 登陆编号
        /// </summary>
        [Description("登陆编号"), Category("自定义属性")]
        public int UserID
        {
            set { m_UserID = value; }
            get { return m_UserID; }
        }

        private string m_UserGH = "";
        /// <summary>
        /// 登陆工号
        /// </summary>
        [Description("登陆工号"), Category("自定义属性")]
        public string UserGH
        {
            set { m_UserGH = value; }
            get { return m_UserGH; }
        }

        private string m_UserName = "";
        /// <summary>
        /// 登陆用户名
        /// </summary>
        [Description("登陆用户名"), Category("自定义属性")]
        public string UserName
        {
            set { m_UserName = value; }
            get { return m_UserName; }
        }

        private string m_ImagePath = "";
        /// <summary>
        /// 平台图标路径
        /// </summary>
        [Description("平台图标路径"), Category("自定义属性")]
        public string ImagePath
        {
            set { m_ImagePath = value; }
            get { return m_ImagePath; }
        }

        private string m_MDBFilePath = AppDomain.CurrentDomain.BaseDirectory + "\\Coal.mdb";
        /// <summary>
        /// MDB文件路径
        /// </summary>
        [Description("MDB文件路径"), Category("自定义属性")]
        public string MDBFilePath
        {
            set { m_MDBFilePath = value; }
            get { return m_MDBFilePath; }
        }

        private string m_INIFilePath = AppDomain.CurrentDomain.BaseDirectory + "\\config.ini";
        /// <summary>
        /// INI文件路径
        /// </summary>
        [Description("INI文件路径"), Category("自定义属性")]
        public string INIFilePath
        {
            set { m_INIFilePath = value; }
            get { return m_INIFilePath; }
        }

        private string m_Password = "";
        /// <summary>
        /// mdb文件密码
        /// </summary>
        [Description("mdb文件密码"), Category("自定义属性")]
        public string Password
        {
            set { m_Password = value; }
            get { return m_Password; }
        }

        private bool m_TypeViewOnly = false;
        /// <summary>
        /// 样式只读属性
        /// </summary>
        [Description("样式只读属性"), Category("自定义属性")]
        public bool TypeViewOnly
        {
            set { m_TypeViewOnly = value; }
            get { return m_TypeViewOnly; }
        }

        private bool m_ManagerViewOnly = false;
        /// <summary>
        /// 管理只读属性
        /// </summary>
        [Description("管理只读属性"), Category("自定义属性")]
        public bool ManagerViewOnly
        {
            set { m_ManagerViewOnly = value; }
            get { return m_ManagerViewOnly; }
        }

        private bool m_ExportViewOnly = true;
        /// <summary>
        /// 导出只读属性
        /// </summary>
        [Description("导出只读属性"), Category("自定义属性")]
        public bool ExportViewOnly
        {
            set { m_ExportViewOnly = value; }
            get { return m_ExportViewOnly; }
        }

        private int m_TimeInterval = 0;
        /// <summary>
        /// 查询日期间隔
        /// </summary>
        [Description("查询日期间隔"), Category("自定义属性")]
        public int TimeInterval
        {
            set { m_TimeInterval = value; }
            get { return m_TimeInterval; }
        }

        private Form m_PTForm = null;
        /// <summary>
        /// 平台窗口
        /// </summary>
        [Description("平台窗口"), Category("自定义属性")]
        public Form PTForm
        {
            set
            {
                m_PTForm = value;

                if (m_PTForm == null)
                    return;

                m_PTForm.WindowState = FormWindowState.Maximized;
            }
            get { return m_PTForm; }
        }
 
        #endregion

        #region 开始设置
        GridStyle gridStyle = new GridStyle();
        public string strconn = "";
        public void Begin()
        {
            try
            {
                gridStyle.FilePath = System.Windows.Forms.Application.StartupPath + "\\YearForecast_Layout.xml";

                gridStyle.LoadStyle(gridView_Year,false);

                //m_INIFilePath = System.Windows.Forms.Application.StartupPath + "\\config.ini";
                //m_MDBFilePath = System.Windows.Forms.Application.StartupPath + "\\Coal.mdb";
                strconn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + m_MDBFilePath;
               
                if (!UpdateCustomer())
                {
                    XtraMessageBox.Show("请设置用户名称！");
                    System.Windows.Forms.Application.Exit();
                }

                //只读
                if (m_ManagerViewOnly)
                {
                    this.ribbonPageGroup数据管理.Visible = false;
                }
                else
                {
                    this.ribbonPageGroup数据管理.Visible = true;
                }

                if (m_ExportViewOnly)
                {
                    this.ribbonPageGroup数据导出.Visible = false;
                }
                else
                {
                    this.ribbonPageGroup数据导出.Visible = true;
                }

                if (m_TypeViewOnly)
                {
                    this.ribbonPageGroup格式.Visible = false;
                }
                else
                {
                    this.ribbonPageGroup格式.Visible = true;
                }
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("载入数据异常：" + ex.Message);
            }
            barEditItem开始时间.EditValue = new DateTime(DateTime.Now.Year,1,1);
            barEditItem结束时间.EditValue = new DateTime(DateTime.Now.Year+1, 1, 1);
        }

        public bool End()
        {
            return true;
        }
        #endregion

        private bool IsFirst= true;
        //获取公司名称
        private string Customer = "常熟昆承热电厂";
        private bool UpdateCustomer()
        {
            string temp = "";
            MyControl.INI.GetPrivateProfileString("Customer", "Name", "", ref temp, m_INIFilePath);

            if (temp == "")
            {
                return false;
            }
            else
            {
                Customer = temp;
                string strSQL = " update Company set Name='" + Customer + "'";
                if (!mdbChange(strSQL, "更新用户名称"))
                {
                    return false;
                }
                return true;
            }
        }

        #region  预测限制参数
        int E = 0;//月发电量
        int T = 0;//月供汽量
        double Eta = 0;//全厂热效率
        int L = 0;//日最大卸煤量
        int C = 0;//单位库存成本
        int V = 0;//实际库存
        int Vs = 0;//安全库存
        int V0 = 0;//最大库存
        int MP = 0;//最小采购数量
        double D = 0;//月耗煤量
        double M = 0;//月最大采购量   

        int pw1 = 0;//第一周煤价
        int pw2 = 0;//第二周煤价
        int pw3 = 0;//第三周煤价
        int pw4 = 0;//第四周煤价
        int pw5 = 0;//第五周煤价
        int sw1 = 0;//第一周海运费用
        int sw2 = 0;//第二周海运费用
        int sw3 = 0;//第三周海运费用
        int sw4 = 0;//第四周海运费用
        int sw5 = 0;//第五周海运费用

        int pm1 = 0;//第一月煤价
        int pm2 = 0;//第二月煤价
        int pm3 = 0;//第三月煤价
        int pm4 = 0;//第四月煤价
        int pm5 = 0;//第五月煤价
        int pm6 = 0;//第六月煤价
        int pm7 = 0;//第七月煤价
        int pm8 = 0;//第八月煤价
        int pm9 = 0;//第九月煤价
        int pm10 = 0;//第十月煤价
        int pm11 = 0;//第十一月煤价
        int pm12 = 0;//第十二月煤价

        int sm1 = 0;//第一月海运费用
        int sm2 = 0;//第二月海运费用
        int sm3 = 0;//第三月海运费用
        int sm4 = 0;//第四月海运费用
        int sm5 = 0;//第五月海运费用
        int sm6 = 0;//第六月海运费用
        int sm7 = 0;//第七月海运费用
        int sm8 = 0;//第八月海运费用
        int sm9 = 0;//第九月海运费用
        int sm10 = 0;//第十月海运费用
        int sm11 = 0;//第十一月海运费用
        int sm12 = 0;//第十二月海运费用

        int p11 = 0;//煤种1第一周煤价
        int p12 = 0;//煤种1第二周煤价
        int p13 = 0;//煤种1第三周煤价
        int p14 = 0;//煤种1第四周煤价
        int p15 = 0;//煤种1第五周煤价

        int p21 = 0;//煤种2第一周煤价
        int p22 = 0;//煤种2第二周煤价
        int p23 = 0;//煤种2第三周煤价
        int p24 = 0;//煤种2第四周煤价
        int p25 = 0;//煤种2第五周煤价

        int p31 = 0;//煤种3第一周煤价
        int p32 = 0;//煤种3第二周煤价
        int p33 = 0;//煤种3第三周煤价
        int p34 = 0;//煤种3第四周煤价
        int p35 = 0;//煤种3第五周煤价

        int p41 = 0;//煤种4第一周煤价
        int p42 = 0;//煤种4第二周煤价
        int p43 = 0;//煤种4第三周煤价
        int p44 = 0;//煤种4第四周煤价
        int p45 = 0;//煤种4第五周煤价

        int p51 = 0;//煤种5第一周煤价      
        int p52 = 0;//煤种5第二周煤价
        int p53 = 0;//煤种5第三周煤价
        int p54 = 0;//煤种5第四周煤价
        int p55 = 0;//煤种5第五周煤价   
        #endregion
       
        #region 解算

        //连接串设置
        public OleDbConnection InitialConnection(string filepath)
        {
            string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filepath;
            OleDbConnection connection = new OleDbConnection(constr);
            return connection;
        }

        //连接串设置，带密码
        public OleDbConnection InitialConnection(string filepath, string password)
        {
            string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filepath + ";Jet OLEDB:Database Password=" + password + ";";
            OleDbConnection connection = new OleDbConnection(constr);
            return connection;
        }

        //添加,修改记录
        private bool mdbChange(string sqlstr, string strType)
        {
            //（1）创建并打开一个OleDbConnection对象。
            //（2）创建一个插入一条记录的SQL语句。 
            //（3）创建一个OleDbCommand对象。 
            //（4）通过此OleDbCommand对象完成对插入一条记录到数据库的操作。 
            OleDbConnection myConn = null;
            try
            {
                string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + m_MDBFilePath;
                myConn = new OleDbConnection(strconn);
                myConn.Open();
                OleDbCommand inst = new OleDbCommand(sqlstr, myConn);
                int i = inst.ExecuteNonQuery();
                myConn.Close();
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show(strType + "异常:" + ex.Message);
                return false;
            }
            finally
            {
                if (myConn != null)
                {
                    if (myConn.State == ConnectionState.Open)
                    {
                        myConn.Close();
                    }
                }
            }

            return true;
        }

        //获取DataTable数据
        public DataTable mdbSelect(string sqlstr, string strType)
        {
            OleDbConnection myConn = null;
            try
            {
                
                string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + m_MDBFilePath;
                myConn = new OleDbConnection(constr);
                myConn.Open();

                OleDbDataAdapter da = new OleDbDataAdapter(sqlstr, myConn); //创建适配对象
                DataTable dt = new DataTable();//新建表对象
                OleDbDataAdapter Adapter = new OleDbDataAdapter(sqlstr, InitialConnection(m_MDBFilePath));
                da.Fill(dt); //用适配对象填充表对象

                myConn.Close();
                return dt;                
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show(strType + "异常:" + ex.Message);
                return null;
            }
            finally
            {
                if (myConn != null)
                {
                    if (myConn.State == ConnectionState.Open)
                    {
                        myConn.Close();
                    }
                }
            }
        }
        
        #endregion

        private void ForecastCtl_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsFirst)
                {
                    Begin();
                    IsFirst = false;
                }
                DateTime stime = Convert.ToDateTime(barEditItem开始时间.EditValue);
                DateTime etime = Convert.ToDateTime(barEditItem结束时间.EditValue);

                DateTime tStart = new DateTime(stime.Year, 1, 1);
                DateTime tEnd = new DateTime(etime.Year , 1, 1);    

                string str = "select * from YearForecast where ForecastTime >= #" + tStart.ToString() + "# and  ForecastTime<#" + tEnd.ToString() + "#;";

                DataTable dt = mdbSelect(str, "载入年度数据");
                gridControl_Year.DataSource = null;
                gridControl_Year.DataSource = dt;
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("载入年度数据：" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
        }

        private void barButtonItem刷新_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DateTime stime = Convert.ToDateTime(barEditItem开始时间.EditValue);
                DateTime etime = Convert.ToDateTime(barEditItem结束时间.EditValue);

                DateTime tStart = new DateTime(stime.Year, 1, 1);
                DateTime tEnd = new DateTime(etime.Year, 1, 1);    
   

                string str = "select * from YearForecast where ForecastTime >= #" + tStart.ToString() + "# and  ForecastTime<#" + tEnd.ToString() + "#;";

                DataTable dt = mdbSelect(str, "载入年度数据");
                gridControl_Year.DataSource = null;
                gridControl_Year.DataSource = dt;
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("载入年度数据：" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
        }

        private void barButtonItem退出_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PTForm.Close();
        }

        private void barButtonItem帮助_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string memo = "";
            memo += "新建日期：2015-4-4  8116\r\n";
            memo += "\r\n";
            memo += "渤海湾煤炭价格： 5000大卡,含税,元\r\n";
            memo += "海运价格：含税,元\r\n";

            AuCtlLib.Form.Form_Help dlg = new AuCtlLib.Form.Form_Help();
            dlg.MemoText = memo;
            dlg.ShowDialog();
        }

        private void barButtonItem打印_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gridControl_Year.ShowPrintPreview();                   
            }
            catch (System.Exception ex)
            {
               XtraMessageBox.Show( ex.Message);
            }
        }

        private void barButtonItem导出_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "XLS|*.XLS";
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;
 
                this.gridView_Year.ExportToXls(dlg.FileName);                
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        //显示行号
        private void gridView_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            int rowIndex = e.RowHandle;
            if (rowIndex >= 0)
            {
                rowIndex++;
                e.Info.DisplayText = rowIndex.ToString();
            }
            e.Info.ImageIndex = -1;
        }

        private void barButtonItem导入样式_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridStyle.LoadStyle(this.gridView_Year, true);
        }

        private void barButtonItem保存样式_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridStyle.SaveStyle(this.gridView_Year, true);
        }

        private void barButtonItem删除样式_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridStyle.DeleteStyle(this.gridView_Year, true);
        }

        private void barButtonItem设置列_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gridView_Year.ColumnsCustomization();
        }


        #region  Excel输出

        //法一
        public bool DataSetToExcel(DataTable  dt, bool isShowExcle)
        {
            DataTable dataTable = dt;
            int rowNumber = dataTable.Rows.Count;
            int columnNumber = dataTable.Columns.Count;

            if (rowNumber == 0)
            {
                MessageBox.Show("没有任何数据可以导入到Excel文件！");
                return false;
            }

            //建立Excel对象
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            excel.Visible = isShowExcle;//是否打开该Excel文件

            //填充数据
            for (int c = 0; c < rowNumber; c++)
            {
                for (int j = 0; j < columnNumber; j++)
                {
                    excel.Cells[c + 1, j + 1] = dataTable.Rows[c].ItemArray[j];
                }
            }

            return true;
        }
     
        #endregion

        private void barButtonItem添加_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                XtraForm_Year year = new XtraForm_Year();
                year.Customer = Customer;
                year.OptionType = 1;//1 新建  2 修改
                year.constr = strconn;
                if (year.ShowDialog() == DialogResult.OK)
                {

                }

                //yearForecastTableAdapter.Fill(this.dataSet_Forecast.YearForecast);
                barButtonItem刷新.PerformClick();                    
            }
            catch(System.Exception ex)
            {
                XtraMessageBox.Show("添加时："+ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void barButtonItem删除_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DataRow row = gridView_Year.GetDataRow(gridView_Year.FocusedRowHandle);
                if (row != null)
                {
                    DialogResult result = XtraMessageBox.Show("你确定要删除此信息？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        int i = int.Parse(gridView_Year.GetDataRow(gridView_Year.FocusedRowHandle)["ID"].ToString());
                        if (!mdbChange(" delete from YearForecast where ID="+ i , "年度预测保存"))
                        {
                            return;
                        }
                    }
                }

                //yearForecastTableAdapter.Fill(this.dataSet_Forecast.YearForecast);        
                barButtonItem刷新.PerformClick();
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void barButtonItem修改_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             try
             {
                DataRow row = gridView_Year.GetDataRow(gridView_Year.FocusedRowHandle);
                if (row != null)
                {
                    XtraForm_Year year = new XtraForm_Year();
                    year.Customer = Customer;
                    year.OptionType = 2;//1 新建  2 修改
                    year.ID = Convert.ToInt32(row["ID"]);//修改时，当前记录的ID
                    year.constr = strconn;
                    year.row = row;
                    if (year.ShowDialog() == DialogResult.OK)
                    {


                    }
                    //yearForecastTableAdapter.Fill(this.dataSet_Forecast.YearForecast);
                    barButtonItem刷新.PerformClick();
                }    
            }
            catch(System.Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void barButtonItem查询_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DateTime stime = Convert.ToDateTime(barEditItem开始时间.EditValue);
                DateTime etime = Convert.ToDateTime(barEditItem结束时间.EditValue);

                DateTime tStart = new DateTime(stime.Year, 1, 1);
                DateTime tEnd = new DateTime(etime.Year, 1, 1);


                string str = "select * from YearForecast where ForecastTime >= #" + tStart.ToString() + "# and  ForecastTime<#" + tEnd.ToString() + "#;";

                DataTable dt = mdbSelect(str, "载入年度数据");
                gridControl_Year.DataSource = null;
                gridControl_Year.DataSource = dt;
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("载入年度数据：" + ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            } 
        }

        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
            barButtonItem修改.PerformClick();
        }
    }
}
