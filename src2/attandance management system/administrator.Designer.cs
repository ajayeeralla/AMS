namespace attandance_management_system
{
    partial class administrator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Admtab = new System.Windows.Forms.TabControl();
            this.Stdtpg = new System.Windows.Forms.TabPage();
            this.CanSbtn = new System.Windows.Forms.Button();
            this.Usrtylbl = new System.Windows.Forms.Label();
            this.cmbUType = new System.Windows.Forms.ComboBox();
            this.SavSbtn = new System.Windows.Forms.Button();
            this.Stddgv = new System.Windows.Forms.DataGridView();
            this.ClsSlbl = new System.Windows.Forms.Label();
            this.ClsScmb = new System.Windows.Forms.ComboBox();
            this.UnmSlbl = new System.Windows.Forms.Label();
            this.DelSbtn = new System.Windows.Forms.Button();
            this.UnmStxt = new System.Windows.Forms.TextBox();
            this.EdtSbtn = new System.Windows.Forms.Button();
            this.UidStxt = new System.Windows.Forms.TextBox();
            this.UidSlbl = new System.Windows.Forms.Label();
            this.Holidpg = new System.Windows.Forms.TabPage();
            this.DelHbtn = new System.Windows.Forms.Button();
            this.CanHbtn = new System.Windows.Forms.Button();
            this.dtpHoliday = new System.Windows.Forms.DateTimePicker();
            this.Hdesclbl = new System.Windows.Forms.Label();
            this.Hdtlbl = new System.Windows.Forms.Label();
            this.Hdesctxt = new System.Windows.Forms.TextBox();
            this.SavHbtn = new System.Windows.Forms.Button();
            this.dgvHp = new System.Windows.Forms.DataGridView();
            this.Total = new System.Windows.Forms.TabPage();
            this.attstulbl = new System.Windows.Forms.Label();
            this.attcrselbl = new System.Windows.Forms.Label();
            this.totclr = new System.Windows.Forms.Button();
            this.todtpto = new System.Windows.Forms.DateTimePicker();
            this.totdtpst = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.totstsdate = new System.Windows.Forms.Label();
            this.dgvtot = new System.Windows.Forms.DataGridView();
            this.totgetbtn = new System.Windows.Forms.Button();
            this.totcmbstu = new System.Windows.Forms.ComboBox();
            this.totcmbcrse = new System.Windows.Forms.ComboBox();
            this.Admtab.SuspendLayout();
            this.Stdtpg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stddgv)).BeginInit();
            this.Holidpg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHp)).BeginInit();
            this.Total.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtot)).BeginInit();
            this.SuspendLayout();
            // 
            // Admtab
            // 
            this.Admtab.Controls.Add(this.Stdtpg);
            this.Admtab.Controls.Add(this.Holidpg);
            this.Admtab.Controls.Add(this.Total);
            this.Admtab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Admtab.Location = new System.Drawing.Point(0, 0);
            this.Admtab.Name = "Admtab";
            this.Admtab.SelectedIndex = 0;
            this.Admtab.Size = new System.Drawing.Size(541, 338);
            this.Admtab.TabIndex = 9;
            this.Admtab.Tag = "";
            // 
            // Stdtpg
            // 
            this.Stdtpg.Controls.Add(this.CanSbtn);
            this.Stdtpg.Controls.Add(this.Usrtylbl);
            this.Stdtpg.Controls.Add(this.cmbUType);
            this.Stdtpg.Controls.Add(this.SavSbtn);
            this.Stdtpg.Controls.Add(this.Stddgv);
            this.Stdtpg.Controls.Add(this.ClsSlbl);
            this.Stdtpg.Controls.Add(this.ClsScmb);
            this.Stdtpg.Controls.Add(this.UnmSlbl);
            this.Stdtpg.Controls.Add(this.DelSbtn);
            this.Stdtpg.Controls.Add(this.UnmStxt);
            this.Stdtpg.Controls.Add(this.EdtSbtn);
            this.Stdtpg.Controls.Add(this.UidStxt);
            this.Stdtpg.Controls.Add(this.UidSlbl);
            this.Stdtpg.Location = new System.Drawing.Point(4, 22);
            this.Stdtpg.Name = "Stdtpg";
            this.Stdtpg.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Stdtpg.Size = new System.Drawing.Size(533, 312);
            this.Stdtpg.TabIndex = 0;
            this.Stdtpg.Text = "Student";
            this.Stdtpg.UseVisualStyleBackColor = true;
            // 
            // CanSbtn
            // 
            this.CanSbtn.Location = new System.Drawing.Point(348, 286);
            this.CanSbtn.Name = "CanSbtn";
            this.CanSbtn.Size = new System.Drawing.Size(75, 23);
            this.CanSbtn.TabIndex = 54;
            this.CanSbtn.Text = "Cancel";
            this.CanSbtn.UseVisualStyleBackColor = true;
            this.CanSbtn.Click += new System.EventHandler(this.CanSbtn_Click);
            // 
            // Usrtylbl
            // 
            this.Usrtylbl.AutoSize = true;
            this.Usrtylbl.Location = new System.Drawing.Point(244, 370);
            this.Usrtylbl.Name = "Usrtylbl";
            this.Usrtylbl.Size = new System.Drawing.Size(62, 13);
            this.Usrtylbl.TabIndex = 53;
            this.Usrtylbl.Text = "User Type :";
            // 
            // cmbUType
            // 
            this.cmbUType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUType.FormattingEnabled = true;
            this.cmbUType.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cmbUType.Location = new System.Drawing.Point(324, 368);
            this.cmbUType.Name = "cmbUType";
            this.cmbUType.Size = new System.Drawing.Size(100, 21);
            this.cmbUType.TabIndex = 51;
            // 
            // SavSbtn
            // 
            this.SavSbtn.Location = new System.Drawing.Point(256, 286);
            this.SavSbtn.Name = "SavSbtn";
            this.SavSbtn.Size = new System.Drawing.Size(75, 23);
            this.SavSbtn.TabIndex = 49;
            this.SavSbtn.Text = "Save";
            this.SavSbtn.UseVisualStyleBackColor = true;
            this.SavSbtn.Click += new System.EventHandler(this.SavSbtn_Click);
            // 
            // Stddgv
            // 
            this.Stddgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Stddgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Stddgv.Location = new System.Drawing.Point(-3, -1);
            this.Stddgv.MultiSelect = false;
            this.Stddgv.Name = "Stddgv";
            this.Stddgv.ReadOnly = true;
            this.Stddgv.RowHeadersVisible = false;
            this.Stddgv.RowTemplate.Height = 24;
            this.Stddgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Stddgv.Size = new System.Drawing.Size(463, 280);
            this.Stddgv.TabIndex = 48;
            this.Stddgv.SelectionChanged += new System.EventHandler(this.Stddgv_SelectionChanged);
            this.Stddgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Stddgv_CellContentClick);
            // 
            // ClsSlbl
            // 
            this.ClsSlbl.AutoSize = true;
            this.ClsSlbl.Location = new System.Drawing.Point(23, 371);
            this.ClsSlbl.Name = "ClsSlbl";
            this.ClsSlbl.Size = new System.Drawing.Size(38, 13);
            this.ClsSlbl.TabIndex = 46;
            this.ClsSlbl.Text = "Class :";
            // 
            // ClsScmb
            // 
            this.ClsScmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClsScmb.FormattingEnabled = true;
            this.ClsScmb.Items.AddRange(new object[] {
            "M.Tech",
            "Ph.D"});
            this.ClsScmb.Location = new System.Drawing.Point(89, 369);
            this.ClsScmb.Name = "ClsScmb";
            this.ClsScmb.Size = new System.Drawing.Size(100, 21);
            this.ClsScmb.TabIndex = 47;
            this.ClsScmb.SelectedIndexChanged += new System.EventHandler(this.ClsScmb_SelectedIndexChanged);
            // 
            // UnmSlbl
            // 
            this.UnmSlbl.AutoSize = true;
            this.UnmSlbl.Location = new System.Drawing.Point(241, 325);
            this.UnmSlbl.Name = "UnmSlbl";
            this.UnmSlbl.Size = new System.Drawing.Size(66, 13);
            this.UnmSlbl.TabIndex = 45;
            this.UnmSlbl.Text = "User Name :";
            // 
            // DelSbtn
            // 
            this.DelSbtn.Location = new System.Drawing.Point(98, 286);
            this.DelSbtn.Name = "DelSbtn";
            this.DelSbtn.Size = new System.Drawing.Size(75, 23);
            this.DelSbtn.TabIndex = 7;
            this.DelSbtn.Text = "Delete";
            this.DelSbtn.UseVisualStyleBackColor = true;
            this.DelSbtn.Click += new System.EventHandler(this.DelSbtn_Click);
            // 
            // UnmStxt
            // 
            this.UnmStxt.Location = new System.Drawing.Point(324, 323);
            this.UnmStxt.Name = "UnmStxt";
            this.UnmStxt.Size = new System.Drawing.Size(100, 20);
            this.UnmStxt.TabIndex = 43;
            // 
            // EdtSbtn
            // 
            this.EdtSbtn.Location = new System.Drawing.Point(3, 286);
            this.EdtSbtn.Name = "EdtSbtn";
            this.EdtSbtn.Size = new System.Drawing.Size(75, 23);
            this.EdtSbtn.TabIndex = 6;
            this.EdtSbtn.Text = "Edit";
            this.EdtSbtn.UseVisualStyleBackColor = true;
            this.EdtSbtn.Click += new System.EventHandler(this.EdtSbtn_Click);
            // 
            // UidStxt
            // 
            this.UidStxt.Location = new System.Drawing.Point(89, 318);
            this.UidStxt.Name = "UidStxt";
            this.UidStxt.Size = new System.Drawing.Size(100, 20);
            this.UidStxt.TabIndex = 42;
            // 
            // UidSlbl
            // 
            this.UidSlbl.AutoSize = true;
            this.UidSlbl.Location = new System.Drawing.Point(13, 321);
            this.UidSlbl.Name = "UidSlbl";
            this.UidSlbl.Size = new System.Drawing.Size(49, 13);
            this.UidSlbl.TabIndex = 44;
            this.UidSlbl.Text = "User ID :";
            // 
            // Holidpg
            // 
            this.Holidpg.Controls.Add(this.DelHbtn);
            this.Holidpg.Controls.Add(this.CanHbtn);
            this.Holidpg.Controls.Add(this.dtpHoliday);
            this.Holidpg.Controls.Add(this.Hdesclbl);
            this.Holidpg.Controls.Add(this.Hdtlbl);
            this.Holidpg.Controls.Add(this.Hdesctxt);
            this.Holidpg.Controls.Add(this.SavHbtn);
            this.Holidpg.Controls.Add(this.dgvHp);
            this.Holidpg.Location = new System.Drawing.Point(4, 22);
            this.Holidpg.Name = "Holidpg";
            this.Holidpg.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Holidpg.Size = new System.Drawing.Size(533, 312);
            this.Holidpg.TabIndex = 1;
            this.Holidpg.Text = "Holidays";
            this.Holidpg.UseVisualStyleBackColor = true;
            this.Holidpg.Click += new System.EventHandler(this.Holidpg_Click);
            // 
            // DelHbtn
            // 
            this.DelHbtn.Location = new System.Drawing.Point(340, 223);
            this.DelHbtn.Name = "DelHbtn";
            this.DelHbtn.Size = new System.Drawing.Size(75, 23);
            this.DelHbtn.TabIndex = 17;
            this.DelHbtn.Text = "Delete\r\n";
            this.DelHbtn.UseVisualStyleBackColor = true;
            this.DelHbtn.Click += new System.EventHandler(this.DelHbtn_Click_1);
            // 
            // CanHbtn
            // 
            this.CanHbtn.Location = new System.Drawing.Point(433, 223);
            this.CanHbtn.Name = "CanHbtn";
            this.CanHbtn.Size = new System.Drawing.Size(75, 23);
            this.CanHbtn.TabIndex = 16;
            this.CanHbtn.Text = "Cancel";
            this.CanHbtn.UseVisualStyleBackColor = true;
            this.CanHbtn.Click += new System.EventHandler(this.CanHbtn_Click);
            // 
            // dtpHoliday
            // 
            this.dtpHoliday.Location = new System.Drawing.Point(340, 77);
            this.dtpHoliday.Name = "dtpHoliday";
            this.dtpHoliday.Size = new System.Drawing.Size(155, 20);
            this.dtpHoliday.TabIndex = 15;
            // 
            // Hdesclbl
            // 
            this.Hdesclbl.AutoSize = true;
            this.Hdesclbl.Location = new System.Drawing.Point(251, 126);
            this.Hdesclbl.Name = "Hdesclbl";
            this.Hdesclbl.Size = new System.Drawing.Size(63, 13);
            this.Hdesclbl.TabIndex = 11;
            this.Hdesclbl.Text = "Description:";
            // 
            // Hdtlbl
            // 
            this.Hdtlbl.AutoSize = true;
            this.Hdtlbl.Location = new System.Drawing.Point(251, 77);
            this.Hdtlbl.Name = "Hdtlbl";
            this.Hdtlbl.Size = new System.Drawing.Size(74, 13);
            this.Hdtlbl.TabIndex = 10;
            this.Hdtlbl.Text = "Holiday Date :";
            // 
            // Hdesctxt
            // 
            this.Hdesctxt.Location = new System.Drawing.Point(340, 126);
            this.Hdesctxt.Name = "Hdesctxt";
            this.Hdesctxt.Size = new System.Drawing.Size(155, 20);
            this.Hdesctxt.TabIndex = 9;
            // 
            // SavHbtn
            // 
            this.SavHbtn.Location = new System.Drawing.Point(254, 223);
            this.SavHbtn.Name = "SavHbtn";
            this.SavHbtn.Size = new System.Drawing.Size(75, 23);
            this.SavHbtn.TabIndex = 6;
            this.SavHbtn.Text = "Save";
            this.SavHbtn.UseVisualStyleBackColor = true;
            this.SavHbtn.Click += new System.EventHandler(this.SavHbtn_Click);
            // 
            // dgvHp
            // 
            this.dgvHp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHp.Location = new System.Drawing.Point(3, 6);
            this.dgvHp.Name = "dgvHp";
            this.dgvHp.Size = new System.Drawing.Size(242, 305);
            this.dgvHp.TabIndex = 5;
            // 
            // Total
            // 
            this.Total.Controls.Add(this.attstulbl);
            this.Total.Controls.Add(this.attcrselbl);
            this.Total.Controls.Add(this.totclr);
            this.Total.Controls.Add(this.todtpto);
            this.Total.Controls.Add(this.totdtpst);
            this.Total.Controls.Add(this.label2);
            this.Total.Controls.Add(this.totstsdate);
            this.Total.Controls.Add(this.dgvtot);
            this.Total.Controls.Add(this.totgetbtn);
            this.Total.Controls.Add(this.totcmbstu);
            this.Total.Controls.Add(this.totcmbcrse);
            this.Total.ForeColor = System.Drawing.Color.Black;
            this.Total.Location = new System.Drawing.Point(4, 22);
            this.Total.Name = "Total";
            this.Total.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Total.Size = new System.Drawing.Size(533, 312);
            this.Total.TabIndex = 2;
            this.Total.Text = "Attendance";
            this.Total.UseVisualStyleBackColor = true;
            // 
            // attstulbl
            // 
            this.attstulbl.AutoSize = true;
            this.attstulbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attstulbl.ForeColor = System.Drawing.Color.Red;
            this.attstulbl.Location = new System.Drawing.Point(203, 24);
            this.attstulbl.Name = "attstulbl";
            this.attstulbl.Size = new System.Drawing.Size(97, 20);
            this.attstulbl.TabIndex = 12;
            this.attstulbl.Text = "select user";
            // 
            // attcrselbl
            // 
            this.attcrselbl.AutoSize = true;
            this.attcrselbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attcrselbl.ForeColor = System.Drawing.Color.Red;
            this.attcrselbl.Location = new System.Drawing.Point(43, 24);
            this.attcrselbl.Name = "attcrselbl";
            this.attcrselbl.Size = new System.Drawing.Size(116, 20);
            this.attcrselbl.TabIndex = 11;
            this.attcrselbl.Text = "select course";
            // 
            // totclr
            // 
            this.totclr.Location = new System.Drawing.Point(506, 44);
            this.totclr.Name = "totclr";
            this.totclr.Size = new System.Drawing.Size(75, 26);
            this.totclr.TabIndex = 10;
            this.totclr.Text = "Clear";
            this.totclr.UseVisualStyleBackColor = true;
            this.totclr.Click += new System.EventHandler(this.clrHbtn_Click);
            // 
            // todtpto
            // 
            this.todtpto.Location = new System.Drawing.Point(382, 114);
            this.todtpto.Name = "todtpto";
            this.todtpto.Size = new System.Drawing.Size(200, 20);
            this.todtpto.TabIndex = 9;
            // 
            // totdtpst
            // 
            this.totdtpst.Location = new System.Drawing.Point(113, 113);
            this.totdtpst.Name = "totdtpst";
            this.totdtpst.Size = new System.Drawing.Size(200, 20);
            this.totdtpst.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "To:";
            // 
            // totstsdate
            // 
            this.totstsdate.AutoSize = true;
            this.totstsdate.Location = new System.Drawing.Point(35, 114);
            this.totstsdate.Name = "totstsdate";
            this.totstsdate.Size = new System.Drawing.Size(72, 13);
            this.totstsdate.TabIndex = 6;
            this.totstsdate.Text = "Starting From:";
            // 
            // dgvtot
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtot.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvtot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtot.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtot.Location = new System.Drawing.Point(20, 185);
            this.dgvtot.Name = "dgvtot";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtot.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtot.RowTemplate.Height = 24;
            this.dgvtot.Size = new System.Drawing.Size(599, 150);
            this.dgvtot.TabIndex = 3;
            // 
            // totgetbtn
            // 
            this.totgetbtn.Location = new System.Drawing.Point(382, 42);
            this.totgetbtn.Name = "totgetbtn";
            this.totgetbtn.Size = new System.Drawing.Size(85, 26);
            this.totgetbtn.TabIndex = 2;
            this.totgetbtn.Text = "Get";
            this.totgetbtn.UseVisualStyleBackColor = true;
            this.totgetbtn.Click += new System.EventHandler(this.totgetbtn_Click);
            // 
            // totcmbstu
            // 
            this.totcmbstu.FormattingEnabled = true;
            this.totcmbstu.Location = new System.Drawing.Point(192, 46);
            this.totcmbstu.Name = "totcmbstu";
            this.totcmbstu.Size = new System.Drawing.Size(121, 21);
            this.totcmbstu.TabIndex = 1;
            this.totcmbstu.SelectedIndexChanged += new System.EventHandler(this.totcmbstu_SelectedIndexChanged);
            // 
            // totcmbcrse
            // 
            this.totcmbcrse.AutoCompleteCustomSource.AddRange(new string[] {
            "M.Tech",
            "P.hd",
            "All"});
            this.totcmbcrse.FormattingEnabled = true;
            this.totcmbcrse.Location = new System.Drawing.Point(38, 46);
            this.totcmbcrse.Name = "totcmbcrse";
            this.totcmbcrse.Size = new System.Drawing.Size(121, 21);
            this.totcmbcrse.TabIndex = 0;
            this.totcmbcrse.SelectedIndexChanged += new System.EventHandler(this.totcmbcrse_SelectedIndexChanged);
            // 
            // administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 338);
            this.Controls.Add(this.Admtab);
            this.Name = "administrator";
            this.Text = "administrator";
            this.Load += new System.EventHandler(this.administrator_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.administrator_FormClosing);
            this.Admtab.ResumeLayout(false);
            this.Stdtpg.ResumeLayout(false);
            this.Stdtpg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stddgv)).EndInit();
            this.Holidpg.ResumeLayout(false);
            this.Holidpg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHp)).EndInit();
            this.Total.ResumeLayout(false);
            this.Total.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Admtab;
        private System.Windows.Forms.TabPage Stdtpg;
        private System.Windows.Forms.TabPage Holidpg;
        private System.Windows.Forms.DataGridView dgvHp;
        private System.Windows.Forms.Button DelSbtn;
        private System.Windows.Forms.Button EdtSbtn;
        private System.Windows.Forms.ComboBox ClsScmb;
        private System.Windows.Forms.Label ClsSlbl;
        private System.Windows.Forms.Label UnmSlbl;
        private System.Windows.Forms.TextBox UnmStxt;
        private System.Windows.Forms.DataGridView Stddgv;
        private System.Windows.Forms.Button SavHbtn;
        private System.Windows.Forms.Label Hdesclbl;
        private System.Windows.Forms.Label Hdtlbl;
        private System.Windows.Forms.TextBox Hdesctxt;
        private System.Windows.Forms.Button SavSbtn;
        private System.Windows.Forms.TextBox UidStxt;
        private System.Windows.Forms.Label UidSlbl;
        private System.Windows.Forms.ComboBox cmbUType;
        private System.Windows.Forms.Label Usrtylbl;
        private System.Windows.Forms.Button CanSbtn;
        private System.Windows.Forms.DateTimePicker dtpHoliday;
        private System.Windows.Forms.Button CanHbtn;
        private System.Windows.Forms.TabPage Total;
        private System.Windows.Forms.DataGridView dgvtot;
        private System.Windows.Forms.Button totgetbtn;
        private System.Windows.Forms.ComboBox totcmbstu;
        private System.Windows.Forms.ComboBox totcmbcrse;
      
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totstsdate;
        private System.Windows.Forms.DateTimePicker todtpto;
        private System.Windows.Forms.DateTimePicker totdtpst;
        private System.Windows.Forms.Button totclr;
        private System.Windows.Forms.Label attstulbl;
        private System.Windows.Forms.Label attcrselbl;
        private System.Windows.Forms.Button DelHbtn;
    }
}