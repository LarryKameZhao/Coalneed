using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace MyControl
{
    public class GridStyle
    {
        public GridStyle()
        {
        }

        public string FilePath = "";

        public void LoadStyle(DevExpress.XtraGrid.Views.Grid.GridView gridView, bool showMsg)
        {
            string msg = "";
            if (File.Exists(FilePath))
            {
                gridView.RestoreLayoutFromXml(FilePath);
                msg = "导入样式成功！";
            }
            else msg = "样式文件不存在！";

            if (showMsg) MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void SaveStyle(DevExpress.XtraGrid.Views.Grid.GridView gridView, bool showMsg)
        {
            gridView.SaveLayoutToXml(FilePath);

            if (showMsg) MessageBox.Show("保存样式成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DeleteStyle(DevExpress.XtraGrid.Views.Grid.GridView gridView, bool showMsg)
        {
            string msg = "";
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
                msg = "删除样式文件成功！";
            }
            else msg = "样式文件不存在！";

            if (showMsg) MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
