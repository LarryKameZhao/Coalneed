using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Coal_MonthForecast;
using Microsoft.Office.Interop.Excel;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using Auseft;
using System.Data.OleDb;
using DevExpress.XtraGrid.Views.Base;

namespace Coal_MonthForecast
{
    public partial class XtraForm_Month : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm_Month()
        {
            InitializeComponent();
        }

        public string Customer = "";
        public int OptionType = 1;//1 新建  2 修改
        public int ID = 0;//修改时，当前记录的ID
        public string constr = "";
        public DataRow row ;

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
                myConn = new OleDbConnection(constr);
                myConn.Open();
                OleDbCommand inst = new OleDbCommand(sqlstr, myConn);
                int num = inst.ExecuteNonQuery();
                myConn.Close();

                if (num > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
        }

        private void barButtonItemExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void XtraForm_Month_Load(object sender, EventArgs e)
        {
            if (OptionType == 2)
            {
                //初始化结果
                textEditSumMoney.Text = row["SumMoney"].ToString();
                textEditSumQuantity.Text = row["SumQuantity"].ToString();
                DateTime time = Convert.ToDateTime(row["ForecastTime"]);
                timeEdit.EditValue = new DateTime(time.Year,time.Month,1);
                textEditQW1.Text = row["Q1"].ToString();
                textEditQW2.Text = row["Q2"].ToString();
                textEditQW3.Text = row["Q3"].ToString();
                textEditQW4.Text = row["Q4"].ToString();
                textEditQW5.Text = row["Q5"].ToString();

                spinEditBBCPW1.Text = row["P1"].ToString();
                spinEditBBCPW2.Text = row["P2"].ToString();
                spinEditBBCPW3.Text = row["P3"].ToString();
                spinEditBBCPW4.Text = row["P4"].ToString();
                spinEditBBCPW5.Text = row["P5"].ToString();

                spinEditOSW1.Text = row["S1"].ToString();
                spinEditOSW2.Text = row["S2"].ToString();
                spinEditOSW3.Text = row["S3"].ToString();
                spinEditOSW4.Text = row["S4"].ToString();
                spinEditOSW5.Text = row["S5"].ToString();

                spinEditE.Text = row["E"].ToString();
                spinEditT.Text = row["T"].ToString();
                spinEditEta.Text = row["Eta"].ToString();
                spinEditL.Text = row["L"].ToString();
                spinEditC.Text = row["C"].ToString();
                spinEditV.Text = row["V"].ToString();
                spinEditV0.Text = row["V0"].ToString();
                spinEditVs.Text = row["Vs"].ToString();
                spinEditMP.Text = row["MP"].ToString();
                spinEditM.Text = row["M"].ToString();
                spinEditD.Text = row["D"].ToString();
            }
            else
            {
                timeEdit.EditValue = DateTime.Now.ToShortDateString();
            }
        }

        #region //更新进度列表

        private delegate void SetPos(int ipos);

        private void SetTextMessage(int ipos)
        {
            if (this.InvokeRequired)
            {
                SetPos setpos = new SetPos(SetTextMessage);
                this.Invoke(setpos, new object[] { ipos });
            }
            else
            {
                progressBar1.Value = Convert.ToInt32(ipos);
            }
        }

        private int percent = 0;

        #endregion

        //解算
        private void barButtonItemForecast_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //初始化结果
                textEditSumMoney.Text = "";
                textEditSumQuantity.Text = "";

                textEditQW1.Text = "";
                textEditQW2.Text = "";
                textEditQW3.Text = "";
                textEditQW4.Text = "";
                textEditQW5.Text = "";

                System.Threading.Thread.Sleep(100);
                SetTextMessage(20);

                #region 计算通用参数

