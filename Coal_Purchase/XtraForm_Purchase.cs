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

namespace Coal_Purchase
{
    public partial class XtraForm_Purchase : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm_Purchase()
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

        #region  预测限制参数
        int E = 0;//月发电量
        int T = 0;//月供汽量
        double Eta = 0;//锅炉效率
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

        #region 获取采购价格信息
        int[] nCoalPrice = { 0, 0, 0, 0, 0 };
        private void lookUpEditCN1_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                nCoalPrice[0] = int.Parse(lookUpEditCN1.EditValue.ToString());

                //此处需保证字段“coalname”的唯一性
                int b = int.Parse(lookUpEditCN1.EditValue.ToString());
                DataRow[] rows = this.dataSet_Forecast.Coal_Quality.Select("ID=" + b);
                if (rows.Length > 0)
                {
                    lookUpEditSN1.EditValue = int.Parse(rows[0]["SupplierID"].ToString());
                    spinEditP11.EditValue = double.Parse(rows[0]["WeekPrice1"].ToString());
                    spinEditP21.EditValue = double.Parse(rows[0]["WeekPrice2"].ToString());
                    spinEditP31.EditValue = double.Parse(rows[0]["WeekPrice3"].ToString());
                    spinEditP41.EditValue = double.Parse(rows[0]["WeekPrice4"].ToString());
                    spinEditP51.EditValue = double.Parse(rows[0]["WeekPrice5"].ToString());
                    spinEditLimit1.EditValue = double.Parse(rows[0]["MonthlyLimit"].ToString());
                }

