using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using Auseft;
using System.Data.OleDb;
using DevExpress.XtraGrid.Views.Base;

namespace Coal_YearForecast
{
    public partial class XtraForm_Year : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm_Year()
        {
            InitializeComponent();
        }

        public string Customer = "";
        public int OptionType = 1;//1 新建  2 修改
        public int ID = 0;//修改时，当前记录的ID
        public string constr = "";
        public DataRow row;

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

        private void XtraForm_Year_Load(object sender, EventArgs e)
        {
            spinEditE.Focus();

            if (OptionType == 2)
            {
                //初始化结果
                textEditSumMoney.Text = row["SumMoney"].ToString();
                textEditSumQuantity.Text = row["SumQuantity"].ToString();
                timeEdit.EditValue = row["ForecastTime"];
                textEditQM1.Text = row["Q1"].ToString();
                textEditQM2.Text = row["Q2"].ToString();
                textEditQM3.Text = row["Q3"].ToString();
                textEditQM4.Text = row["Q4"].ToString();
                textEditQM5.Text = row["Q5"].ToString();
                textEditQM6.Text = row["Q6"].ToString();
                textEditQM7.Text = row["Q7"].ToString();
                textEditQM8.Text = row["Q8"].ToString();
                textEditQM9.Text = row["Q9"].ToString();
                textEditQM10.Text = row["Q10"].ToString();
                textEditQM11.Text = row["Q11"].ToString();
                textEditQM12.Text = row["Q12"].ToString();

                spinEditBBCPM1.Text = row["P1"].ToString();
                spinEditBBCPM2.Text = row["P2"].ToString();
                spinEditBBCPM3.Text = row["P3"].ToString();
                spinEditBBCPM4.Text = row["P4"].ToString();
                spinEditBBCPM5.Text = row["P5"].ToString();
                spinEditBBCPM6.Text = row["P6"].ToString();
                spinEditBBCPM7.Text = row["P7"].ToString();
                spinEditBBCPM8.Text = row["P8"].ToString();
                spinEditBBCPM9.Text = row["P9"].ToString();
                spinEditBBCPM10.Text = row["P10"].ToString();
                spinEditBBCPM11.Text = row["P11"].ToString();
                spinEditBBCPM12.Text = row["P12"].ToString();

                spinEditOSM1.Text = row["S1"].ToString();
                spinEditOSM2.Text = row["S2"].ToString();
                spinEditOSM3.Text = row["S3"].ToString();
                spinEditOSM4.Text = row["S4"].ToString();
                spinEditOSM5.Text = row["S5"].ToString();
                spinEditOSM6.Text = row["S6"].ToString();
                spinEditOSM7.Text = row["S7"].ToString();
                spinEditOSM8.Text = row["S8"].ToString();
                spinEditOSM9.Text = row["S9"].ToString();
                spinEditOSM10.Text = row["S10"].ToString();
                spinEditOSM11.Text = row["S11"].ToString();
                spinEditOSM12.Text = row["S12"].ToString();

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

        #region 更新进度列表

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

        private void barButtonItemForecast_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                textEditSumMoney.Text = "";
                textEditSumQuantity.Text = "";
                textEditQM1.Text = "";
                textEditQM2.Text = "";
                textEditQM3.Text = "";
                textEditQM4.Text = "";
                textEditQM5.Text = "";
                textEditQM6.Text = "";
                textEditQM7.Text = "";
                textEditQM8.Text = "";
                textEditQM9.Text = "";
                textEditQM10.Text = "";
                textEditQM11.Text = "";
                textEditQM12.Text = "";

                System.Threading.Thread.Sleep(100);
                SetTextMessage(20);

                #region 取值：公用参数  每月煤价  每月海运价格
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
                else if (V <= 0)
                {
                    XtraMessageBox.Show("实际库存需为正数");
                    spinEditV.Focus();
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
                else if ( MP < 0)
                {
                    XtraMessageBox.Show("最小采购量需非负");
                    spinEditMP.Focus();
                    return;
                }

                int D = (int)(Math.Round(1.72152 * E + 0.14346 * T) / Eta);//月耗煤量
                int M = (int)(V0 - V + V0 / L * D / 30.4);//月最大采购量

                spinEditD.Text = D.ToString();
                spinEditM.Text = M.ToString();              

                if ( D <= 0)
                {
                    XtraMessageBox.Show("月耗煤量需为正数");
                    spinEditD.Focus();
                    return;
                }
                else if ( M <= 0)
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
                int pm1 = Convert.ToInt32(spinEditBBCPM1.EditValue);
                int pm2 = Convert.ToInt32(spinEditBBCPM2.EditValue);
                int pm3 = Convert.ToInt32(spinEditBBCPM3.EditValue);
                int pm4 = Convert.ToInt32(spinEditBBCPM4.EditValue);
                int pm5 = Convert.ToInt32(spinEditBBCPM5.EditValue);
                int pm6 = Convert.ToInt32(spinEditBBCPM6.EditValue);
                int pm7 = Convert.ToInt32(spinEditBBCPM7.EditValue);
                int pm8 = Convert.ToInt32(spinEditBBCPM8.EditValue);
                int pm9 = Convert.ToInt32(spinEditBBCPM9.EditValue);
                int pm10 = Convert.ToInt32(spinEditBBCPM10.EditValue);
                int pm11 = Convert.ToInt32(spinEditBBCPM11.EditValue);
                int pm12 = Convert.ToInt32(spinEditBBCPM12.EditValue);

                int sm1 = Convert.ToInt32(spinEditOSM1.EditValue);
                int sm2 = Convert.ToInt32(spinEditOSM2.EditValue);
                int sm3 = Convert.ToInt32(spinEditOSM3.EditValue);
                int sm4 = Convert.ToInt32(spinEditOSM4.EditValue);
                int sm5 = Convert.ToInt32(spinEditOSM5.EditValue);
                int sm6 = Convert.ToInt32(spinEditOSM6.EditValue);
                int sm7 = Convert.ToInt32(spinEditOSM7.EditValue);
                int sm8 = Convert.ToInt32(spinEditOSM8.EditValue);
                int sm9 = Convert.ToInt32(spinEditOSM9.EditValue);
                int sm10 = Convert.ToInt32(spinEditOSM10.EditValue);
                int sm11 = Convert.ToInt32(spinEditOSM11.EditValue);
                int sm12 = Convert.ToInt32(spinEditOSM12.EditValue);

                if (pm1 <= 0
                    || pm2 <= 0
                    || pm3 <= 0
                    || pm4 <= 0
                    || pm5 <= 0
                    || pm6 <= 0
                    || pm7 <= 0
                    || pm8 <= 0
                    || pm9 <= 0
                    || pm10 <= 0
                    || pm11 <= 0
                    || pm12 <= 0)
                {
                    XtraMessageBox.Show("渤海湾煤炭价格均需为正数");
                    spinEditBBCPM1.Focus();
                    return;
                }

                if (sm1 < 0
                    || sm2 < 0
                    || sm3 < 0
                    || sm4 < 0
                    || sm5 < 0
                    || sm6 < 0
                    || sm7 < 0
                    || sm8 < 0
                    || sm9 < 0
                    || sm10 < 0
                    || sm11 < 0
                    || sm12 < 0)
                {
                    XtraMessageBox.Show("海运价格需非负");
                    spinEditOSM1.Focus();
                    return;
                }
                #endregion

                System.Threading.Thread.Sleep(100);
                SetTextMessage(60);
                //--------------------------------------------------------------------------------------------------------
                //---------------------------------------matlab计算

                Auseft.Demo calObj = new Demo();

                //此时，也可建立MWArray类作为以便matlab能够识别
                MWArray[] arr = calObj.coalyear(14, V0, M, V, Vs, D,
                                pm1, sm1, pm2, sm2, pm3, sm3, pm4, sm4, pm5, sm5, pm6, sm6,
                                pm7, sm7, pm8, sm8, pm9, sm9, pm10, sm10, pm11, sm11, pm12, sm12);
                MWNumericArray y1 = (MWNumericArray)arr[0];
                MWNumericArray y2 = (MWNumericArray)arr[1];
                MWNumericArray y3 = (MWNumericArray)arr[2];
                MWNumericArray y4 = (MWNumericArray)arr[3];
                MWNumericArray y5 = (MWNumericArray)arr[4];
                MWNumericArray y6 = (MWNumericArray)arr[5];
                MWNumericArray y7 = (MWNumericArray)arr[6];
                MWNumericArray y8 = (MWNumericArray)arr[7];
                MWNumericArray y9 = (MWNumericArray)arr[8];
                MWNumericArray y10 = (MWNumericArray)arr[9];
                MWNumericArray y11 = (MWNumericArray)arr[10];
                MWNumericArray y12 = (MWNumericArray)arr[11];
                MWNumericArray y13 = (MWNumericArray)arr[12];
                MWNumericArray y14 = (MWNumericArray)arr[13];
                double[,] y31 = (double[,])y1.ToArray(MWArrayComponent.Real);
                double[,] y32 = (double[,])y2.ToArray(MWArrayComponent.Real);
                double[,] y33 = (double[,])y3.ToArray(MWArrayComponent.Real);
                double[,] y34 = (double[,])y4.ToArray(MWArrayComponent.Real);
                double[,] y35 = (double[,])y5.ToArray(MWArrayComponent.Real);
                double[,] y36 = (double[,])y6.ToArray(MWArrayComponent.Real);
                double[,] y37 = (double[,])y7.ToArray(MWArrayComponent.Real);
                double[,] y38 = (double[,])y8.ToArray(MWArrayComponent.Real);
                double[,] y39 = (double[,])y9.ToArray(MWArrayComponent.Real);
                double[,] y40 = (double[,])y10.ToArray(MWArrayComponent.Real);
                double[,] y41 = (double[,])y11.ToArray(MWArrayComponent.Real);
                double[,] y42 = (double[,])y12.ToArray(MWArrayComponent.Real);
                double[,] y43 = (double[,])y13.ToArray(MWArrayComponent.Real);
                double[,] y44 = (double[,])y14.ToArray(MWArrayComponent.Real);
                int z1 = (int)Math.Round(y31[0, 0], 0);
                int z2 = (int)Math.Round(y32[0, 0], 0);
                int z3 = (int)Math.Round(y33[0, 0], 0);
                int z4 = (int)Math.Round(y34[0, 0], 0);
                int z5 = (int)Math.Round(y35[0, 0], 0);
                int z6 = (int)Math.Round(y36[0, 0], 0);
                int z7 = (int)Math.Round(y37[0, 0], 0);
                int z8 = (int)Math.Round(y38[0, 0], 0);
                int z9 = (int)Math.Round(y39[0, 0], 0);
                int z10 = (int)Math.Round(y40[0, 0], 0);
                int z11 = (int)Math.Round(y41[0, 0], 0);
                int z12 = (int)Math.Round(y42[0, 0], 0);
                int z13 = (int)Math.Round(y43[0, 0], 0);
                int z14 = (int)Math.Round(y44[0, 0], 0);

                //解信息----------------------------------------------------------------------------------
                if (z14 < 1)
                {
                    System.Threading.Thread.Sleep(100);
                    SetTextMessage(100);
                    XtraMessageBox.Show("符合条件限制的年度预测方案未找到！");
                }
                else
                {
                    textEditSumMoney.Text = Math.Round(z13 / 10000.0).ToString();

                    double yearSum = z1 + z2 + z3 + z4 + z5 + z6 + z7 + z8 + z9 + z10 + z11 + z12;
                    textEditSumQuantity.Text = Math.Round(yearSum).ToString();
                    textEditQM1.Text = z1.ToString();
                    textEditQM2.Text = z2.ToString();
                    textEditQM3.Text = z3.ToString();
                    textEditQM4.Text = z4.ToString();
                    textEditQM5.Text = z5.ToString();
                    textEditQM6.Text = z6.ToString();
                    textEditQM7.Text = z7.ToString();
                    textEditQM8.Text = z8.ToString();
                    textEditQM9.Text = z9.ToString();
                    textEditQM10.Text = z10.ToString();
                    textEditQM11.Text = z11.ToString();
                    textEditQM12.Text = z12.ToString();
                    System.Threading.Thread.Sleep(100);
                    SetTextMessage(100);
                    XtraMessageBox.Show("年度预测成功！");
                }                
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("年度预测：" + ex.Message);
            } 
        }

        private double GetDefDouble(object obj, double def)
        {
            if (   obj == System.DBNull.Value
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

        private void barButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //保存公用参数
            try
            {
                //公用参数
                int E = GetDefInt(spinEditE.EditValue,0);
                int T = GetDefInt(spinEditT.EditValue,0);
                double Eta = Math.Round( GetDefDouble(spinEditEta.EditValue,0), 2);
                int L = GetDefInt(spinEditL.EditValue,0);
                int C = GetDefInt(spinEditC.EditValue, 0);
                int Vs = GetDefInt(spinEditVs.EditValue,0);
                int V = GetDefInt(spinEditV.EditValue,0);
                int V0 = GetDefInt(spinEditV0.EditValue, 0);
                int MP = GetDefInt(spinEditMP.EditValue, 0);
                int M = GetDefInt(spinEditM.EditValue, 0);
                int D = GetDefInt(spinEditD.EditValue, 0);

                int P1 = GetDefInt(spinEditBBCPM1.EditValue, 0);
                int P2 = GetDefInt(spinEditBBCPM2.EditValue, 0);
                int P3 = GetDefInt(spinEditBBCPM3.EditValue, 0);
                int P4 = GetDefInt(spinEditBBCPM4.EditValue, 0);
                int P5 = GetDefInt(spinEditBBCPM5.EditValue, 0);
                int P6 = GetDefInt(spinEditBBCPM6.EditValue, 0);
                int P7 = GetDefInt(spinEditBBCPM7.EditValue, 0);
                int P8 = GetDefInt(spinEditBBCPM8.EditValue, 0);
                int P9 = GetDefInt(spinEditBBCPM9.EditValue, 0);
                int P10 = GetDefInt(spinEditBBCPM10.EditValue, 0);
                int P11 = GetDefInt(spinEditBBCPM11.EditValue, 0);
                int P12 = GetDefInt(spinEditBBCPM12.EditValue, 0);

                int S1 = GetDefInt(spinEditOSM1.EditValue,0);
                int S2 = GetDefInt(spinEditOSM2.EditValue, 0);
                int S3 = GetDefInt(spinEditOSM3.EditValue, 0);
                int S4 = GetDefInt(spinEditOSM4.EditValue, 0);
                int S5 = GetDefInt(spinEditOSM5.EditValue, 0);
                int S6 = GetDefInt(spinEditOSM6.EditValue, 0);
                int S7 = GetDefInt(spinEditOSM7.EditValue, 0);
                int S8 = GetDefInt(spinEditOSM8.EditValue, 0);
                int S9 = GetDefInt(spinEditOSM9.EditValue, 0);
                int S10 = GetDefInt(spinEditOSM10.EditValue, 0);
                int S11 = GetDefInt(spinEditOSM11.EditValue, 0);
                int S12 = GetDefInt(spinEditOSM12.EditValue, 0);

                int Q1 = GetDefInt(textEditQM1.EditValue,0);
                int Q2 = GetDefInt(textEditQM2.EditValue, 0);
                int Q3 = GetDefInt(textEditQM3.EditValue, 0);
                int Q4 = GetDefInt(textEditQM4.EditValue, 0);
                int Q5 = GetDefInt(textEditQM5.EditValue, 0);
                int Q6 = GetDefInt(textEditQM6.EditValue, 0);
                int Q7 = GetDefInt(textEditQM7.EditValue, 0);
                int Q8 = GetDefInt(textEditQM8.EditValue, 0);
                int Q9 = GetDefInt(textEditQM9.EditValue, 0);
                int Q10 = GetDefInt(textEditQM10.EditValue, 0);
                int Q11 = GetDefInt(textEditQM11.EditValue, 0);
                int Q12 = GetDefInt(textEditQM12.EditValue, 0);

                int sumQuantity = GetDefInt(textEditSumQuantity.EditValue,0);
                int sumMoney = GetDefInt(textEditSumMoney.EditValue, 0);

                string strTime = (new DateTime(Convert.ToDateTime(timeEdit.EditValue).Year, 1, 1)).ToShortDateString(); 
                string str = "";
                if (OptionType == 1)
                {
                    //新建
                    str += " insert into  YearForecast (E,T,Eta,L,C,Vs,V,V0,MP,M,D,P1,P2,P3,P4,P5,P6,P7,P8,P9,P10,P11,P12,S1,S2,S3,S4,S5,S6,S7,S8,S9,S10,S11,S12,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10,Q11,Q12,ForecastTime,SumQuantity,SumMoney)";
                    str += " values (" + E + "," + T + "," + Eta + "," + L + "," + C + "," + Vs + "," + V + "," + V0 + "," + MP + "," + M + "," + D;
                    str += "," + P1 + "," + P2 + "," + P3 + "," + P4 + "," + P5 + "," + P6 + "," + P7 + "," + P8 + "," + P9 + "," + P10 + "," + P11 + "," + P12;
                    str += "," + S1 + "," + S2 + "," + S3 + "," + S4 + "," + S5 + "," + S6 + "," + S7 + "," + S8 + "," + S9 + "," + S10 + "," + S11 + "," + S12;
                    str += "," + Q1 + "," + Q2 + "," + Q3 + "," + Q4 + "," + Q5 + "," + Q6 + "," + Q7 + "," + Q8 + "," + Q9 + "," + Q10 + "," + Q11 + "," + Q12;
                    str += ",'" + strTime + "'," + sumQuantity + "," + sumMoney + " )";
                }
                else
                {   //修改
                    str += " update YearForecast set E=" + E + ",T=" + T + ",Eta=" + Eta + ",L=" + L + " ,C=" + C + ",Vs=" + Vs + ",V=" + V + ",V0=" + V0 + ",MP=" + MP + ",M=" + M + ",D=" + D;
                    str += " ,P1=" + P1 + ",P2=" + P2 + ",P3=" + P3 + ",P4=" + P4 + " ,P5=" + P5 + " ,P6=" + P6 + ",P7=" + P7 + ",P8=" + P8 + ",P9=" + P9 + " ,P10=" + P10 + ",P11=" + P11 + " ,P12=" + P12;
                    str += " ,S1=" + S1 + " ,S2=" + S2 + " ,S3=" + S3 + " ,S4=" + S4 + " ,S5=" + S5 + " ,S6=" + S6 + ",S7=" + S7 + ",S8=" + S8 + ",S9=" + S9 + " ,S10=" + S10 + ",S11=" + S11 + " ,S12=" + S12;
                    str += " ,Q1=" + Q1 + " ,Q2=" + Q2 + " ,Q3=" + Q3 + " ,Q4=" + Q4 + " ,Q5=" + Q5 + " ,Q6=" + Q6 + " ,Q7=" + Q7 + " ,Q8=" + Q8 + " ,Q9=" + Q9 + " ,Q10=" + Q10 + " ,Q11=" + Q11 + " ,Q12=" + Q12;
                    str += " ,ForecastTime='" + strTime + "',SumQuantity=" + sumQuantity + " ,SumMoney=" + sumMoney;
                    str += " where ID=" + ID;
                }

                if (!mdbChange(str, "年度预测保存"))
                {
                    return;
                }

                XtraMessageBox.Show("年度预测保存成功！");
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("年度预测保存异常:" + ex.Message);
                return;
            }

        }

        private void barButtonItemExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //建立Excel对象
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Application.Workbooks.Add(true);
                excel.Visible = true;//是否打开该Excel文件

                //获取Excel多个单元格区域
                Microsoft.Office.Interop.Excel.Worksheet worksheet1 = (Microsoft.Office.Interop.Excel.Worksheet)excel.Worksheets[1];
                Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)worksheet1.get_Range("A1:D15", Type.Missing);
                //内外边框
                range.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                range.Borders.Weight = 3;//设置单元格边框的粗细 
                range.EntireColumn.AutoFit();//自动调整列宽


                //填充数据    
                int n = 0;
                int rowNumber = n, columnNumber = n + 1;
                excel.Cells[rowNumber + 1, columnNumber] = "时间";
                excel.Cells[rowNumber + 2, columnNumber] = "第一月";
                excel.Cells[rowNumber + 3, columnNumber] = "第二月";
                excel.Cells[rowNumber + 4, columnNumber] = "第三月";
                excel.Cells[rowNumber + 5, columnNumber] = "第四月";
                excel.Cells[rowNumber + 6, columnNumber] = "第五月";
                excel.Cells[rowNumber + 7, columnNumber] = "第六月";
                excel.Cells[rowNumber + 8, columnNumber] = "第七月";
                excel.Cells[rowNumber + 9, columnNumber] = "第八月";
                excel.Cells[rowNumber + 10, columnNumber] = "第九月";
                excel.Cells[rowNumber + 11, columnNumber] = "第十月";
                excel.Cells[rowNumber + 12, columnNumber] = "第十一月";
                excel.Cells[rowNumber + 13, columnNumber] = "第十二月";
                excel.Cells[rowNumber + 14, columnNumber] = "总计";

                rowNumber = n; columnNumber = n + 2;
                excel.Cells[rowNumber + 1, columnNumber] = "渤海湾煤炭价格，5000大卡,含税,元";
                excel.Cells[rowNumber + 2, columnNumber] = spinEditBBCPM1.Text;
                excel.Cells[rowNumber + 3, columnNumber] = spinEditBBCPM2.Text;
                excel.Cells[rowNumber + 4, columnNumber] = spinEditBBCPM3.Text;
                excel.Cells[rowNumber + 5, columnNumber] = spinEditBBCPM4.Text;
                excel.Cells[rowNumber + 6, columnNumber] = spinEditBBCPM5.Text;
                excel.Cells[rowNumber + 7, columnNumber] = spinEditBBCPM6.Text;
                excel.Cells[rowNumber + 8, columnNumber] = spinEditBBCPM7.Text;
                excel.Cells[rowNumber + 9, columnNumber] = spinEditBBCPM8.Text;
                excel.Cells[rowNumber + 10, columnNumber] = spinEditBBCPM9.Text;
                excel.Cells[rowNumber + 11, columnNumber] = spinEditBBCPM10.Text;
                excel.Cells[rowNumber + 12, columnNumber] = spinEditBBCPM11.Text;
                excel.Cells[rowNumber + 13, columnNumber] = spinEditBBCPM12.Text;
                excel.Cells[rowNumber + 14, columnNumber] = "年预测购买煤量(吨)";
                excel.Cells[rowNumber + 15, columnNumber] = "年预测资金总量(万元)";

                rowNumber = n; columnNumber = n + 3;
                excel.Cells[rowNumber + 1, columnNumber] = "海运价格，含税,元";
                excel.Cells[rowNumber + 2, columnNumber] = spinEditOSM1.Text;
                excel.Cells[rowNumber + 3, columnNumber] = spinEditOSM2.Text;
                excel.Cells[rowNumber + 4, columnNumber] = spinEditOSM3.Text;
                excel.Cells[rowNumber + 5, columnNumber] = spinEditOSM4.Text;
                excel.Cells[rowNumber + 6, columnNumber] = spinEditOSM5.Text;
                excel.Cells[rowNumber + 7, columnNumber] = spinEditOSM6.Text;
                excel.Cells[rowNumber + 8, columnNumber] = spinEditOSM7.Text;
                excel.Cells[rowNumber + 9, columnNumber] = spinEditOSM8.Text;
                excel.Cells[rowNumber + 10, columnNumber] = spinEditOSM9.Text;
                excel.Cells[rowNumber + 11, columnNumber] = spinEditOSM10.Text;
                excel.Cells[rowNumber + 12, columnNumber] = spinEditOSM11.Text;
                excel.Cells[rowNumber + 13, columnNumber] = spinEditOSM12.Text;

                rowNumber = n; columnNumber = n + 4;
                excel.Cells[rowNumber + 1, columnNumber] = "预测购买煤量，吨";
                excel.Cells[rowNumber + 2, columnNumber] = textEditQM1.Text;
                excel.Cells[rowNumber + 3, columnNumber] = textEditQM2.Text;
                excel.Cells[rowNumber + 4, columnNumber] = textEditQM3.Text;
                excel.Cells[rowNumber + 5, columnNumber] = textEditQM4.Text;
                excel.Cells[rowNumber + 6, columnNumber] = textEditQM5.Text;
                excel.Cells[rowNumber + 7, columnNumber] = textEditQM6.Text;
                excel.Cells[rowNumber + 8, columnNumber] = textEditQM7.Text;
                excel.Cells[rowNumber + 9, columnNumber] = textEditQM8.Text;
                excel.Cells[rowNumber + 10, columnNumber] = textEditQM9.Text;
                excel.Cells[rowNumber + 11, columnNumber] = textEditQM10.Text;
                excel.Cells[rowNumber + 12, columnNumber] = textEditQM11.Text;
                excel.Cells[rowNumber + 13, columnNumber] = textEditQM12.Text;
                excel.Cells[rowNumber + 14, columnNumber] = textEditSumQuantity.Text;
                excel.Cells[rowNumber + 15, columnNumber] = textEditSumMoney.Text;

                return;
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return;
            }
        }

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
                dt.Columns.Add("P6");
                dt.Columns.Add("P7");
                dt.Columns.Add("P8");
                dt.Columns.Add("P9");
                dt.Columns.Add("P10");
                dt.Columns.Add("P11");
                dt.Columns.Add("P12");

                dt.Columns.Add("S1");
                dt.Columns.Add("S2");
                dt.Columns.Add("S3");
                dt.Columns.Add("S4");
                dt.Columns.Add("S5");
                dt.Columns.Add("S6");
                dt.Columns.Add("S7");
                dt.Columns.Add("S8");
                dt.Columns.Add("S9");
                dt.Columns.Add("S10");
                dt.Columns.Add("S11");
                dt.Columns.Add("S12");

                dt.Columns.Add("Q1");
                dt.Columns.Add("Q2");
                dt.Columns.Add("Q3");
                dt.Columns.Add("Q4");
                dt.Columns.Add("Q5");
                dt.Columns.Add("Q6");
                dt.Columns.Add("Q7");
                dt.Columns.Add("Q8");
                dt.Columns.Add("Q9");
                dt.Columns.Add("Q10");
                dt.Columns.Add("Q11");
                dt.Columns.Add("Q12");

                dt.Columns.Add("SumQuantity");
                dt.Columns.Add("SumMoney");

                DataRow dr = dt.NewRow();
                dr["Customer"] = Customer;
                dr["ForecastTime"] = new DateTime( Convert.ToDateTime(timeEdit.EditValue).Year,1,1); 

                dr["E"] = spinEditE.Text;
                dr["T"] = spinEditT.Text;
                dr["Eta"] = spinEditEta.Text;
                dr["L"] = spinEditL.Text;
                dr["C"] = spinEditC.Text;
                dr["Vs"] = spinEditVs.Text;
                dr["V"] = spinEditV.Text;
                dr["V0"] = spinEditV0.Text;
                dr["MP"] = spinEditMP.Text;
                dr["M"] = spinEditM.Text;
                dr["D"] = spinEditD.Text;

                dr["P1"] = spinEditBBCPM1.Text;
                dr["P2"] = spinEditBBCPM2.Text;
                dr["P3"] = spinEditBBCPM3.Text;
                dr["P4"] = spinEditBBCPM4.Text;
                dr["P5"] = spinEditBBCPM5.Text;
                dr["P6"] = spinEditBBCPM6.Text;
                dr["P7"] = spinEditBBCPM7.Text;
                dr["P8"] = spinEditBBCPM8.Text;
                dr["P9"] = spinEditBBCPM9.Text;
                dr["P10"] = spinEditBBCPM10.Text;
                dr["P11"] = spinEditBBCPM11.Text;
                dr["P12"] = spinEditBBCPM12.Text;

                dr["S1"] = spinEditOSM1.Text;
                dr["S2"] = spinEditOSM2.Text;
                dr["S3"] = spinEditOSM3.Text;
                dr["S4"] = spinEditOSM4.Text;
                dr["S5"] = spinEditOSM5.Text;
                dr["S6"] = spinEditOSM6.Text;
                dr["S7"] = spinEditOSM7.Text;
                dr["S8"] = spinEditOSM8.Text;
                dr["S9"] = spinEditOSM9.Text;
                dr["S10"] = spinEditOSM10.Text;
                dr["S11"] = spinEditOSM11.Text;
                dr["S12"] = spinEditOSM12.Text;

                if (  textEditQM1.EditValue == null
                   || textEditQM1.Text == "")
                {
                    dr["Q1"] = "";
                    dr["Q2"] = "";
                    dr["Q3"] = "";
                    dr["Q4"] = "";
                    dr["Q5"] = "";
                    dr["Q6"] = "";
                    dr["Q7"] = "";
                    dr["Q8"] = "";
                    dr["Q9"] = "";
                    dr["Q10"] = "";
                    dr["Q11"] = "";
                    dr["Q12"] = "";
                    dr["SumQuantity"] = "";
                    dr["SumMoney"] = "";
                }
                else
                {
                    dr["Q1"] = textEditQM1.Text;
                    dr["Q2"] = textEditQM2.Text;
                    dr["Q3"] = textEditQM3.Text;
                    dr["Q4"] = textEditQM4.Text;
                    dr["Q5"] = textEditQM5.Text;
                    dr["Q6"] = textEditQM6.Text;
                    dr["Q7"] = textEditQM7.Text;
                    dr["Q8"] = textEditQM8.Text;
                    dr["Q9"] = textEditQM9.Text;
                    dr["Q10"] = textEditQM10.Text;
                    dr["Q11"] = textEditQM11.Text;
                    dr["Q12"] = textEditQM12.Text;
                    dr["SumQuantity"] = textEditSumQuantity.Text;
                    dr["SumMoney"] = textEditSumMoney.Text;
                }             
               
                dt.Rows.Add(dr);

                XtraReport_Year rpt = new XtraReport_Year();
                rpt.DataSource = dt;
                rpt.ShowPreview();
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("年度预测打印异常：" + ex.Message);
            }
        }

        private void barButtonItemExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}