                int E = Convert.ToInt32(spinEditE.EditValue);
                int T = Convert.ToInt32(spinEditT.EditValue);
                double Eta = Convert.ToSingle(spinEditEta.EditValue);
                int L = Convert.ToInt32(spinEditL.EditValue);
                int C = Convert.ToInt32(spinEditC.EditValue);
                int V = Convert.ToInt32(spinEditV.EditValue);
                int Vs = Convert.ToInt32(spinEditVs.EditValue);
                int V0 = Convert.ToInt32(spinEditV0.EditValue);
                int MP = Convert.ToInt32(spinEditMP.EditValue);

                if (E <= 0)
                {
                    XtraMessageBox.Show("月发电量需为正数");
                    spinEditE.Focus();
                    return;
                }
                else if (T <= 0)
                {
                    XtraMessageBox.Show("月供汽量需为正数");
                    spinEditT.Focus();
                    return;
                }
                else if (Eta <= 0)
                {
                    XtraMessageBox.Show("全厂热效率需为正数");
                    spinEditEta.Focus();
                    return;
                }
                else if (L <= 0)
                {
                    XtraMessageBox.Show("日卸煤量需为正数");
                    spinEditL.Focus();
                    return;
                }
                else if (C < 0)
                {
                    XtraMessageBox.Show("单位库存成本需非负");
                    spinEditC.Focus();
                    return;
                }
                else if (Vs <= 0)
                {
                    XtraMessageBox.Show("安全库存需为正数");
                    spinEditVs.Focus();
                    return;
                }
                else if (V0 <= 0)
                {
                    XtraMessageBox.Show("最大库存需为正数");
                    spinEditV0.Focus();
                    return;
                }               
                else if (MP < 0)
                {
                    XtraMessageBox.Show("最小采购量需非负");
                    spinEditMP.Focus();
                    return;
                }

                int D = (int)(Math.Round(1.72152 * E + 0.14346 * T) / Eta);//月耗煤量
                int M = (int)(V0 - V + V0 / L * D / 30.4);//月最大采购量

                spinEditD.Text = D.ToString();
                spinEditM.Text = M.ToString();

                if (D <= 0)
                {
                    XtraMessageBox.Show("月耗煤量需为正数");
                    spinEditD.Focus();
                    return;
                }
                else if (M <= 0)
                {
                    XtraMessageBox.Show("月最大采购煤量需为正数");
                    spinEditM.Focus();
                    return;
                }

                //检查安全库存、最大库存、实际库存之间的关系
                if (V0 < V)
                {
                    XtraMessageBox.Show("实际库存需不大于最大库存！");
                    spinEditV0.Focus();
                    return;
                }
                else if (V0 < Vs)
                {
                    XtraMessageBox.Show("安全库存需不大于最大库存！");
                    spinEditV0.Focus();
                    return;
                }        

                //检查输入的价格
                int pw1 = Convert.ToInt32(spinEditBBCPW1.EditValue);
                int pw2 = Convert.ToInt32(spinEditBBCPW2.EditValue);
                int pw3 = Convert.ToInt32(spinEditBBCPW3.EditValue);
                int pw4 = Convert.ToInt32(spinEditBBCPW4.EditValue);
                int pw5 = Convert.ToInt32(spinEditBBCPW5.EditValue);
                int sw1 = Convert.ToInt32(spinEditOSW1.EditValue);
                int sw2 = Convert.ToInt32(spinEditOSW2.EditValue);
                int sw3 = Convert.ToInt32(spinEditOSW3.EditValue);
                int sw4 = Convert.ToInt32(spinEditOSW4.EditValue);
                int sw5 = Convert.ToInt32(spinEditOSW5.EditValue);

                if (  pw1 <= 0
                   || pw2 <= 0
                   || pw3 <= 0
                   || pw4 <= 0
                   || pw5 <= 0)
                {
                    XtraMessageBox.Show("渤海湾煤炭价格均需为正数");
                    return;
                }