                labelControl101.Text = lookUpEditCN1.Text;
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("获取煤种1价格信息失败：" + ex.Message);
            }
        }

        private void lookUpEditCN2_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                nCoalPrice[1] = int.Parse(lookUpEditCN2.EditValue.ToString());

                //此处需保证字段“coalname”的唯一性
                int b = int.Parse(lookUpEditCN2.EditValue.ToString());
                DataRow[] rows = this.dataSet_Forecast.Coal_Quality.Select("ID=" + b);
                if (rows.Length > 0)
                {
                    lookUpEditSN2.EditValue = int.Parse(rows[0]["SupplierID"].ToString());
                    spinEditP12.EditValue = double.Parse(rows[0]["WeekPrice1"].ToString());
                    spinEditP22.EditValue = double.Parse(rows[0]["WeekPrice2"].ToString());
                    spinEditP32.EditValue = double.Parse(rows[0]["WeekPrice3"].ToString());
                    spinEditP42.EditValue = double.Parse(rows[0]["WeekPrice4"].ToString());
                    spinEditP52.EditValue = double.Parse(rows[0]["WeekPrice5"].ToString());
                    spinEditLimit2.EditValue = double.Parse(rows[0]["MonthlyLimit"].ToString());
                }

                labelControl102.Text = lookUpEditCN2.Text;
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("获取煤种2价格信息失败：" + ex.Message);
            }

        }

        private void lookUpEditCN3_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                nCoalPrice[2] = int.Parse(lookUpEditCN3.EditValue.ToString());

                //此处需保证字段“coalname”的唯一性
                int b = int.Parse(lookUpEditCN3.EditValue.ToString());
                DataRow[] rows = this.dataSet_Forecast.Coal_Quality.Select("ID=" + b);
                if (rows.Length > 0)
                {
                    lookUpEditSN3.EditValue = int.Parse(rows[0]["SupplierID"].ToString());
                    spinEditP13.EditValue = double.Parse(rows[0]["WeekPrice1"].ToString());
                    spinEditP23.EditValue = double.Parse(rows[0]["WeekPrice2"].ToString());
                    spinEditP33.EditValue = double.Parse(rows[0]["WeekPrice3"].ToString());
                    spinEditP43.EditValue = double.Parse(rows[0]["WeekPrice4"].ToString());
                    spinEditP53.EditValue = double.Parse(rows[0]["WeekPrice5"].ToString());
                    spinEditLimit3.EditValue = double.Parse(rows[0]["MonthlyLimit"].ToString());
                }

                labelControl103.Text = lookUpEditCN3.Text;
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("获取煤种3价格信息失败：" + ex.Message);
            }

        }

        private void lookUpEditCN4_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                nCoalPrice[3] = int.Parse(lookUpEditCN4.EditValue.ToString());

                //此处需保证字段“coalname”的唯一性
                int b = int.Parse(lookUpEditCN4.EditValue.ToString());
                DataRow[] rows = this.dataSet_Forecast.Coal_Quality.Select("ID=" + b);
                if (rows.Length > 0)
                {
                    lookUpEditSN4.EditValue = int.Parse(rows[0]["SupplierID"].ToString());
                    spinEditP14.EditValue = double.Parse(rows[0]["WeekPrice1"].ToString());
                    spinEditP24.EditValue = double.Parse(rows[0]["WeekPrice2"].ToString());
                    spinEditP34.EditValue = double.Parse(rows[0]["WeekPrice3"].ToString());
                    spinEditP44.EditValue = double.Parse(rows[0]["WeekPrice4"].ToString());
                    spinEditP54.EditValue = double.Parse(rows[0]["WeekPrice5"].ToString());
                    spinEditLimit4.EditValue = double.Parse(rows[0]["MonthlyLimit"].ToString());
                }

                labelControl104.Text = lookUpEditCN4.Text;
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("获取煤种4价格信息失败：" + ex.Message);
            }

        }

        private void lookUpEditCN5_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                nCoalPrice[4] = int.Parse(lookUpEditCN5.EditValue.ToString());

                //此处需保证字段“coalname”的唯一性
                int b = int.Parse(lookUpEditCN5.EditValue.ToString());
                DataRow[] rows = this.dataSet_Forecast.Coal_Quality.Select("ID=" + b);
                if (rows.Length > 0)
                {
                    lookUpEditSN5.EditValue = int.Parse(rows[0]["SupplierID"].ToString());
                    spinEditP15.EditValue = double.Parse(rows[0]["WeekPrice1"].ToString());
                    spinEditP25.EditValue = double.Parse(rows[0]["WeekPrice2"].ToString());
                    spinEditP35.EditValue = double.Parse(rows[0]["WeekPrice3"].ToString());
                    spinEditP45.EditValue = double.Parse(rows[0]["WeekPrice4"].ToString());
                    spinEditP55.EditValue = double.Parse(rows[0]["WeekPrice5"].ToString());
                    spinEditLimit5.EditValue = double.Parse(rows[0]["MonthlyLimit"].ToString());
                }

                labelControl105.Text = lookUpEditCN5.Text;
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("获取煤种5价格信息失败：" + ex.Message);
            }

        }

        #endregion

        //处理出现采购量小于最小采购量情况
        private void PPP(ref int z1, ref int z2, ref int z3, ref int z4, ref int z5, int num)
        {
            try
            {
                int[] data = { z1, z2, z3, z4, z5 };
                int temp = 0;
                bool ok = true;
                if (true)
                {
                    //1.累计不满最小采购量的值------------------------------------------------------
                    for (int i = 0; i < num; ++i)
                    {
                        if (data[i] < MP)
                        {
                            temp += data[i];
                            data[i] = 0;
                            ok = false;
                        }
                    }

                    /////////////////////////////////////////////////////////////////
                    //2.1寻找合适的存放位置，放置到合适的数组中：第一个采购量非零的周
                    //for (int j = 0; j < num; j++)
                    //{
                    //    if (data[j] != 0)
                    //    {
                    //        data[j] += temp;
                    //        ok = true;
                    //        break;
                    //    }
                    //}                

                    //2.2查找非零采购量且最小价格的周放置
                    int beginIndex = -1;
                    int minQuality = 0;
                    int minIndex = -1;
                    bool bFind = false;
                    double[] tempPrice = { sw1, sw2, sw3, sw4, sw5 };
                    //获取起始非零值和地址
                    for (int i = 0; i < 5; i++)
                    {
                        if (data[i] > 0)
                        {
                            minQuality = data[i];
                            minIndex = i;
                            beginIndex = i;
                            bFind = true;
                            break;
                        }
                    }
                    //若存在非零值，则查找非零采购量的最小价格值
                    if (beginIndex != -1)
                    {
                        for (int i = beginIndex + 1; i < 5; i++)
                        {
                            if (data[i] > 0
                                && tempPrice[i] < tempPrice[minIndex])
                            {
                                minQuality = data[i];
                                minIndex = i;
                            }
                        }

                        data[minIndex] += temp;
                        ok = true;
                    }
                    //////////////////////////////////////////////////////////////////////////

                    //3.若未找到存放位置，则统一放在价格最小的周
                    if (!ok)
                    {
                        int[] tempS = { sw1, sw2, sw3, sw4, sw5 };
                        double min = tempS[0];
                        int index = 0;
                        for (int i = 1; i < num; i++)
                        {
                            if (min < tempS[i])
                            {
                                min = tempS[i];
                                index = i;
                            }
                        }

                        data[index] += temp;
                    }

                    z1 = data[0];
                    z2 = data[1];
                    z3 = data[2];
                    z4 = data[3];
                    z5 = data[4];
                }
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return;
            }
        }

        private void XtraForm_Purchase_Load(object sender, EventArgs e)
        {
            this.supplierTableAdapter.Connection.ConnectionString = constr;
            this.coal_QualityTableAdapter.Connection.ConnectionString = constr;
            this.purchaseRecordTableAdapter.Connection.ConnectionString = constr;

            this.supplierTableAdapter.Fill(this.dataSet_Forecast.Supplier);
            this.coal_QualityTableAdapter.Fill(this.dataSet_Forecast.Coal_Quality);
            this.purchaseRecordTableAdapter.Fill(this.dataSet_Forecast.PurchaseRecord);

            if (OptionType == 2)
            {
                //初始化结果
                textEditSumMoney.Text = row["SumMoney"].ToString();
                textEditSumQuantity.Text = row["SumQuantity"].ToString();
                timeEdit.EditValue = row["ForecastTime"];

                lookUpEditCN1.EditValue =  Convert.ToInt32( row["coalName1"]);
                lookUpEditCN2.EditValue =  Convert.ToInt32(row["coalName2"]);
                lookUpEditCN3.EditValue =  Convert.ToInt32(row["coalName3"]);
                lookUpEditCN4.EditValue =  Convert.ToInt32(row["coalName4"]);
                lookUpEditCN5.EditValue =  Convert.ToInt32(row["coalName5"]);

                spinEditLimit1.Text = row["Limit1"].ToString();
                spinEditLimit2.Text = row["Limit2"].ToString();
                spinEditLimit3.Text = row["Limit3"].ToString();
                spinEditLimit4.Text = row["Limit4"].ToString();
                spinEditLimit5.Text = row["Limit5"].ToString();

                spinEditP11.Text = row["P11"].ToString();
                spinEditP12.Text = row["P12"].ToString();
                spinEditP13.Text = row["P13"].ToString();
                spinEditP14.Text = row["P14"].ToString();
                spinEditP15.Text = row["P15"].ToString();

                spinEditP21.Text = row["P21"].ToString();
                spinEditP22.Text = row["P22"].ToString();
                spinEditP23.Text = row["P23"].ToString();
                spinEditP24.Text = row["P24"].ToString();
                spinEditP25.Text = row["P25"].ToString();

                spinEditP31.Text = row["P31"].ToString();
                spinEditP32.Text = row["P32"].ToString();
                spinEditP33.Text = row["P33"].ToString();
                spinEditP34.Text = row["P34"].ToString();
                spinEditP35.Text = row["P35"].ToString();

                spinEditP41.Text = row["P41"].ToString();
                spinEditP42.Text = row["P42"].ToString();
                spinEditP43.Text = row["P43"].ToString();
                spinEditP44.Text = row["P44"].ToString();
                spinEditP45.Text = row["P45"].ToString();

                spinEditP51.Text = row["P51"].ToString();
                spinEditP52.Text = row["P52"].ToString();
                spinEditP53.Text = row["P53"].ToString();
                spinEditP54.Text = row["P54"].ToString();
                spinEditP55.Text = row["P55"].ToString();

                textEditQ11.Text = row["Q11"].ToString();
                textEditQ12.Text = row["Q12"].ToString();
                textEditQ13.Text = row["Q13"].ToString();
                textEditQ14.Text = row["Q14"].ToString();
                textEditQ15.Text = row["Q15"].ToString();
                textEditQ21.Text = row["Q21"].ToString();
                textEditQ22.Text = row["Q22"].ToString();
                textEditQ23.Text = row["Q23"].ToString();
                textEditQ24.Text = row["Q24"].ToString();
                textEditQ25.Text = row["Q25"].ToString();
                textEditQ31.Text = row["Q31"].ToString();
                textEditQ32.Text = row["Q32"].ToString();
                textEditQ33.Text = row["Q33"].ToString();
                textEditQ34.Text = row["Q34"].ToString();
                textEditQ35.Text = row["Q35"].ToString();
                textEditQ41.Text = row["Q41"].ToString();
                textEditQ42.Text = row["Q42"].ToString();
                textEditQ43.Text = row["Q43"].ToString();
                textEditQ44.Text = row["Q44"].ToString();
                textEditQ45.Text = row["Q45"].ToString();
                textEditQ51.Text = row["Q51"].ToString();
                textEditQ52.Text = row["Q52"].ToString();
                textEditQ53.Text = row["Q53"].ToString();
                textEditQ54.Text = row["Q54"].ToString();
                textEditQ55.Text = row["Q55"].ToString();

                spinEditOS1.Text = row["S1"].ToString();
                spinEditOS2.Text = row["S2"].ToString();
                spinEditOS3.Text = row["S3"].ToString();
                spinEditOS4.Text = row["S4"].ToString();
                spinEditOS5.Text = row["S5"].ToString();

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

        #region  更新进度列表

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
        private void barButtonItemPurchase_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                textEditSumQuantity.Text = "";
                textEditSumMoney.Text = "";

                //第一周的采购量
                textEditQ11.Text = "";
                textEditQ12.Text = "";
                textEditQ13.Text = "";
                textEditQ14.Text = "";
                textEditQ15.Text = "";
                //第二周的采购量
                textEditQ21.Text = "";
                textEditQ22.Text = "";
                textEditQ23.Text = "";
                textEditQ24.Text = "";
                textEditQ25.Text = "";
                //第三周的采购量
                textEditQ31.Text = "";
                textEditQ32.Text = "";
                textEditQ33.Text = "";
                textEditQ34.Text = "";
                textEditQ35.Text = "";
                //第四周的采购量
                textEditQ41.Text = "";
                textEditQ42.Text = "";
                textEditQ43.Text = "";
                textEditQ44.Text = "";
                textEditQ45.Text = "";
                //第五周的采购量
                textEditQ51.Text = "";
                textEditQ52.Text = "";
                textEditQ53.Text = "";
                textEditQ54.Text = "";
                textEditQ55.Text = "";

                System.Threading.Thread.Sleep(100);
                SetTextMessage(20);

                #region 检查输入项


                //计算通用参数
                int E = GetDefInt(spinEditE.EditValue,0);
                int T = GetDefInt(spinEditT.EditValue, 0);
                double Eta = GetDefDouble_N(spinEditEta.EditValue, 0,2);
                int L = GetDefInt(spinEditL.EditValue, 0);
                int C = GetDefInt(spinEditC.EditValue, 0);
                int V = GetDefInt(spinEditV.EditValue, 0);
                int Vs = GetDefInt(spinEditVs.EditValue, 0);
                int V0 = GetDefInt(spinEditV0.EditValue, 0);
                int MP = GetDefInt(spinEditMP.EditValue,0);

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

                if (lookUpEditCN1.EditValue == null
                    || lookUpEditCN2.EditValue == null
                    || lookUpEditCN3.EditValue == null
                    || lookUpEditCN4.EditValue == null
                    || lookUpEditCN5.EditValue == null)
                {
                    XtraMessageBox.Show("请选择五个煤种！");
                    return;
                }

                //检查选择的煤种是否存在重复
                for (int i = 0; i < 5; i++)
                {
                    int nCP = nCoalPrice[i];
                    for (int j = i + 1; j < 5; j++)
                    {
                        if (nCoalPrice[j] == nCP)
                        {
                            XtraMessageBox.Show("煤种选择存在重复！");
                            return;
                        }
                    }
                }
                #endregion

                #region 参数取值


                //第一周煤种价格
                p11 = GetDefInt(spinEditP11.EditValue, 0);
                p12 = GetDefInt(spinEditP12.EditValue, 0);
                p13 = GetDefInt(spinEditP13.EditValue, 0);
                p14 = GetDefInt(spinEditP14.EditValue, 0);
                p15 = GetDefInt(spinEditP15.EditValue, 0);
                //第二周煤种价格
                p21 = GetDefInt(spinEditP21.EditValue, 0);
                p22 = GetDefInt(spinEditP22.EditValue, 0);
                p23 = GetDefInt(spinEditP23.EditValue, 0);
                p24 = GetDefInt(spinEditP24.EditValue, 0);
                p25 = GetDefInt(spinEditP25.EditValue, 0);
                //第三周煤种价格
                p31 = GetDefInt(spinEditP31.EditValue, 0);
                p32 = GetDefInt(spinEditP32.EditValue, 0);
                p33 = GetDefInt(spinEditP33.EditValue, 0);
                p34 = GetDefInt(spinEditP34.EditValue, 0);
                p35 = GetDefInt(spinEditP35.EditValue, 0);
                //第四周煤种价格
                p41 = GetDefInt(spinEditP41.EditValue, 0);
                p42 = GetDefInt(spinEditP42.EditValue, 0);
                p43 = GetDefInt(spinEditP43.EditValue, 0);
                p44 = GetDefInt(spinEditP44.EditValue, 0);
                p45 = GetDefInt(spinEditP45.EditValue, 0);
                //第五周煤种价格
                p51 = GetDefInt(spinEditP51.EditValue, 0);
                p52 = GetDefInt(spinEditP52.EditValue, 0);
                p53 = GetDefInt(spinEditP53.EditValue, 0);
                p54 = GetDefInt(spinEditP54.EditValue, 0);
                p55 = GetDefInt(spinEditP55.EditValue, 0);

                //五周的海运价格
                sw1 = GetDefInt(spinEditOS1.EditValue, 0);
                sw2 = GetDefInt(spinEditOS2.EditValue, 0);
                sw3 = GetDefInt(spinEditOS3.EditValue, 0);
                sw4 = GetDefInt(spinEditOS4.EditValue, 0);
                sw5 = GetDefInt(spinEditOS5.EditValue, 0);

                int MaxXM1 = GetDefInt(spinEditLimit1.EditValue, 0);
                int MaxXM2 = GetDefInt(spinEditLimit2.EditValue, 0);
                int MaxXM3 = GetDefInt(spinEditLimit3.EditValue, 0);
                int MaxXM4 = GetDefInt(spinEditLimit4.EditValue, 0);
                int MaxXM5 = GetDefInt(spinEditLimit5.EditValue,0);

                if (p11 <= 0 || p21 <= 0 || p31 <= 0 || p41 <= 0 || p51 <= 0
                      || p12 <= 0 || p22 <= 0 || p32 <= 0 || p42 <= 0 || p52 <= 0
                      || p13 <= 0 || p23 <= 0 || p33 <= 0 || p43 <= 0 || p53 <= 0
                      || p14 <= 0 || p24 <= 0 || p34 <= 0 || p44 <= 0 || p54 <= 0
                      || p15 <= 0 || p25 <= 0 || p35 <= 0 || p45 <= 0 || p55 <= 0)
                {
                    XtraMessageBox.Show("各煤中价格均需为正数");
                    spinEditP11.Focus();
                    return;
                }

                if (sw1 < 0
                   || sw2 < 0
                   || sw3 < 0
                   || sw4 < 0
                   || sw5 < 0)
                {
                    XtraMessageBox.Show("海运价格需非负");
                    spinEditOS1.Focus();
                    return;
                }

                if (      MaxXM1 <= 0
                       || MaxXM2 <= 0
                       || MaxXM3 <= 0
                       || MaxXM4 <= 0
                       || MaxXM5 <= 0)
                {
                    XtraMessageBox.Show("各煤种的月度采购最大值均需为正数");
                    spinEditLimit1.Focus();
                    return;
                }

                #endregion

                System.Threading.Thread.Sleep(100);
                SetTextMessage(60);
                //--------------------------------------------------------------------------------------------------------
                //---------------------------------------matlab计算

                Auseft.Demo calObj = new Demo();
                MWArray[] arr = calObj.Procurement(27, V0, M, V, Vs, D,
                                                 MaxXM1, MaxXM2, MaxXM3, MaxXM4, MaxXM5,
                                                 p11, p12, p13, p14, p15,
                                                 p21, p22, p23, p24, p25,
                                                 p31, p32, p33, p34, p35,
                                                 p41, p42, p43, p44, p45,
                                                 p51, p52, p53, p54, p55,
                                                 sw1, sw2, sw3, sw4, sw5);

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
                MWNumericArray y15 = (MWNumericArray)arr[14];
                MWNumericArray y16 = (MWNumericArray)arr[15];
                MWNumericArray y17 = (MWNumericArray)arr[16];
                MWNumericArray y18 = (MWNumericArray)arr[17];
                MWNumericArray y19 = (MWNumericArray)arr[18];
                MWNumericArray y20 = (MWNumericArray)arr[19];
                MWNumericArray y21 = (MWNumericArray)arr[20];
                MWNumericArray y22 = (MWNumericArray)arr[21];
                MWNumericArray y23 = (MWNumericArray)arr[22];
                MWNumericArray y24 = (MWNumericArray)arr[23];
                MWNumericArray y25 = (MWNumericArray)arr[24];
                MWNumericArray y26 = (MWNumericArray)arr[25];
                MWNumericArray y27 = (MWNumericArray)arr[26];

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
                double[,] y45 = (double[,])y15.ToArray(MWArrayComponent.Real);
                double[,] y46 = (double[,])y16.ToArray(MWArrayComponent.Real);
                double[,] y47 = (double[,])y17.ToArray(MWArrayComponent.Real);
                double[,] y48 = (double[,])y18.ToArray(MWArrayComponent.Real);
                double[,] y49 = (double[,])y19.ToArray(MWArrayComponent.Real);
                double[,] y50 = (double[,])y20.ToArray(MWArrayComponent.Real);
                double[,] y51 = (double[,])y21.ToArray(MWArrayComponent.Real);
                double[,] y52 = (double[,])y22.ToArray(MWArrayComponent.Real);
                double[,] y53 = (double[,])y23.ToArray(MWArrayComponent.Real);
                double[,] y54 = (double[,])y24.ToArray(MWArrayComponent.Real);
                double[,] y55 = (double[,])y25.ToArray(MWArrayComponent.Real);
                double[,] y56 = (double[,])y26.ToArray(MWArrayComponent.Real);
                double[,] y57 = (double[,])y27.ToArray(MWArrayComponent.Real);

                int z1 = (int)Math.Round(y31[0, 0] / 1.1513, 0);
                int z2 = (int)Math.Round(y32[0, 0] / 1.1513, 0);
                int z3 = (int)Math.Round(y33[0, 0] / 1.1513, 0);
                int z4 = (int)Math.Round(y34[0, 0] / 1.1513, 0);
                int z5 = (int)Math.Round(y35[0, 0] / 1.1513, 0);
                int z6 = (int)Math.Round(y36[0, 0] / 1.1513, 0);
                int z7 = (int)Math.Round(y37[0, 0] / 1.1513, 0);
                int z8 = (int)Math.Round(y38[0, 0] / 1.1513, 0);
                int z9 = (int)Math.Round(y39[0, 0] / 1.1513, 0);
                int z10 = (int)Math.Round(y40[0, 0] / 1.1513, 0);
                int z11 = (int)Math.Round(y41[0, 0] / 1.1513, 0);
                int z12 = (int)Math.Round(y42[0, 0] / 1.1513, 0);
                int z13 = (int)Math.Round(y43[0, 0] / 1.1513, 0);
                int z14 = (int)Math.Round(y44[0, 0] / 1.1513, 0);
                int z15 = (int)Math.Round(y45[0, 0] / 1.1513, 0);
                int z16 = (int)Math.Round(y46[0, 0] / 1.1513, 0);
                int z17 = (int)Math.Round(y47[0, 0] / 1.1513, 0);
                int z18 = (int)Math.Round(y48[0, 0] / 1.1513, 0);
                int z19 = (int)Math.Round(y49[0, 0] / 1.1513, 0);
                int z20 = (int)Math.Round(y50[0, 0] / 1.1513, 0);
                int z21 = (int)Math.Round(y51[0, 0] / 1.1513, 0);
                int z22 = (int)Math.Round(y52[0, 0] / 1.1513, 0);
                int z23 = (int)Math.Round(y53[0, 0] / 1.1513, 0);
                int z24 = (int)Math.Round(y54[0, 0] / 1.1513, 0);
                int z25 = (int)Math.Round(y55[0, 0] / 1.1513, 0);
                int z26 = (int)Math.Round(y56[0, 0] / 1.1513, 0);
                int z27 = (int)Math.Round(y57[0, 0], 0);

                //处理小于最小采购量的情况
                //int[] tempArray = { z1, z2, z3, z4, z5, z6, z7, z8, z9, z10, z11, z12, z13, z14, z15, z16, z17, z18, z19, z20, z21, z22, z23, z24, z25 };
                PPP(ref z1, ref  z6, ref z11, ref z16, ref z21, 5);
                PPP(ref z2, ref z7, ref z12, ref z17, ref z22, 5);
                PPP(ref z3, ref z8, ref z13, ref z18, ref z23, 5);
                PPP(ref z4, ref z9, ref z14, ref z19, ref z24, 5);
                PPP(ref z5, ref z10, ref z15, ref z20, ref z25, 5);

                int[] tempArray = { z1, z2, z3, z4, z5, z6, z7, z8, z9, z10, z11, z12, z13, z14, z15, z16, z17, z18, z19, z20, z21, z22, z23, z24, z25 };

                #region 输出最优解
                if (z27 < 1)
                {
                    System.Threading.Thread.Sleep(100);
                    SetTextMessage(100);

                    XtraMessageBox.Show("符合条件限制的煤种采购方案未找到！");
                }
                else
                {
                    //--------------------------------------------------show data------------------------------------------------------------------------
                    textEditSumMoney.Text = Math.Round(z26 / 10000.0).ToString();

                    //第一周的采购量
                    textEditQ11.Text = tempArray[0].ToString();
                    textEditQ12.Text = tempArray[1].ToString();
                    textEditQ13.Text = tempArray[2].ToString();
                    textEditQ14.Text = tempArray[3].ToString();
                    textEditQ15.Text = tempArray[4].ToString();
                    //第二周的采购量
                    textEditQ21.Text = tempArray[5].ToString();
                    textEditQ22.Text = tempArray[6].ToString();
                    textEditQ23.Text = tempArray[7].ToString();
                    textEditQ24.Text = tempArray[8].ToString();
                    textEditQ25.Text = tempArray[9].ToString();
                    //第三周的采购量
                    textEditQ31.Text = tempArray[10].ToString();
                    textEditQ32.Text = tempArray[11].ToString();
                    textEditQ33.Text = tempArray[12].ToString();
                    textEditQ34.Text = tempArray[13].ToString();
                    textEditQ35.Text = tempArray[14].ToString();
                    //第四周的采购量
                    textEditQ41.Text = tempArray[15].ToString();
                    textEditQ42.Text = tempArray[16].ToString();
                    textEditQ43.Text = tempArray[17].ToString();
                    textEditQ44.Text = tempArray[18].ToString();
                    textEditQ45.Text = tempArray[19].ToString();
                    //第五周的采购量
                    textEditQ51.Text = tempArray[20].ToString();
                    textEditQ52.Text = tempArray[21].ToString();
                    textEditQ53.Text = tempArray[22].ToString();
                    textEditQ54.Text = tempArray[23].ToString();
                    textEditQ55.Text = tempArray[24].ToString();

                    double sum1 = double.Parse(tempArray[0].ToString()) + double.Parse(tempArray[1].ToString())
                                       + double.Parse(tempArray[2].ToString()) + double.Parse(tempArray[3].ToString())
                                       + double.Parse(tempArray[4].ToString());
                    double sum2 = double.Parse(tempArray[5].ToString()) + double.Parse(tempArray[6].ToString())
                                       + double.Parse(tempArray[7].ToString()) + double.Parse(tempArray[8].ToString())
                                       + double.Parse(tempArray[9].ToString());
                    double sum3 = double.Parse(tempArray[10].ToString()) + double.Parse(tempArray[11].ToString())
                                       + double.Parse(tempArray[12].ToString()) + double.Parse(tempArray[13].ToString())
                                       + double.Parse(tempArray[14].ToString());
                    double sum4 = double.Parse(tempArray[15].ToString()) + double.Parse(tempArray[16].ToString())
                                       + double.Parse(tempArray[17].ToString()) + double.Parse(tempArray[18].ToString())
                                       + double.Parse(tempArray[19].ToString());
                    double sum5 = double.Parse(tempArray[20].ToString()) + double.Parse(tempArray[21].ToString())
                                       + double.Parse(tempArray[22].ToString()) + double.Parse(tempArray[23].ToString())
                                       + double.Parse(tempArray[24].ToString());
                    double sum = sum1 + sum2 + sum3 + sum4 + sum5;

                    textEditSumQuantity.Text = sum.ToString();

                    System.Threading.Thread.Sleep(100);
                    SetTextMessage(100);

                    XtraMessageBox.Show("采购计算完成！");
                }
                #endregion
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("采购计算：" + ex.Message);
            }
        }

        private void barButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //保存公用参数
            try
            {
                //公用参数
                int E = GetDefInt(spinEditE.EditValue, 0); 
                int T = GetDefInt(spinEditT.EditValue, 0);
                double Eta = GetDefDouble_N(spinEditEta.EditValue,0, 2);
                int L = GetDefInt(spinEditL.EditValue, 0); ;
                int C = GetDefInt(spinEditC.EditValue, 0);
                int Vs = GetDefInt(spinEditVs.EditValue, 0);
                int V = GetDefInt(spinEditV.EditValue, 0);
                int V0 = GetDefInt(spinEditV0.EditValue, 0);
                int MP = GetDefInt(spinEditMP.EditValue, 0);
                int M = GetDefInt(spinEditM.EditValue, 0);
                int D = GetDefInt(spinEditD.EditValue,0);

                int coalName1 = Convert.ToInt32(lookUpEditCN1.EditValue);
                int coalName2 = Convert.ToInt32(lookUpEditCN2.EditValue);
                int coalName3 = Convert.ToInt32(lookUpEditCN3.EditValue);
                int coalName4 = Convert.ToInt32(lookUpEditCN4.EditValue);
                int coalName5 = Convert.ToInt32(lookUpEditCN5.EditValue);
               
                int P11 = 0, P12 = 0, P13 = 0, P14 = 0, P15 = 0;
                int P21 = 0, P22 = 0, P23 = 0, P24 = 0, P25 = 0;
                int P31 = 0, P32 = 0, P33 = 0, P34 = 0, P35 = 0;
                int P41 = 0, P42 = 0, P43 = 0, P44 = 0, P45 = 0;
                int P51 = 0, P52 = 0, P53 = 0, P54 = 0, P55 = 0;

                P11 = GetDefInt(spinEditP11.EditValue, 0);
                P12 = GetDefInt(spinEditP12.EditValue, 0);
                P13 = GetDefInt(spinEditP13.EditValue, 0);
                P14 = GetDefInt(spinEditP14.EditValue, 0);
                P15 = GetDefInt(spinEditP15.EditValue, 0);
                P21 = GetDefInt(spinEditP21.EditValue, 0);
                P22 = GetDefInt(spinEditP22.EditValue, 0);
                P23 = GetDefInt(spinEditP23.EditValue, 0);
                P24 = GetDefInt(spinEditP24.EditValue, 0);
                P25 = GetDefInt(spinEditP25.EditValue, 0);
                P31 = GetDefInt(spinEditP31.EditValue, 0);
                P32 = GetDefInt(spinEditP32.EditValue, 0);
                P33 = GetDefInt(spinEditP33.EditValue, 0);
                P34 = GetDefInt(spinEditP34.EditValue, 0);
                P35 = GetDefInt(spinEditP35.EditValue, 0);
                P41 = GetDefInt(spinEditP41.EditValue, 0);
                P42 = GetDefInt(spinEditP42.EditValue, 0);
                P43 = GetDefInt(spinEditP43.EditValue, 0);
                P44 = GetDefInt(spinEditP44.EditValue, 0);
                P45 = GetDefInt(spinEditP45.EditValue, 0);
                P51 = GetDefInt(spinEditP11.EditValue, 0);
                P52 = GetDefInt(spinEditP52.EditValue, 0);
                P53 = GetDefInt(spinEditP53.EditValue, 0);
                P54 = GetDefInt(spinEditP54.EditValue, 0);
                P55 = GetDefInt(spinEditP55.EditValue, 0);

                int Limit1 = GetDefInt(spinEditLimit1.EditValue, 0);
                int Limit2 = GetDefInt(spinEditLimit2.EditValue, 0);
                int Limit3 = GetDefInt(spinEditLimit3.EditValue, 0);
                int Limit4 = GetDefInt(spinEditLimit4.EditValue, 0);
                int Limit5 = GetDefInt(spinEditLimit5.EditValue, 0);

                int S1 = GetDefInt(spinEditOS1.EditValue, 0);
                int S2 = GetDefInt(spinEditOS2.EditValue, 0);
                int S3 = GetDefInt(spinEditOS3.EditValue, 0);
                int S4 = GetDefInt(spinEditOS4.EditValue, 0);
                int S5 = GetDefInt(spinEditOS5.EditValue, 0);

                int Q11 = 0, Q12 = 0, Q13 = 0, Q14 = 0, Q15 = 0;
                int Q21 = 0, Q22 = 0, Q23 = 0, Q24 = 0, Q25 = 0;
                int Q31 = 0, Q32 = 0, Q33 = 0, Q34 = 0, Q35 = 0;
                int Q41 = 0, Q42 = 0, Q43 = 0, Q44 = 0, Q45 = 0;
                int Q51 = 0, Q52 = 0, Q53 = 0, Q54 = 0, Q55 = 0;
                int sumQuantity = 0, sumMoney = 0;
                if (textEditQ11.EditValue != null)
                {
                    Q11 = GetDefInt(textEditQ11.EditValue, 0);
                    Q12 = GetDefInt(textEditQ12.EditValue, 0);
                    Q13 = GetDefInt(textEditQ13.EditValue, 0);
                    Q14 = GetDefInt(textEditQ14.EditValue, 0);
                    Q15 = GetDefInt(textEditQ15.EditValue, 0);
                    Q21 = GetDefInt(textEditQ21.EditValue, 0);
                    Q22 = GetDefInt(textEditQ22.EditValue, 0);
                    Q23 = GetDefInt(textEditQ23.EditValue, 0);
                    Q24 = GetDefInt(textEditQ24.EditValue, 0);
                    Q25 = GetDefInt(textEditQ25.EditValue, 0);
                    Q31 = GetDefInt(textEditQ31.EditValue, 0);
                    Q32 = GetDefInt(textEditQ32.EditValue, 0);
                    Q33 = GetDefInt(textEditQ33.EditValue, 0);
                    Q34 = GetDefInt(textEditQ34.EditValue, 0);
                    Q35 = GetDefInt(textEditQ35.EditValue, 0);
                    Q41 = GetDefInt(textEditQ41.EditValue, 0);
                    Q42 = GetDefInt(textEditQ42.EditValue, 0);
                    Q43 = GetDefInt(textEditQ43.EditValue, 0);
                    Q44 = GetDefInt(textEditQ44.EditValue, 0);
                    Q45 = GetDefInt(textEditQ45.EditValue, 0);
                    Q51 = GetDefInt(textEditQ11.EditValue, 0);
                    Q52 = GetDefInt(textEditQ52.EditValue, 0);
                    Q53 = GetDefInt(textEditQ53.EditValue, 0);
                    Q54 = GetDefInt(textEditQ54.EditValue, 0);
                    Q55 = GetDefInt(textEditQ55.EditValue, 0);
                    sumQuantity = Convert.ToInt32(textEditSumQuantity.EditValue.ToString());
                    sumMoney = Convert.ToInt32(textEditSumMoney.EditValue.ToString());
                }
                string strTime = Convert.ToDateTime(timeEdit.EditValue).ToShortDateString(); 
                string str = "";
                if (OptionType == 1)
                {
                    //新建
                    str += " insert into  PurchaseRecord (Limit1,Limit2,Limit3,Limit4,Limit5,";
                    str += " coalName1,coalName2,coalName3,coalName4,coalName5,E,T,Eta,L,C,Vs,V,V0,MP,M,D,";
                    str += " P11,P12,P13,P14,P15,P21,P22,P23,P24,P25,";
                    str += " P31,P32,P33,P34,P35,P41,P42,P43,P44,P45,P51,P52,P53,P54,P55,";
                    str += " S1,S2,S3,S4,S5,";
                    str += " Q11,Q12,Q13,Q14,Q15,Q21,Q22,Q23,Q24,Q25,";
                    str += " Q31,Q32,Q33,Q34,Q35,Q41,Q42,Q43,Q44,Q45,Q51,Q52,Q53,Q54,Q55 ";
                    str += " ,ForecastTime,SumQuantity,SumMoney,Customer)";
                    str += " values (" + Limit1 + "," + Limit2 + "," + Limit3 + "," + Limit4 + "," + Limit5;
                    str += "," + coalName1 + "," + coalName2 + "," + coalName3 + "," + coalName4 + "," + coalName5;
                    str += "," + E + "," + T + "," + Eta + "," + L + "," + C + "," + Vs + "," + V + "," + V0 + "," + MP + "," + M + "," + D ;
                    str += "," + P11 + "," + Q12 + "," + Q13 + "," + Q14 + "," + Q15;
                    str += "," + P21 + "," + Q22 + "," + Q23 + "," + Q24 + "," + Q25;
                    str += "," + P31 + "," + Q32 + "," + Q33 + "," + Q34 + "," + Q35;
                    str += "," + P41 + "," + Q42 + "," + Q43 + "," + Q44 + "," + Q45;
                    str += "," + P51 + "," + Q52 + "," + Q53 + "," + Q54 + "," + Q55;
                    str += "," + S1 + "," + S2 + "," + S3 + "," + S4 + "," + S5;
                    str += "," + Q11 + "," + Q12 + "," + Q13 + "," + Q14 + "," + Q15;
                    str += "," + Q21 + "," + Q22 + "," + Q23 + "," + Q24 + "," + Q25;
                    str += "," + Q31 + "," + Q32 + "," + Q33 + "," + Q34 + "," + Q35;
                    str += "," + Q41 + "," + Q42 + "," + Q43 + "," + Q44 + "," + Q45;
                    str += "," + Q51 + "," + Q52 + "," + Q53 + "," + Q54 + "," + Q55;
                    str += ",'" + strTime + "'," + sumQuantity + "," + sumMoney + ",'"+Customer+"' )";
                }
                else
                {   //修改
                    str += " update PurchaseRecord set E=" + E + ",T=" + T + ",Eta=" + Eta + ",L=" + L + " ,C=" + C + ",Vs=" + Vs + ",V=" + V + ",V0=" + V0 + ",MP=" + MP + ",M=" + M + ",D=" + D;
                    str += " ,P11=" + P11 + " ,P12=" + P12 + " ,P13=" + P13 + " ,P14=" + P14 + " ,P15=" + P15;
                    str += " ,P21=" + P21 + " ,P22=" + P22 + " ,P23=" + P23 + " ,P24=" + P24 + " ,P25=" + P25;
                    str += " ,P31=" + P31 + " ,P32=" + P32 + " ,P33=" + P33 + " ,P34=" + P34 + " ,P35=" + P35;
                    str += " ,P41=" + P41 + " ,P42=" + P42 + " ,P43=" + P43 + " ,P44=" + P34 + " ,P45=" + P45;
                    str += " ,P51=" + P51 + " ,P52=" + P52 + " ,P53=" + P53 + " ,P54=" + P44 + " ,P55=" + P55;

                    str += " ,S1=" + S1 + " ,S2=" + S2 + " ,S3=" + S3 + " ,S4=" + S4 + " ,S5=" + S5;
                    str += " ,Q11=" + Q11 + " ,Q12=" + Q12 + " ,Q13=" + Q13 + " ,Q14=" + Q14 + " ,Q15=" + Q15;
                    str += " ,Q21=" + Q21 + " ,Q22=" + Q22 + " ,Q23=" + Q23 + " ,Q24=" + Q24 + " ,Q25=" + Q25;
                    str += " ,Q31=" + Q31 + " ,Q32=" + Q32 + " ,Q33=" + Q33 + " ,Q34=" + Q34 + " ,Q35=" + Q35;
                    str += " ,Q41=" + Q41 + " ,Q42=" + Q42 + " ,Q43=" + Q43 + " ,Q44=" + Q44 + " ,Q45=" + Q45;
                    str += " ,Q51=" + Q51 + " ,Q52=" + Q52 + " ,Q53=" + Q53 + " ,Q54=" + Q54 + " ,Q55=" + Q55;

                    str += " ,Limit1=" + Limit1 + " ,Limit2=" + Limit2 + " ,Limit3=" + Limit3 + " ,Limit4=" + Limit4 + " ,Limit5=" + Limit5;
                    str += " ,coalName1=" + coalName1 + " ,coalName2=" + coalName2 + ",coalName3=" + coalName3 + " ,coalName4=" + coalName4 + " ,coalName5=" + coalName5;
                    str += " ,ForecastTime='" + strTime + "',SumQuantity=" + sumQuantity + " ,SumMoney=" + sumMoney + ",Customer='" + Customer+"'";             
                    str += " where ID=" + ID;
                }

                if (!mdbChange(str, "月度采购保存"))
                {
                    return;
                }
                XtraMessageBox.Show("月度采购保存成功！");
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("月度采购保存异常:" + ex.Message);
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
                Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)worksheet1.get_Range("A1:M9", Type.Missing);
                //内外边框
                range.Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                range.Borders.Weight = 3;//设置单元格边框的粗细 
                range.EntireColumn.AutoFit();//自动调整列宽


                //填充数据    
                int n = 1;

                int rowNumber = n, columnNumber = n + 0;
                excel.Cells[rowNumber + 1, columnNumber] = "公司信息";
                excel.Cells[rowNumber + 2, columnNumber] = lookUpEditSN1.Text;
                excel.Cells[rowNumber + 3, columnNumber] = lookUpEditSN2.Text;
                excel.Cells[rowNumber + 4, columnNumber] = lookUpEditSN3.Text;
                excel.Cells[rowNumber + 5, columnNumber] = lookUpEditSN4.Text;
                excel.Cells[rowNumber + 6, columnNumber] = lookUpEditSN5.Text;

                rowNumber = n; columnNumber = n + 1;
                excel.Cells[rowNumber + 1, columnNumber] = "煤种信息";
                excel.Cells[rowNumber + 2, columnNumber] = lookUpEditCN1.Text;
                excel.Cells[rowNumber + 3, columnNumber] = lookUpEditCN2.Text;
                excel.Cells[rowNumber + 4, columnNumber] = lookUpEditCN3.Text;
                excel.Cells[rowNumber + 5, columnNumber] = lookUpEditCN4.Text;
                excel.Cells[rowNumber + 6, columnNumber] = lookUpEditCN5.Text;

                rowNumber = n; columnNumber = n + 2;
                excel.Cells[rowNumber    , columnNumber]   = "渤海湾煤炭价格，5000大卡,含税,元";               
                excel.Cells[rowNumber + 1, columnNumber]   = "第一周";
                excel.Cells[rowNumber + 1, columnNumber+1] = "第二周";
                excel.Cells[rowNumber + 1, columnNumber+2] = "第三周";
                excel.Cells[rowNumber + 1, columnNumber+3] = "第四周";
                excel.Cells[rowNumber + 1, columnNumber+4] = "第五周";

                excel.Cells[rowNumber + 2, columnNumber] = spinEditP11.Text;
                excel.Cells[rowNumber + 2, columnNumber + 1] = spinEditP12.Text;
                excel.Cells[rowNumber + 2, columnNumber + 2] = spinEditP13.Text;
                excel.Cells[rowNumber + 2, columnNumber + 3] = spinEditP14.Text;
                excel.Cells[rowNumber + 2, columnNumber + 4] = spinEditP15.Text;

                excel.Cells[rowNumber + 3, columnNumber] = spinEditP21.Text;
                excel.Cells[rowNumber + 3, columnNumber + 1] = spinEditP22.Text;
                excel.Cells[rowNumber + 3, columnNumber + 2] = spinEditP23.Text;
                excel.Cells[rowNumber + 3, columnNumber + 3] = spinEditP24.Text;
                excel.Cells[rowNumber + 3, columnNumber + 4] = spinEditP25.Text;

                excel.Cells[rowNumber + 4, columnNumber] = spinEditP31.Text;
                excel.Cells[rowNumber + 4, columnNumber + 1] = spinEditP32.Text;
                excel.Cells[rowNumber + 4, columnNumber + 2] = spinEditP33.Text;
                excel.Cells[rowNumber + 4, columnNumber + 3] = spinEditP34.Text;
                excel.Cells[rowNumber + 4, columnNumber + 4] = spinEditP35.Text;

                excel.Cells[rowNumber + 5, columnNumber] = spinEditP41.Text;
                excel.Cells[rowNumber + 5, columnNumber + 1] = spinEditP42.Text;
                excel.Cells[rowNumber + 5, columnNumber + 2] = spinEditP43.Text;
                excel.Cells[rowNumber + 5, columnNumber + 3] = spinEditP44.Text;
                excel.Cells[rowNumber + 5, columnNumber + 4] = spinEditP45.Text;

                excel.Cells[rowNumber + 6, columnNumber] = spinEditP51.Text;
                excel.Cells[rowNumber + 6, columnNumber + 1] = spinEditP52.Text;
                excel.Cells[rowNumber + 6, columnNumber + 2] = spinEditP53.Text;
                excel.Cells[rowNumber + 6, columnNumber + 3] = spinEditP54.Text;
                excel.Cells[rowNumber + 6, columnNumber + 4] = spinEditP55.Text;

                excel.Cells[rowNumber, columnNumber + 5] = "五周采购煤量,吨";
                excel.Cells[rowNumber + 1, columnNumber + 5] = "第一周";
                excel.Cells[rowNumber + 1, columnNumber + 6] = "第二周";
                excel.Cells[rowNumber + 1, columnNumber + 7] = "第三周";
                excel.Cells[rowNumber + 1, columnNumber + 8] = "第四周";
                excel.Cells[rowNumber + 1, columnNumber + 9] = "第五周";

                excel.Cells[rowNumber + 2, columnNumber + 5] = textEditQ11.Text;
                excel.Cells[rowNumber + 3, columnNumber + 5] = textEditQ12.Text;
                excel.Cells[rowNumber + 4, columnNumber + 5] = textEditQ13.Text;
                excel.Cells[rowNumber + 5, columnNumber + 5] = textEditQ14.Text;
                excel.Cells[rowNumber + 6, columnNumber + 5] = textEditQ15.Text;

                excel.Cells[rowNumber + 2, columnNumber + 6] = textEditQ21.Text;
                excel.Cells[rowNumber + 3, columnNumber + 6] = textEditQ22.Text;
                excel.Cells[rowNumber + 4, columnNumber + 6] = textEditQ23.Text;
                excel.Cells[rowNumber + 5, columnNumber + 6] = textEditQ24.Text;
                excel.Cells[rowNumber + 6, columnNumber + 6] = textEditQ25.Text;

                excel.Cells[rowNumber + 2, columnNumber + 7] = textEditQ31.Text;
                excel.Cells[rowNumber + 3, columnNumber + 7] = textEditQ32.Text;
                excel.Cells[rowNumber + 4, columnNumber + 7] = textEditQ33.Text;
                excel.Cells[rowNumber + 5, columnNumber + 7] = textEditQ34.Text;
                excel.Cells[rowNumber + 6, columnNumber + 7] = textEditQ35.Text;

                excel.Cells[rowNumber + 2, columnNumber + 8] = textEditQ41.Text;
                excel.Cells[rowNumber + 3, columnNumber + 8] = textEditQ42.Text;
                excel.Cells[rowNumber + 4, columnNumber + 8] = textEditQ43.Text;
                excel.Cells[rowNumber + 5, columnNumber + 8] = textEditQ44.Text;
                excel.Cells[rowNumber + 6, columnNumber + 8] = textEditQ45.Text;

                excel.Cells[rowNumber + 2, columnNumber + 9] = textEditQ51.Text;
                excel.Cells[rowNumber + 3, columnNumber + 9] = textEditQ52.Text;
                excel.Cells[rowNumber + 4, columnNumber + 9] = textEditQ53.Text;
                excel.Cells[rowNumber + 5, columnNumber + 9] = textEditQ54.Text;
                excel.Cells[rowNumber + 6, columnNumber + 9] = textEditQ55.Text;            
               
                rowNumber = n; columnNumber = n + 12;
                excel.Cells[rowNumber, columnNumber] = "煤量限制(吨)";
                excel.Cells[rowNumber + 2, columnNumber] = spinEditLimit1.Text;
                excel.Cells[rowNumber + 3, columnNumber] = spinEditLimit2.Text;
                excel.Cells[rowNumber + 4, columnNumber] = spinEditLimit3.Text;
                excel.Cells[rowNumber + 5, columnNumber] = spinEditLimit4.Text;
                excel.Cells[rowNumber + 6, columnNumber] = spinEditLimit5.Text;

                rowNumber = n ; columnNumber = n + 12;
                excel.Cells[rowNumber + 7, columnNumber-2] =   "月度煤量总计(吨)";
                excel.Cells[rowNumber + 8, columnNumber-2] =  "月度资金总计(万元)";

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
                dt.Columns.Add("CompanyName1");
                dt.Columns.Add("CompanyName2");
                dt.Columns.Add("CompanyName3");
                dt.Columns.Add("CompanyName4");
                dt.Columns.Add("CompanyName5");
                dt.Columns.Add("coalName1");
                dt.Columns.Add("coalName2");
                dt.Columns.Add("coalName3");
                dt.Columns.Add("coalName4");
                dt.Columns.Add("coalName5");
                dt.Columns.Add("P11");
                dt.Columns.Add("P12");
                dt.Columns.Add("P13");
                dt.Columns.Add("P14");
                dt.Columns.Add("P15");
                dt.Columns.Add("P21");
                dt.Columns.Add("P22");
                dt.Columns.Add("P23");
                dt.Columns.Add("P24");
                dt.Columns.Add("P25");
                dt.Columns.Add("P31");
                dt.Columns.Add("P32");
                dt.Columns.Add("P33");
                dt.Columns.Add("P34");
                dt.Columns.Add("P35");
                dt.Columns.Add("P41");
                dt.Columns.Add("P42");
                dt.Columns.Add("P43");
                dt.Columns.Add("P44");
                dt.Columns.Add("P45");
                dt.Columns.Add("P51");
                dt.Columns.Add("P52");
                dt.Columns.Add("P53");
                dt.Columns.Add("P54");
                dt.Columns.Add("P55");
                dt.Columns.Add("S1");
                dt.Columns.Add("S2");
                dt.Columns.Add("S3");
                dt.Columns.Add("S4");
                dt.Columns.Add("S5");
                dt.Columns.Add("Limit1");
                dt.Columns.Add("Limit2");
                dt.Columns.Add("Limit3");
                dt.Columns.Add("Limit4");
                dt.Columns.Add("Limit5");
                dt.Columns.Add("Q11");
                dt.Columns.Add("Q12");
                dt.Columns.Add("Q13");
                dt.Columns.Add("Q14");
                dt.Columns.Add("Q15");
                dt.Columns.Add("Q21");
                dt.Columns.Add("Q22");
                dt.Columns.Add("Q23");
                dt.Columns.Add("Q24");
                dt.Columns.Add("Q25");
                dt.Columns.Add("Q31");
                dt.Columns.Add("Q32");
                dt.Columns.Add("Q33");
                dt.Columns.Add("Q34");
                dt.Columns.Add("Q35");
                dt.Columns.Add("Q41");
                dt.Columns.Add("Q42");
                dt.Columns.Add("Q43");
                dt.Columns.Add("Q44");
                dt.Columns.Add("Q45");
                dt.Columns.Add("Q51");
                dt.Columns.Add("Q52");
                dt.Columns.Add("Q53");
                dt.Columns.Add("Q54");
                dt.Columns.Add("Q55");

                dt.Columns.Add("SumQuantity");
                dt.Columns.Add("SumMoney");

                DataRow dr = dt.NewRow();
                dr["Customer"] = Customer;
                dr["ForecastTime"] = Convert.ToDateTime(timeEdit.EditValue).ToShortDateString();
                dr["CompanyName1"] = lookUpEditSN1.Text;
                dr["CompanyName2"] = lookUpEditSN2.Text;
                dr["CompanyName3"] = lookUpEditSN3.Text;
                dr["CompanyName4"] = lookUpEditSN4.Text;
                dr["CompanyName5"] = lookUpEditSN5.Text;
                dr["coalName1"] = lookUpEditCN1.Text;
                dr["coalName2"] = lookUpEditCN2.Text;
                dr["coalName3"] = lookUpEditCN3.Text;
                dr["coalName4"] = lookUpEditCN4.Text;
                dr["coalName5"] = lookUpEditCN5.Text;

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

                dr["P11"] = spinEditP11.Text;
                dr["P12"] = spinEditP12.Text;
                dr["P13"] = spinEditP13.Text;
                dr["P14"] = spinEditP14.Text;
                dr["P15"] = spinEditP15.Text;
                dr["P21"] = spinEditP21.Text;
                dr["P22"] = spinEditP22.Text;
                dr["P23"] = spinEditP23.Text;
                dr["P24"] = spinEditP24.Text;
                dr["P25"] = spinEditP25.Text;
                dr["P31"] = spinEditP31.Text;
                dr["P32"] = spinEditP32.Text;
                dr["P33"] = spinEditP33.Text;
                dr["P34"] = spinEditP34.Text;
                dr["P35"] = spinEditP35.Text;
                dr["P41"] = spinEditP41.Text;
                dr["P42"] = spinEditP42.Text;
                dr["P43"] = spinEditP43.Text;
                dr["P44"] = spinEditP44.Text;
                dr["P45"] = spinEditP45.Text;
                dr["P51"] = spinEditP51.Text;
                dr["P52"] = spinEditP52.Text;
                dr["P53"] = spinEditP53.Text;
                dr["P54"] = spinEditP54.Text;
                dr["P55"] = spinEditP55.Text;

                dr["Q11"] = textEditQ11.Text;
                dr["Q12"] = textEditQ12.Text;
                dr["Q13"] = textEditQ13.Text;
                dr["Q14"] = textEditQ14.Text;
                dr["Q15"] = textEditQ15.Text;
                dr["Q21"] = textEditQ21.Text;
                dr["Q22"] = textEditQ22.Text;
                dr["Q23"] = textEditQ23.Text;
                dr["Q24"] = textEditQ24.Text;
                dr["Q25"] = textEditQ25.Text;
                dr["Q31"] = textEditQ31.Text;
                dr["Q32"] = textEditQ32.Text;
                dr["Q33"] = textEditQ33.Text;
                dr["Q34"] = textEditQ34.Text;
                dr["Q35"] = textEditQ35.Text;
                dr["Q41"] = textEditQ41.Text;
                dr["Q42"] = textEditQ42.Text;
                dr["Q43"] = textEditQ43.Text;
                dr["Q44"] = textEditQ44.Text;
                dr["Q45"] = textEditQ45.Text;
                dr["Q51"] = textEditQ51.Text;
                dr["Q52"] = textEditQ52.Text;
                dr["Q53"] = textEditQ53.Text;
                dr["Q54"] = textEditQ54.Text;
                dr["Q55"] = textEditQ55.Text;

                dr["S1"] = spinEditOS1.Text;
                dr["S2"] = spinEditOS2.Text;
                dr["S3"] = spinEditOS3.Text;
                dr["S4"] = spinEditOS4.Text;
                dr["S5"] = spinEditOS5.Text;

                dr["Limit1"] = spinEditLimit1.Text;
                dr["Limit2"] = spinEditLimit2.Text;
                dr["Limit3"] = spinEditLimit3.Text;
                dr["Limit4"] = spinEditLimit4.Text;
                dr["Limit5"] = spinEditLimit5.Text;
                dr["SumQuantity"] = textEditSumQuantity.Text;
                dr["SumMoney"] = textEditSumMoney.Text;
                dt.Rows.Add(dr);

                XtraReport_Purchase rpt = new XtraReport_Purchase();
                rpt.DataSource = dt;
                rpt.ShowPreview();
            }
            catch (System.Exception ex)
            {
                XtraMessageBox.Show("月度采购打印异常：" + ex.Message);
            }
        }

        private void barButtonItemExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}