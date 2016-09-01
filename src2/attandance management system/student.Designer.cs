namespace attandance_management_system
{
    partial class user
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
            this.uattandance = new System.Windows.Forms.Button();
            this.stcnlbt = new System.Windows.Forms.Button();
            this.ajay = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ajay)).BeginInit();
            this.SuspendLayout();
            // 
            // uattandance
            // 
            this.uattandance.Location = new System.Drawing.Point(167, 117);
            this.uattandance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uattandance.Name = "uattandance";
            this.uattandance.Size = new System.Drawing.Size(132, 46);
            this.uattandance.TabIndex = 2;
            this.uattandance.Text = "attandance";
            this.uattandance.UseVisualStyleBackColor = true;
            this.uattandance.Click += new System.EventHandler(this.uattandance_Click);
            // 
            // stcnlbt
            // 
            this.stcnlbt.Location = new System.Drawing.Point(372, 117);
            this.stcnlbt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stcnlbt.Name = "stcnlbt";
            this.stcnlbt.Size = new System.Drawing.Size(131, 46);
            this.stcnlbt.TabIndex = 3;
            this.stcnlbt.Text = "cancel";
            this.stcnlbt.UseVisualStyleBackColor = true;
            this.stcnlbt.Click += new System.EventHandler(this.stcnlbt_Click_1);
            // 
            // ajay
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ajay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ajay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ajay.DefaultCellStyle = dataGridViewCellStyle2;
            this.ajay.Location = new System.Drawing.Point(64, 204);
            this.ajay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ajay.Name = "ajay";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ajay.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ajay.RowTemplate.Height = 24;
            this.ajay.Size = new System.Drawing.Size(662, 117);
            this.ajay.TabIndex = 5;
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 436);
            this.Controls.Add(this.ajay);
            this.Controls.Add(this.stcnlbt);
            this.Controls.Add(this.uattandance);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "user";
            this.Text = "user";
            this.Load += new System.EventHandler(this.user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ajay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uattandance;
        private System.Windows.Forms.Button stcnlbt;
        private System.Windows.Forms.DataGridView ajay;
    }
}