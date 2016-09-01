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
            this.Admtab = new System.Windows.Forms.TabControl();
            this.Stdtpg = new System.Windows.Forms.TabPage();
            this.butCancel = new System.Windows.Forms.Button();
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
            this.EdtHbtn = new System.Windows.Forms.Button();
            this.Hdesclbl = new System.Windows.Forms.Label();
            this.Hdtlbl = new System.Windows.Forms.Label();
            this.Hdesctxt = new System.Windows.Forms.TextBox();
            this.DelHbtn = new System.Windows.Forms.Button();
            this.SavHbtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dtpHoliday = new System.Windows.Forms.DateTimePicker();
            this.Admtab.SuspendLayout();
            this.Stdtpg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Stddgv)).BeginInit();
            this.Holidpg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Admtab
            // 
            this.Admtab.Controls.Add(this.Stdtpg);
            this.Admtab.Controls.Add(this.Holidpg);
            this.Admtab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Admtab.Location = new System.Drawing.Point(0, 0);
            this.Admtab.Name = "Admtab";
            this.Admtab.SelectedIndex = 0;
            this.Admtab.Size = new System.Drawing.Size(689, 446);
            this.Admtab.TabIndex = 9;
            // 
            // Stdtpg
            // 
            this.Stdtpg.Controls.Add(this.butCancel);
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
            this.Stdtpg.Padding = new System.Windows.Forms.Padding(3);
            this.Stdtpg.Size = new System.Drawing.Size(681, 420);
            this.Stdtpg.TabIndex = 0;
            this.Stdtpg.Text = "Student";
            this.Stdtpg.UseVisualStyleBackColor = true;
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(424, 286);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(75, 23);
            this.butCancel.TabIndex = 54;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // Usrtylbl
            // 
            this.Usrtylbl.AutoSize = true;
            this.Usrtylbl.Location = new System.Drawing.Point(298, 379);
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
            this.cmbUType.Location = new System.Drawing.Point(379, 374);
            this.cmbUType.Name = "cmbUType";
            this.cmbUType.Size = new System.Drawing.Size(100, 21);
            this.cmbUType.TabIndex = 51;
            // 
            // SavSbtn
            // 
            this.SavSbtn.Location = new System.Drawing.Point(343, 286);
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
            this.Stddgv.Location = new System.Drawing.Point(6, 0);
            this.Stddgv.MultiSelect = false;
            this.Stddgv.Name = "Stddgv";
            this.Stddgv.RowHeadersVisible = false;
            this.Stddgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Stddgv.Size = new System.Drawing.Size(492, 280);
            this.Stddgv.TabIndex = 48;
            this.Stddgv.SelectionChanged += new System.EventHandler(this.Stddgv_SelectionChanged);
            this.Stddgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Stddgv_CellContentClick);
            // 
            // ClsSlbl
            // 
            this.ClsSlbl.AutoSize = true;
            this.ClsSlbl.Location = new System.Drawing.Point(64, 379);
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
            "P.hd"});
            this.ClsScmb.Location = new System.Drawing.Point(138, 376);
            this.ClsScmb.Name = "ClsScmb";
            this.ClsScmb.Size = new System.Drawing.Size(100, 21);
            this.ClsScmb.TabIndex = 47;
            // 
            // UnmSlbl
            // 
            this.UnmSlbl.AutoSize = true;
            this.UnmSlbl.Location = new System.Drawing.Point(294, 335);
            this.UnmSlbl.Name = "UnmSlbl";
            this.UnmSlbl.Size = new System.Drawing.Size(66, 13);
            this.UnmSlbl.TabIndex = 45;
            this.UnmSlbl.Text = "User Name :";
            // 
            // DelSbtn
            // 
            this.DelSbtn.Location = new System.Drawing.Point(96, 286);
            this.DelSbtn.Name = "DelSbtn";
            this.DelSbtn.Size = new System.Drawing.Size(75, 23);
            this.DelSbtn.TabIndex = 7;
            this.DelSbtn.Text = "Delete";
            this.DelSbtn.UseVisualStyleBackColor = true;
            this.DelSbtn.Click += new System.EventHandler(this.DelSbtn_Click);
            // 
            // UnmStxt
            // 
            this.UnmStxt.Location = new System.Drawing.Point(379, 328);
            this.UnmStxt.Name = "UnmStxt";
            this.UnmStxt.Size = new System.Drawing.Size(100, 20);
            this.UnmStxt.TabIndex = 43;
            // 
            // EdtSbtn
            // 
            this.EdtSbtn.Location = new System.Drawing.Point(6, 286);
            this.EdtSbtn.Name = "EdtSbtn";
            this.EdtSbtn.Size = new System.Drawing.Size(75, 23);
            this.EdtSbtn.TabIndex = 6;
            this.EdtSbtn.Text = "Edit";
            this.EdtSbtn.UseVisualStyleBackColor = true;
            this.EdtSbtn.Click += new System.EventHandler(this.EdtSbtn_Click);
            // 
            // UidStxt
            // 
            this.UidStxt.Location = new System.Drawing.Point(138, 328);
            this.UidStxt.Name = "UidStxt";
            this.UidStxt.Size = new System.Drawing.Size(100, 20);
            this.UidStxt.TabIndex = 42;
            // 
            // UidSlbl
            // 
            this.UidSlbl.AutoSize = true;
            this.UidSlbl.Location = new System.Drawing.Point(53, 328);
            this.UidSlbl.Name = "UidSlbl";
            this.UidSlbl.Size = new System.Drawing.Size(49, 13);
            this.UidSlbl.TabIndex = 44;
            this.UidSlbl.Text = "User ID :";
            // 
            // Holidpg
            // 
            this.Holidpg.Controls.Add(this.dtpHoliday);
            this.Holidpg.Controls.Add(this.EdtHbtn);
            this.Holidpg.Controls.Add(this.Hdesclbl);
            this.Holidpg.Controls.Add(this.Hdtlbl);
            this.Holidpg.Controls.Add(this.Hdesctxt);
            this.Holidpg.Controls.Add(this.DelHbtn);
            this.Holidpg.Controls.Add(this.SavHbtn);
            this.Holidpg.Controls.Add(this.dataGridView2);
            this.Holidpg.Location = new System.Drawing.Point(4, 22);
            this.Holidpg.Name = "Holidpg";
            this.Holidpg.Padding = new System.Windows.Forms.Padding(3);
            this.Holidpg.Size = new System.Drawing.Size(681, 420);
            this.Holidpg.TabIndex = 1;
            this.Holidpg.Text = "Holidays";
            this.Holidpg.UseVisualStyleBackColor = true;
            this.Holidpg.Click += new System.EventHandler(this.Holidpg_Click);
            // 
            // EdtHbtn
            // 
            this.EdtHbtn.Location = new System.Drawing.Point(406, 231);
            this.EdtHbtn.Name = "EdtHbtn";
            this.EdtHbtn.Size = new System.Drawing.Size(78, 23);
            this.EdtHbtn.TabIndex = 13;
            this.EdtHbtn.Text = "Edit";
            this.EdtHbtn.UseVisualStyleBackColor = true;
            this.EdtHbtn.Click += new System.EventHandler(this.EdtHbtn_Click);
            // 
            // Hdesclbl
            // 
            this.Hdesclbl.AutoSize = true;
            this.Hdesclbl.Location = new System.Drawing.Point(316, 130);
            this.Hdesclbl.Name = "Hdesclbl";
            this.Hdesclbl.Size = new System.Drawing.Size(63, 13);
            this.Hdesclbl.TabIndex = 11;
            this.Hdesclbl.Text = "Description:";
            // 
            // Hdtlbl
            // 
            this.Hdtlbl.AutoSize = true;
            this.Hdtlbl.Location = new System.Drawing.Point(316, 81);
            this.Hdtlbl.Name = "Hdtlbl";
            this.Hdtlbl.Size = new System.Drawing.Size(74, 13);
            this.Hdtlbl.TabIndex = 10;
            this.Hdtlbl.Text = "Holiday Date :";
            // 
            // Hdesctxt
            // 
            this.Hdesctxt.Location = new System.Drawing.Point(406, 123);
            this.Hdesctxt.Name = "Hdesctxt";
            this.Hdesctxt.Size = new System.Drawing.Size(154, 20);
            this.Hdesctxt.TabIndex = 9;
            // 
            // DelHbtn
            // 
            this.DelHbtn.Location = new System.Drawing.Point(511, 231);
            this.DelHbtn.Name = "DelHbtn";
            this.DelHbtn.Size = new System.Drawing.Size(75, 23);
            this.DelHbtn.TabIndex = 7;
            this.DelHbtn.Text = "Delete";
            this.DelHbtn.UseVisualStyleBackColor = true;
            // 
            // SavHbtn
            // 
            this.SavHbtn.Location = new System.Drawing.Point(288, 231);
            this.SavHbtn.Name = "SavHbtn";
            this.SavHbtn.Size = new System.Drawing.Size(75, 23);
            this.SavHbtn.TabIndex = 6;
            this.SavHbtn.Text = "Save";
            this.SavHbtn.UseVisualStyleBackColor = true;
            this.SavHbtn.Click += new System.EventHandler(this.SavHbtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(242, 305);
            this.dataGridView2.TabIndex = 5;
            // 
            // dtpHoliday
            // 
            this.dtpHoliday.Location = new System.Drawing.Point(406, 75);
            this.dtpHoliday.Name = "dtpHoliday";
            this.dtpHoliday.Size = new System.Drawing.Size(155, 20);
            this.dtpHoliday.TabIndex = 15;
            this.dtpHoliday.ValueChanged += new System.EventHandler(this.dtpHoliday);
            // 
            // administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 446);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Admtab;
        private System.Windows.Forms.TabPage Stdtpg;
        private System.Windows.Forms.TabPage Holidpg;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button DelSbtn;
        private System.Windows.Forms.Button EdtSbtn;
        private System.Windows.Forms.ComboBox ClsScmb;
        private System.Windows.Forms.Label ClsSlbl;
        private System.Windows.Forms.Label UnmSlbl;
        private System.Windows.Forms.TextBox UnmStxt;
        private System.Windows.Forms.DataGridView Stddgv;
        private System.Windows.Forms.Button DelHbtn;
        private System.Windows.Forms.Button SavHbtn;
        private System.Windows.Forms.Label Hdesclbl;
        private System.Windows.Forms.Label Hdtlbl;
        private System.Windows.Forms.TextBox Hdesctxt;
        private System.Windows.Forms.Button SavSbtn;
        private System.Windows.Forms.TextBox UidStxt;
        private System.Windows.Forms.Label UidSlbl;
        private System.Windows.Forms.Button EdtHbtn;
        private System.Windows.Forms.ComboBox cmbUType;
        private System.Windows.Forms.Label Usrtylbl;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.DateTimePicker dtpHoliday;
    }
}