                if (sw1 < 0
                   || sw2 < 0
                   || sw3 < 0
                   || sw4 < 0
                   || sw5 < 0)
                {
                    XtraMessageBox.Show("海运价格需非负");
                    return;
                }
                #endregion

                System.Threading.Thread.Sleep(100);
                SetTextMessage(80);

                //---------------------------------------matlab计算-------------------------------------------------------
                Auseft.Demo calObj = new Demo();
                MWArray[] arr = calObj.coalMonth(7, M, V, V0, Vs, D, pw1 + sw1, pw2 + sw2, pw3 + sw3, pw4 + sw4, pw5 + sw5);
                MWNumericArray y1 = (MWNumericArray)arr[0];
                MWNumericArray y2 = (MWNumericArray)arr[1];
                MWNumericArray y3 = (MWNumericArray)arr[2];
                MWNumericArray y4 = (MWNumericArray)arr[3];
                MWNumericArray y5 = (MWNumericArray)arr[4];
                MWNumericArray y6 = (MWNumericArray)arr[5];
                MWNumericArray y7 = (MWNumericArray)arr[6];
                double[,] y11 = (double[,])y1.ToArray(MWArrayComponent.Real);
                double[,] y12 = (double[,])y2.ToArray(MWArrayComponent.Real);
                double[,] y13 = (double[,])y3.ToArray(MWArrayComponent.Real);
                double[,] y14 = (double[,])y4.ToArray(MWArrayComponent.Real);
                double[,] y15 = (double[,])y5.ToArray(MWArrayComponent.Real);
                double[,] y16 = (double[,])y6.ToArray(MWArrayComponent.Real);
                double[,] y17 = (double[,])y7.ToArray(MWArrayComponent.Real);
                int z1 = (int)Math.Round(y11[0, 0] / 1.1513, 0);
                int z2 = (int)Math.Round(y12[0, 0] / 1.1513, 0);
                int z3 = (int)Math.Round(y13[0, 0] / 1.1513, 0);
                int z4 = (int)Math.Round(y14[0, 0] / 1.1513, 0);
                int z5 = (int)Math.Round(y15[0, 0] / 1.1513, 0);
                int z6 = (int)Math.Round(y16[0, 0] / 1.1513, 0);
                int z7 = (int)Math.Round(y17[0, 0], 0);
                //--------------------------------------------------------------------------------------------------------

                System.Threading.Thread.Sleep(100);
                SetTextMessage(100);

