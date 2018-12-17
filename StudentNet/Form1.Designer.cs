namespace StudentNet
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("一班");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("二班");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("一年级", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38});
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("一班");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("二班");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("二年级", new System.Windows.Forms.TreeNode[] {
            treeNode40,
            treeNode41});
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("一班");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("二班");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("三年级", new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode44});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.一年级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一班ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.二班ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.二年级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一班ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.二班ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.三年级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一班ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.二班ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stuNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportServerDataSet = new StudentNet.ReportServerDataSet();
            this.studentTableAdapter = new StudentNet.ReportServerDataSetTableAdapters.StudentTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportServerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.treeView1.Location = new System.Drawing.Point(0, 33);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeView1.Name = "treeView1";
            treeNode37.Name = "ffirst";
            treeNode37.Text = "一班";
            treeNode38.Name = "fsecond";
            treeNode38.Text = "二班";
            treeNode39.Name = "first";
            treeNode39.Text = "一年级";
            treeNode40.Name = "sfirst";
            treeNode40.Text = "一班";
            treeNode41.Name = "ssecond";
            treeNode41.Text = "二班";
            treeNode42.Name = "second";
            treeNode42.Text = "二年级";
            treeNode43.Name = "tfirst";
            treeNode43.Text = "一班";
            treeNode44.Name = "tsecond";
            treeNode44.Text = "二班";
            treeNode45.Name = "third";
            treeNode45.Text = "三年级";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode39,
            treeNode42,
            treeNode45});
            this.treeView1.Size = new System.Drawing.Size(185, 439);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.一年级ToolStripMenuItem,
            this.二年级ToolStripMenuItem,
            this.三年级ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(942, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 一年级ToolStripMenuItem
            // 
            this.一年级ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.一班ToolStripMenuItem,
            this.二班ToolStripMenuItem});
            this.一年级ToolStripMenuItem.Name = "一年级ToolStripMenuItem";
            this.一年级ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.一年级ToolStripMenuItem.Text = "一年级";
            // 
            // 一班ToolStripMenuItem
            // 
            this.一班ToolStripMenuItem.Name = "一班ToolStripMenuItem";
            this.一班ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.一班ToolStripMenuItem.Text = "一班";
            // 
            // 二班ToolStripMenuItem
            // 
            this.二班ToolStripMenuItem.Name = "二班ToolStripMenuItem";
            this.二班ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.二班ToolStripMenuItem.Text = "二班";
            // 
            // 二年级ToolStripMenuItem
            // 
            this.二年级ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.一班ToolStripMenuItem1,
            this.二班ToolStripMenuItem1});
            this.二年级ToolStripMenuItem.Name = "二年级ToolStripMenuItem";
            this.二年级ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.二年级ToolStripMenuItem.Text = "二年级";
            // 
            // 一班ToolStripMenuItem1
            // 
            this.一班ToolStripMenuItem1.Name = "一班ToolStripMenuItem1";
            this.一班ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.一班ToolStripMenuItem1.Text = "一班";
            // 
            // 二班ToolStripMenuItem1
            // 
            this.二班ToolStripMenuItem1.Name = "二班ToolStripMenuItem1";
            this.二班ToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.二班ToolStripMenuItem1.Text = "二班";
            // 
            // 三年级ToolStripMenuItem
            // 
            this.三年级ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.一班ToolStripMenuItem3,
            this.二班ToolStripMenuItem3});
            this.三年级ToolStripMenuItem.Name = "三年级ToolStripMenuItem";
            this.三年级ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.三年级ToolStripMenuItem.Text = "三年级";
            // 
            // 一班ToolStripMenuItem3
            // 
            this.一班ToolStripMenuItem3.Name = "一班ToolStripMenuItem3";
            this.一班ToolStripMenuItem3.Size = new System.Drawing.Size(100, 22);
            this.一班ToolStripMenuItem3.Text = "一班";
            // 
            // 二班ToolStripMenuItem3
            // 
            this.二班ToolStripMenuItem3.Name = "二班ToolStripMenuItem3";
            this.二班ToolStripMenuItem3.Size = new System.Drawing.Size(100, 22);
            this.二班ToolStripMenuItem3.Text = "二班";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "天津科技大学计算机学院：";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(843, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "新增";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(843, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(843, 303);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "修改";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(195, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(645, 341);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // stuNoDataGridViewTextBoxColumn
            // 
            this.stuNoDataGridViewTextBoxColumn.DataPropertyName = "StuNo";
            this.stuNoDataGridViewTextBoxColumn.HeaderText = "StuNo";
            this.stuNoDataGridViewTextBoxColumn.Name = "stuNoDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.reportServerDataSet;
            // 
            // reportServerDataSet
            // 
            this.reportServerDataSet.DataSetName = "ReportServerDataSet";
            this.reportServerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 400);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(301, 400);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(407, 400);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(513, 400);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 10;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(619, 400);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(725, 400);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 23);
            this.textBox6.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(942, 472);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "计算机学院学生信息管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportServerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 一年级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一班ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 二班ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 二年级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一班ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 二班ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 三年级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一班ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 二班ToolStripMenuItem3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ReportServerDataSet reportServerDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private ReportServerDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}

