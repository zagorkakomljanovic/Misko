namespace konekcija
{
    partial class frmHOLIDAY
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnACCEPT = new System.Windows.Forms.Button();
            this.cmbCARDHOLDER = new System.Windows.Forms.ComboBox();
            this.cardholderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTOTAL = new System.Windows.Forms.Label();
            this.lblCARDHOLDER = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtTOTAL = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardholderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnACCEPT);
            this.groupBox1.Controls.Add(this.cmbCARDHOLDER);
            this.groupBox1.Controls.Add(this.lblTOTAL);
            this.groupBox1.Controls.Add(this.lblCARDHOLDER);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.txtTOTAL);
            this.groupBox1.Location = new System.Drawing.Point(26, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 289);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leave request form";
            // 
            // btnACCEPT
            // 
            this.btnACCEPT.Location = new System.Drawing.Point(114, 234);
            this.btnACCEPT.Name = "btnACCEPT";
            this.btnACCEPT.Size = new System.Drawing.Size(123, 29);
            this.btnACCEPT.TabIndex = 8;
            this.btnACCEPT.Text = "Accept";
            this.btnACCEPT.UseVisualStyleBackColor = true;
            this.btnACCEPT.Click += new System.EventHandler(this.btnACCEPT_Click);
            // 
            // cmbCARDHOLDER
            // 
            this.cmbCARDHOLDER.DataSource = this.cardholderBindingSource;
            this.cmbCARDHOLDER.DisplayMember = "Name";
            this.cmbCARDHOLDER.FormattingEnabled = true;
            this.cmbCARDHOLDER.Location = new System.Drawing.Point(100, 41);
            this.cmbCARDHOLDER.Name = "cmbCARDHOLDER";
            this.cmbCARDHOLDER.Size = new System.Drawing.Size(200, 21);
            this.cmbCARDHOLDER.TabIndex = 1;
            this.cmbCARDHOLDER.ValueMember = "Name";
            this.cmbCARDHOLDER.SelectedIndexChanged += new System.EventHandler(this.cmbCARDHOLDER_SelectedIndexChanged);
            // 
            // cardholderBindingSource
            // 
            this.cardholderBindingSource.DataSource = typeof(konekcija.Cardholder);
            // 
            // lblTOTAL
            // 
            this.lblTOTAL.AutoSize = true;
            this.lblTOTAL.Location = new System.Drawing.Point(40, 192);
            this.lblTOTAL.Name = "lblTOTAL";
            this.lblTOTAL.Size = new System.Drawing.Size(34, 13);
            this.lblTOTAL.TabIndex = 7;
            this.lblTOTAL.Text = "Total:";
            // 
            // lblCARDHOLDER
            // 
            this.lblCARDHOLDER.AutoSize = true;
            this.lblCARDHOLDER.Location = new System.Drawing.Point(40, 44);
            this.lblCARDHOLDER.Name = "lblCARDHOLDER";
            this.lblCARDHOLDER.Size = new System.Drawing.Size(45, 13);
            this.lblCARDHOLDER.TabIndex = 0;
            this.lblCARDHOLDER.Text = "Worker:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Return:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Leave:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(100, 139);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // txtTOTAL
            // 
            this.txtTOTAL.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTOTAL.Location = new System.Drawing.Point(100, 189);
            this.txtTOTAL.Name = "txtTOTAL";
            this.txtTOTAL.ReadOnly = true;
            this.txtTOTAL.Size = new System.Drawing.Size(55, 20);
            this.txtTOTAL.TabIndex = 4;
            // 
            // frmHOLIDAY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 331);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHOLIDAY";
            this.Text = "Holiday";
            this.Load += new System.EventHandler(this.frmHOLIDAY_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardholderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnACCEPT;
        private System.Windows.Forms.ComboBox cmbCARDHOLDER;
        private System.Windows.Forms.Label lblTOTAL;
        private System.Windows.Forms.Label lblCARDHOLDER;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtTOTAL;
        private System.Windows.Forms.BindingSource cardholderBindingSource;
    }
}