                //显示解信息
                if (z7 < 1)
                {
                    XtraMessageBox.Show("符合条件限制的月度预测方案未找到！");
                    return;
                }
                else
                {
                    double monthSum = z1 + z2 + z3 + z4 + z5;
                    textEditSumQuantity.Text = Math.Round(monthSum).ToString();

                    textEditSumMoney.Text = Math.Round(z6 / 10000.0).ToString();

                    textEditQW1.Text = z1.ToString();
                    textEditQW2.Text = z2.ToString();
                    textEditQW3.Text = z3.ToString();
                    textEditQW4.Text = z4.ToString();
                    textEditQW5.Text = z5.ToString();
                    XtraMessageBox.Show("月度预测完成！");                    
                }
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("月度预测：" + ex.Message);
                return;
            }
        }

        private double GetDefDouble(object obj, double def)
        {
            if (obj == System.DBNull.Value
                || obj == null
                || obj.ToString() == "")
                return def;

            return double.Parse(obj.ToString());
        }

        private double GetDefDouble_N(object obj, double def, int N)
        {
            if (obj == System.DBNull.Value
                || obj == null
                || obj.ToString() == "")
                return def;

            return Math.Round(double.Parse(obj.ToString()), N);
        }

        private int GetDefInt(object obj, int def)
        {
            if (obj == System.DBNull.Value
                || obj == null
                || obj.ToString() == "")
                return def;

            return int.Parse(obj.ToString());
        }

        //保存月度参数
        private void barButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //保存公用参数
            try
            {             
                //公用参数
                int E = GetDefInt(spinEditE.EditValue,0);
                int T = GetDefInt(spinEditT.EditValue, 0);
                double Eta = Math.Round(GetDefDouble(spinEditEta.EditValue,0), 2);
                int L = GetDefInt(spinEditL.EditValue, 0);
                int C = GetDefInt(spinEditC.EditValue, 0);
                int Vs = GetDefInt(spinEditVs.EditValue, 0);
                int V = GetDefInt(spinEditV.EditValue, 0);
                int V0 = GetDefInt(spinEditV0.EditValue, 0);
                int MP = GetDefInt(spinEditMP.EditValue, 0);

                int M = GetDefInt(spinEditM.EditValue, 0);
                int D = GetDefInt(spinEditD.EditValue, 0);

                int P1 = GetDefInt(spinEditBBCPW1.EditValue, 0);
                int P2 = GetDefInt(spinEditBBCPW2.EditValue, 0);
                int P3 = GetDefInt(spinEditBBCPW3.EditValue, 0);
                int P4 = GetDefInt(spinEditBBCPW4.EditValue, 0);
                int P5 = GetDefInt(spinEditBBCPW5.EditValue, 0);
                int S1 = GetDefInt(spinEditOSW1.EditValue, 0);
                int S2 = GetDefInt(spinEditOSW2.EditValue, 0);
                int S3 = GetDefInt(spinEditOSW3.EditValue, 0);
                int S4 = GetDefInt(spinEditOSW4.EditValue, 0);
                int S5 = GetDefInt(spinEditOSW5.EditValue, 0);

                int Q1 = 0, Q2 = 0, Q3 = 0, Q4 = 0, Q5 = 0, sumQuantity = 0, sumMoney = 0;
                Q1 = GetDefInt(textEditQW1.EditValue, 0);
                Q2 = GetDefInt(textEditQW2.EditValue, 0);
                Q3 = GetDefInt(textEditQW3.EditValue, 0);
                Q4 = GetDefInt(textEditQW4.EditValue, 0);
                Q5 = GetDefInt(textEditQW5.EditValue, 0);
                sumQuantity = GetDefInt(textEditSumQuantity.EditValue, 0);
                sumMoney = GetDefInt(textEditSumMoney.EditValue, 0);                

                string strTime = Convert.ToDateTime(timeEdit.EditValue).ToShortDateString();
                string str = "";
                if (OptionType == 1)
                {
                    //新建
                    str += " insert into  MonthForecast (E,T,Eta,L,C,Vs,V,V0,MP,M,D,P1,P2,P3,P4,P5,S1,S2,S3,S4,S5,Q1,Q2,Q3,Q4,Q5,ForecastTime,SumQuantity,SumMoney)";
                    str += " values (" + E + "," + T + "," + Eta + "," + L + "," + C + "," + Vs + "," + V + "," + V0 + "," + MP + "," + M + "," + D;
                    str += "," + P1 + "," + P2 + "," + P3 + "," + P4 + "," + P5 + "," + S1 + "," + S2 + "," + S3 + "," + S4 + "," + S5 + "," + Q1 + "," + Q2 + "," + Q3 + "," + Q4 + "," + Q5 + ",'" + strTime + "'," + sumQuantity + "," + sumMoney + " )";
                }
                else
                {   //修改
                    str += " update MonthForecast set E=" + E + ",T=" + T + ",Eta=" + Eta + ",L=" + L + " ,C=" + C + ",Vs=" + Vs + ",V=" + V + ",V0=" + V0 + ",MP=" + MP + ",M=" + M + ",D=" + D;
                    str += " ,P1=" + P1 + " ,P2=" + P2 + " ,P3=" + P3 + " ,P4=" + P4 + " ,P5=" + P5;
                    str += " ,S1=" + S1 + " ,S2=" + S2 + " ,S3=" + S3 + " ,S4=" + S4 + " ,S5=" + S5;
                    str += " ,Q1=" + Q1 + " ,Q2=" + Q2 + " ,Q3=" + Q3 + " ,Q4=" + Q4 + " ,Q5=" + Q5;
                    str += " ,ForecastTime='" + strTime + "',SumQuantity="+sumQuantity+" ,SumMoney="+sumMoney ;
                    str += " where ID=" + ID;          
                }

                if (!mdbChange(str, "月度预测保存"))
                {
                    return;           
                }

                XtraMessageBox.Show("月度预测保存成功！" );
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("月度预测保存异常:" + ex.Message);
                return ;
            }
        }

        //输出Excel
        private void barButtonItemExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                 //建立Excel对象
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);
                excel.Visible = true;//是否打开该Excel文件

                //获取Excel多个单元格区域
                Microsoft.Office.Interop.Excel.Worksheet worksheet1= (Microsoft.Office.Interop.Excel.Worksheet)excel.Worksheets[1];
                Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)worksheet1.get_Range("A1:D8", Type.Missing);
                //内外边框
                range.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                range.Borders.Weight = 3;//设置单元格边框的粗细 
                range.EntireColumn.AutoFit();//自动调整列宽                 

                //填充数据    
                int n=0;
                int rowNumber = n,columnNumber = n+1;
                excel.Cells[rowNumber + 1, columnNumber] = "时间";
                excel.Cells[rowNumber + 2, columnNumber] = "第一周";
                excel.Cells[rowNumber + 3, columnNumber] = "第二周";
                excel.Cells[rowNumber + 4, columnNumber] = "第三周";
                excel.Cells[rowNumber + 5, columnNumber] = "第四周";
                excel.Cells[rowNumber + 6, columnNumber] = "第五周";

                rowNumber = n; columnNumber = n + 2;
                excel.Cells[rowNumber + 1, columnNumber] = "渤海湾煤炭价格,5000大卡,含税,元";
                excel.Cells[rowNumber + 2, columnNumber] = spinEditBBCPW1.Text;
                excel.Cells[rowNumber + 3, columnNumber] = spinEditBBCPW2.Text;
                excel.Cells[rowNumber + 4, columnNumber] = spinEditBBCPW3.Text;
                excel.Cells[rowNumber + 5, columnNumber] = spinEditBBCPW4.Text;
                excel.Cells[rowNumber + 6, columnNumber] = spinEditBBCPW5.Text;
                excel.Cells[rowNumber + 7, columnNumber] = "月购买煤量(吨)";
                excel.Cells[rowNumber + 8, columnNumber] = "月资金总量(万元)";

                rowNumber = n; columnNumber = n + 3;
                excel.Cells[rowNumber + 1, columnNumber] = "海运价格,含税,元";
                excel.Cells[rowNumber + 2, columnNumber] = spinEditOSW1.Text;
                excel.Cells[rowNumber + 3, columnNumber] = spinEditOSW2.Text;
                excel.Cells[rowNumber + 4, columnNumber] = spinEditOSW3.Text;
                excel.Cells[rowNumber + 5, columnNumber] = spinEditOSW4.Text;
                excel.Cells[rowNumber + 6, columnNumber] = spinEditOSW5.Text;             

                rowNumber = n; columnNumber = n + 4;
                excel.Cells[rowNumber + 1, columnNumber] = "预测购买煤量,元";
                excel.Cells[rowNumber + 2, columnNumber] = textEditQW1.Text;
                excel.Cells[rowNumber + 3, columnNumber] = textEditQW2.Text;
                excel.Cells[rowNumber + 4, columnNumber] = textEditQW3.Text;
                excel.Cells[rowNumber + 5, columnNumber] = textEditQW4.Text;
                excel.Cells[rowNumber + 6, columnNumber] = textEditQW5.Text;
                excel.Cells[rowNumber + 7, columnNumber] = textEditSumQuantity.Text;
                excel.Cells[rowNumber + 8, columnNumber] = textEditSumMoney.Text;

                return;
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return;
            }
        }

        //打印
        private void barButtonItemPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                System.Data.DataTable dt = new System.Data.DataTable();
                dt.Columns.Add("Customer");
                dt.Columns.Add("ForecastTime");
                dt.Columns.Add("E");
                dt.Columns.Add("T");
                dt.Columns.Add("Eta");
                dt.Columns.Add("L");
                dt.Columns.Add("C");
                dt.Columns.Add("Vs");
                dt.Columns.Add("V");
                dt.Columns.Add("V0");
                dt.Columns.Add("MP");
                dt.Columns.Add("M");
                dt.Columns.Add("D");

                dt.Columns.Add("P1");
                dt.Columns.Add("P2");
                dt.Columns.Add("P3");
                dt.Columns.Add("P4");
                dt.Columns.Add("P5");
                dt.Columns.Add("S1");
                dt.Columns.Add("S2");
                dt.Columns.Add("S3");
                dt.Columns.Add("S4");
                dt.Columns.Add("S5");
                dt.Columns.Add("Q1");
                dt.Columns.Add("Q2");
                dt.Columns.Add("Q3");
                dt.Columns.Add("Q4");
                dt.Columns.Add("Q5");
                dt.Columns.Add("SumQuantity");
                dt.Columns.Add("SumMoney");

                DataRow dr = dt.NewRow();
                dr["Customer"] = Customer;
                dr["ForecastTime"] =  Convert.ToDateTime(timeEdit.EditValue).ToShortDateString();

                dr["E"] = spinEditE.EditValue;
                dr["T"] = spinEditT.EditValue;
                dr["Eta"] = spinEditEta.EditValue;
                dr["L"] = spinEditL.EditValue;
                dr["C"] = spinEditC.EditValue;
                dr["Vs"] = spinEditVs.EditValue;
                dr["V"] = spinEditV.EditValue;
                dr["V0"] = spinEditV0.EditValue;
                dr["MP"] = spinEditMP.EditValue;
                dr["M"] = spinEditM.EditValue;
                dr["D"] = spinEditD.EditValue;

                dr["P1"] = spinEditBBCPW1.EditValue;
                dr["P2"] = spinEditBBCPW2.EditValue;
                dr["P3"] = spinEditBBCPW3.EditValue;
                dr["P4"] = spinEditBBCPW4.EditValue;
                dr["P5"] = spinEditBBCPW5.EditValue;

                dr["S1"] = spinEditOSW1.EditValue;
                dr["S2"] = spinEditOSW2.EditValue;
                dr["S3"] = spinEditOSW3.EditValue;
                dr["S4"] = spinEditOSW4.EditValue;
                dr["S5"] = spinEditOSW5.EditValue;

                if (   textEditQW1.EditValue == null
                    || textEditQW1.Text == "")
                {
                    dr["Q1"] = "";
                    dr["Q2"] = "";
                    dr["Q3"] = "";
                    dr["Q4"] = "";
                    dr["Q5"] = "";

                    dr["SumQuantity"] = "";
                    dr["SumMoney"] = "";
                }
                else
                {
                    dr["Q1"] = textEditQW1.EditValue;
                    dr["Q2"] = textEditQW2.EditValue;
                    dr["Q3"] = textEditQW3.EditValue;
                    dr["Q4"] = textEditQW4.EditValue;
                    dr["Q5"] = textEditQW5.EditValue;

                    dr["SumQuantity"] = textEditSumQuantity.EditValue;
                    dr["SumMoney"] = textEditSumMoney.EditValue;
                }
               
                dt.Rows.Add(dr);

                XtraReport_Month rpt = new XtraReport_Month();

                rpt.DataSource = dt;
                rpt.ShowPreview();
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("月度预测打印异常：" + ex.Message);
            }
        }
    }
}