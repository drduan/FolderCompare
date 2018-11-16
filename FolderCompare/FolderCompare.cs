using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace FolderCompare
{
    public partial class FolderCompare : Form
    {
        private const string pathTip = "拖动文件夹到此或者输入文件夹路径";
        private IList<FileItem> lista = new List<FileItem>(10);
        private IList<FileItem> listb = new List<FileItem>(10);
        private IList<FileItem> listc = new List<FileItem>(10);
        public FolderCompare()
        {
            InitializeComponent();
            comboBox1.Sorted = true;
            comboBox2.Sorted = true;
        }

        public void deleteFileOrFolder(string path)
        {
            try
            {
                //FileSystem.DeleteDirectory(path, FileIO.UIOption.OnlyErrorDialogs, .RecycleOption.SendToRecycleBin);
                //File.Delete(path);


            Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(path,
            Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
            Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void initList(string directory, ref IList<FileItem> list)
        {
            if (string.IsNullOrEmpty(directory)) return;
            var files = Directory.GetFiles(directory);
            list.Clear();
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo fi = new FileInfo(files[i]);
                string ext = fi.Extension;
                FileItem item = new FileItem();
                //item.name =  fi.Name /*;*/
                item.name = string.IsNullOrEmpty(fi.Extension) ? fi.Name : fi.Name.Replace(ext, "");
                item.size = fi.Length;
                item.ext = fi.Extension;
                item.fullpath = fi.FullName;
                item.crttime = fi.LastWriteTime;
                list.Add(item);
            }
        }

        public void resetColor()
        {
            for (int i = 0; i < grid1.Rows; i++)
            {
                grid1.Cell(i, 1).ForeColor = Color.Black;
            }
            for (int i = 0; i < grid2.Rows; i++)
            {
                grid2.Cell(i, 1).ForeColor = Color.Black;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            grid1.Locked = false;
            grid2.Locked = false;

            for (int i = 1; i < grid1.Rows; i++)
            {
                if (!listb.Select(o => o.name).ToList().Contains(grid1.Cell(i, 1).Text))
                {
                    grid1.Cell(i, 1).ForeColor = Color.Red;
                }
                else
                {
                    grid1.Cell(i, 1).ForeColor = Color.Black;
                }
            }

            for (int i = 1; i < grid2.Rows; i++)
            {
                if (!lista.Select(o => o.name).ToList().Contains(grid2.Cell(i, 1).Text))

                {
                    grid2.Cell(i, 1).ForeColor = Color.Red;
                }
                else
                {
                    grid2.Cell(i, 1).ForeColor = Color.Black;
                }
            }

            grid1.Refresh();
            grid2.Refresh();
            grid1.Locked = true;
            grid2.Locked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(comboBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(comboBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            if (string.IsNullOrEmpty(dialog.SelectedPath)) return;

            comboBox1.Items.Add(dialog.SelectedPath);
            comboBox1.SelectedItem = dialog.SelectedPath;

            grid1.Locked = false;
            initList(comboBox1.Text, ref lista);
            grid1.Rows = lista.Count + 1;
            label1.Text = "" + lista.Count + "个文件";

            for (int i = 0; i < lista.Count; i++)
            {
                grid1.Cell(i + 1, 1).Text = lista[i].name;
                grid1.Cell(i + 1, 2).Text = lista[i].ext;
                grid1.Cell(i + 1, 3).Text = lista[i].size / 1000.0f + "KB";
                grid1.Cell(i + 1, 4).Text = lista[i].crttime.ToLongDateString();
            }
            grid1.Column(1).AutoFit();
            grid1.Column(2).AutoFit();
            grid1.Column(3).AutoFit();
            grid1.Column(4).AutoFit();

            grid1.Refresh();
            grid1.ExtendLastCol = true;
            grid1.Locked = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            if (string.IsNullOrEmpty(dialog.SelectedPath)) return;
            comboBox2.Items.Add(dialog.SelectedPath);
            comboBox2.SelectedItem = dialog.SelectedPath;

            initList(comboBox2.Text, ref listb);
            label2.Text = "" + listb.Count + "个文件";
            grid2.Locked = false;

            grid2.Rows = listb.Count + 1;
            for (int i = 0; i < listb.Count; i++)
            {
                grid2.Cell(i + 1, 1).Text = listb[i].name;
                grid2.Cell(i + 1, 2).Text = listb[i].ext;
                grid2.Cell(i + 1, 3).Text = listb[i].size / 1000.0f + "KB";
                grid2.Cell(i + 1, 4).Text = listb[i].crttime.ToLongDateString();
            }
            grid2.ExtendLastCol = true;
            grid2.Column(1).AutoFit();
            grid2.Column(2).AutoFit();
            grid2.Column(3).AutoFit();
            grid2.Column(4).AutoFit();

            grid2.Refresh();
            grid2.Locked = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lista.Clear();

            grid1.Rows = 1;
            grid1.Locked = false;
            initList(comboBox1.Text, ref lista);

            grid1.Rows = lista.Count + 1;
            label1.Text = "" + lista.Count + "个文件";

            for (int i = 0; i < lista.Count; i++)
            {
                grid1.Cell(i + 1, 1).Text = lista[i].name;
                grid1.Cell(i + 1, 2).Text = lista[i].ext;
                grid1.Cell(i + 1, 3).Text = lista[i].size / 1000.0f + "KB"; ;
                grid1.Cell(i + 1, 4).Text = lista[i].crttime.ToLongDateString();
            }
            grid1.ExtendLastCol = true;
            grid1.Column(1).AutoFit();
            grid1.Column(2).AutoFit();
            grid1.Column(3).AutoFit();
            grid1.Column(4).AutoFit();

            grid1.Refresh();
            resetColor();
            grid1.Locked = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            grid2.Rows = 1;

            grid2.Locked = false;
            initList(comboBox2.Text, ref listb);
            grid2.Rows = listb.Count + 1;
            label2.Text = "" + listb.Count + "个文件";

            for (int i = 0; i < listb.Count; i++)
            {
                grid2.Cell(i + 1, 1).Text = listb[i].name;
                grid2.Cell(i + 1, 2).Text = listb[i].ext;
                grid2.Cell(i + 1, 3).Text = listb[i].size / 1000.0f + "KB";
                grid2.Cell(i + 1, 4).Text = listb[i].crttime.ToLongDateString();
            }
            grid2.ExtendLastCol = true;
            grid2.Column(1).AutoFit();
            grid2.Column(2).AutoFit();
            grid2.Column(3).AutoFit();
            grid2.Column(4).AutoFit();

            grid2.Refresh();
            resetColor();
            grid2.Locked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grid1.Cols = 5;
            grid1.Rows = 1;

            grid2.Cols = 5;
            grid2.Rows = 1;

            grid1.Locked = false;
            grid1.ExtendLastCol = true;

            grid1.Cell(0, 1).Text = "名称";
            grid1.Cell(0, 2).Text = "扩展名";
            grid1.Cell(0, 3).Text = "大小";
            grid1.Cell(0, 4).Text = "上次修改时间";

            grid1.Column(0).Visible = false;
            grid1.Column(1).Alignment = FlexCell.AlignmentEnum.LeftCenter;
            grid1.Column(2).AutoFit();
            grid1.Column(3).AutoFit();
            grid1.Column(4).AutoFit();

            grid1.AutoRedraw = false;
            grid1.Refresh();
            grid1.AutoRedraw = true;
            grid1.Locked = true;
            label1.Text = "0个文件";

            grid2.Column(0).Visible = false;
            grid2.Cell(0, 1).Text = "名称";
            grid2.Cell(0, 2).Text = "扩展名";
            grid2.Cell(0, 3).Text = "大小";
            grid2.Cell(0, 4).Text = "上次修改时间";

            grid2.Column(1).Alignment = FlexCell.AlignmentEnum.LeftCenter;
            grid2.Column(2).AutoFit();
            grid2.Column(3).AutoFit();
            grid2.Column(4).AutoFit();

            grid2.AutoRedraw = false;
            grid2.Refresh();

            grid2.AutoRedraw = true;
            grid2.Locked = true;

            label2.Text = "0个文件";
        }
        /// <summary>
        /// 删除1中不同文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除1相同文件ToolStripMenuItem_Click(object sender, EventArgs e)

        {
            IList<string> listd;
            listd = lista.Select(o => o.name).ToList().Except(listb.Select(o => o.name)).ToList();

            DialogResult result = MessageBox.Show("确定要删除" + comboBox1.Text + "中" + listd.Count + "个文件吗？", "删除提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (FileItem item in lista)
                {
                    if (listd.Contains(item.name))
                    {
                        if (File.Exists(item.fullpath))
                        {
                            deleteFileOrFolder(item.fullpath);
                        }
                    }
                }
                refreshData(null, null);
            }
        }

        private void 删除1相同文件ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IList<string> listd;
            listd = lista.Select(o => o.name).ToList().Intersect(listb.Select(o => o.name)).ToList();

            DialogResult result = MessageBox.Show("确定要删除" + comboBox1.Text + "中" + listd.Count + "个文件吗？", "删除提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (FileItem item in lista)
                {
                    if (listd.Contains(item.name))
                    {
                        if (File.Exists(item.fullpath))
                        {
                            deleteFileOrFolder(item.fullpath);
                        }
                    }
                }
                refreshData(null, null);
            }
        }

        /// <summary>
        /// 删除2中不同文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除2相同文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IList<string> listd;
            listd = listb.Select(o => o.name).ToList().Except(lista.Select(o => o.name)).ToList();

            DialogResult result = MessageBox.Show("确定要删除" + comboBox2.Text + "中" + listd.Count + "个文件吗？", "删除提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (FileItem item in listb)
                {
                    if (listd.Contains(item.name))
                    {
                        if (File.Exists(item.fullpath))
                        {
                            deleteFileOrFolder(item.fullpath);
                        }
                    }
                }
                refreshData(null, null);
            }

        }
        private void 删除2相同文件ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int i = 1;
            IList<string> listd;
            listd = listb.Select(o => o.name).ToList().Intersect(lista.Select(o => o.name)).ToList();

            DialogResult result = MessageBox.Show("确定要删除" + comboBox2.Text + "中" + listd.Count + "个文件吗？", "删除提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (FileItem item in listb)
                {
                    if (listd.Contains(item.name))
                    {
                        if (File.Exists(item.fullpath))
                        {
                            deleteFileOrFolder(item.fullpath);
                            i++;
                        }
                    }
                }
               
                refreshData(null,null);
            }
            //MessageBox.Show("已删除文件夹1中"+i+"个文件");
        }

        private void refreshData(object sender, EventArgs e)
        {
            grid1.Rows = 1;
            grid2.Rows = 1;

            initList(comboBox2.Text, ref listb);
            label2.Text = "" + listb.Count + "个文件";
            grid2.Locked = false;

            grid2.Rows = listb.Count + 1;
            for (int i = 0; i < listb.Count; i++)
            {
                grid2.Cell(i + 1, 1).Text = listb[i].name;
                grid2.Cell(i + 1, 2).Text = listb[i].ext;
                grid2.Cell(i + 1, 3).Text = listb[i].size / 1000.0f + "KB";
                grid2.Cell(i + 1, 4).Text = listb[i].crttime.ToLongDateString();
            }
            grid2.ExtendLastCol = true;
            grid2.Column(1).AutoFit();
            grid2.Column(2).AutoFit();
            grid2.Column(3).AutoFit();
            grid2.Column(4).AutoFit();

            grid2.Refresh();
            grid2.Locked = true;


            initList(comboBox1.Text, ref lista);
            grid1.Rows = lista.Count + 1;
            label1.Text = "" + lista.Count + "个文件";

            for (int i = 0; i < lista.Count; i++)
            {
                grid1.Cell(i + 1, 1).Text = lista[i].name;
                grid1.Cell(i + 1, 2).Text = lista[i].ext;
                grid1.Cell(i + 1, 3).Text = lista[i].size / 1000.0f + "KB";
                grid1.Cell(i + 1, 4).Text = lista[i].crttime.ToLongDateString();
            }
            grid1.Column(1).AutoFit();
            grid1.Column(2).AutoFit();
            grid1.Column(3).AutoFit();
            grid1.Column(4).AutoFit();

            grid1.Refresh();
            grid1.ExtendLastCol = true;
            grid1.Locked = true;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
    }
}