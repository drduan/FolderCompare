namespace FolderCompare
{
    partial class FolderCompare
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderCompare));
            this.grid1 = new FlexCell.Grid();
            this.button3 = new System.Windows.Forms.Button();
            this.grid2 = new FlexCell.Grid();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.文件删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除1相同文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除2相同文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.比较ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除1相同文件ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.删除2相同文件ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid1
            // 
            this.grid1.AllowUserPaste = FlexCell.ClipboardDataEnum.Text;
            this.grid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid1.BackColor1 = System.Drawing.SystemColors.ControlLightLight;
            this.grid1.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            this.grid1.BackColorActiveCellSel = System.Drawing.SystemColors.ControlLightLight;
            this.grid1.BackColorBkg = System.Drawing.SystemColors.ControlLightLight;
            this.grid1.BorderColor = System.Drawing.Color.Silver;
            this.grid1.BorderStyle = FlexCell.BorderStyleEnum.None;
            this.grid1.CellBorderColor = System.Drawing.Color.Silver;
            this.grid1.CheckedImage = null;
            this.grid1.DefaultFont = new System.Drawing.Font("宋体", 9F);
            this.grid1.ExtendLastCol = true;
            this.grid1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grid1.Location = new System.Drawing.Point(4, 71);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(550, 483);
            this.grid1.TabIndex = 2;
            this.grid1.UncheckedImage = null;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(541, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(16, 16);
            this.button3.TabIndex = 4;
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // grid2
            // 
            this.grid2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid2.BackColor1 = System.Drawing.SystemColors.ControlLightLight;
            this.grid2.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            this.grid2.BackColorActiveCellSel = System.Drawing.SystemColors.ControlLightLight;
            this.grid2.BackColorBkg = System.Drawing.SystemColors.ControlLightLight;
            this.grid2.BorderColor = System.Drawing.Color.Silver;
            this.grid2.BorderStyle = FlexCell.BorderStyleEnum.None;
            this.grid2.CellBorderColor = System.Drawing.Color.Silver;
            this.grid2.CheckedImage = null;
            this.grid2.DefaultFont = new System.Drawing.Font("宋体", 9F);
            this.grid2.ExtendLastCol = true;
            this.grid2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.grid2.Location = new System.Drawing.Point(590, 71);
            this.grid2.Name = "grid2";
            this.grid2.Size = new System.Drawing.Size(536, 483);
            this.grid2.TabIndex = 8;
            this.grid2.UncheckedImage = null;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(528, 20);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(15, 15);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(511, 20);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(532, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(16, 16);
            this.button4.TabIndex = 11;
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件删除ToolStripMenuItem,
            this.比较ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1134, 25);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 560);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1130, 19);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // 文件删除ToolStripMenuItem
            // 
            this.文件删除ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除1相同文件ToolStripMenuItem,
            this.删除2相同文件ToolStripMenuItem,
            this.删除1相同文件ToolStripMenuItem1,
            this.删除2相同文件ToolStripMenuItem1});
            this.文件删除ToolStripMenuItem.Name = "文件删除ToolStripMenuItem";
            this.文件删除ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.文件删除ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.文件删除ToolStripMenuItem.Text = "文件删除";
            // 
            // 删除1相同文件ToolStripMenuItem
            // 
            this.删除1相同文件ToolStripMenuItem.Name = "删除1相同文件ToolStripMenuItem";
            this.删除1相同文件ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.删除1相同文件ToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.删除1相同文件ToolStripMenuItem.Text = "删除1不同文件";
            this.删除1相同文件ToolStripMenuItem.Click += new System.EventHandler(this.删除1相同文件ToolStripMenuItem_Click);
            // 
            // 删除2相同文件ToolStripMenuItem
            // 
            this.删除2相同文件ToolStripMenuItem.Name = "删除2相同文件ToolStripMenuItem";
            this.删除2相同文件ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.删除2相同文件ToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.删除2相同文件ToolStripMenuItem.Text = "删除2不同文件";
            this.删除2相同文件ToolStripMenuItem.Click += new System.EventHandler(this.删除2相同文件ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(4, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 526);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文件夹1 ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(575, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 526);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件夹2";
            // 
            // 比较ToolStripMenuItem
            // 
            this.比较ToolStripMenuItem.Name = "比较ToolStripMenuItem";
            this.比较ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.比较ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.比较ToolStripMenuItem.Text = "文件比较";
            this.比较ToolStripMenuItem.Click += new System.EventHandler(this.btn1_Click);
            // 
            // 删除1相同文件ToolStripMenuItem1
            // 
            this.删除1相同文件ToolStripMenuItem1.Name = "删除1相同文件ToolStripMenuItem1";
            this.删除1相同文件ToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.删除1相同文件ToolStripMenuItem1.Text = "删除1相同文件";
            this.删除1相同文件ToolStripMenuItem1.Click += new System.EventHandler(this.删除1相同文件ToolStripMenuItem1_Click);
            // 
            // 删除2相同文件ToolStripMenuItem1
            // 
            this.删除2相同文件ToolStripMenuItem1.Name = "删除2相同文件ToolStripMenuItem1";
            this.删除2相同文件ToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.删除2相同文件ToolStripMenuItem1.Text = "删除2相同文件";
            this.删除2相同文件ToolStripMenuItem1.Click += new System.EventHandler(this.删除2相同文件ToolStripMenuItem1_Click);
            // 
            // FolderCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1134, 582);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.grid2);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FolderCompare";
            this.Text = "文件比较系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FlexCell.Grid grid1;
        private System.Windows.Forms.Button button3;
        private FlexCell.Grid grid2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem 文件删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除1相同文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除2相同文件ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem 比较ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除1相同文件ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 删除2相同文件ToolStripMenuItem1;
    }
}

