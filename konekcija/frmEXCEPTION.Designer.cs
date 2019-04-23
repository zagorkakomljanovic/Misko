namespace konekcija
{
    partial class frmEXCEPTION
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.chkIN_OUT = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cboxCARDHOLDER = new System.Windows.Forms.ComboBox();
            this.cardholderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblRadnik = new System.Windows.Forms.Label();
            this.accessLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDO = new System.Windows.Forms.Label();
            this.lblOD = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgCHECKLIST = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardholderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessLogBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCHECKLIST)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.chkIN_OUT);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(59, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(305, 107);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exceptions";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(37, 71);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(77, 21);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Holiday";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // chkIN_OUT
            // 
            this.chkIN_OUT.AutoSize = true;
            this.chkIN_OUT.Location = new System.Drawing.Point(148, 31);
            this.chkIN_OUT.Margin = new System.Windows.Forms.Padding(4);
            this.chkIN_OUT.Name = "chkIN_OUT";
            this.chkIN_OUT.Size = new System.Drawing.Size(124, 21);
            this.chkIN_OUT.TabIndex = 1;
            this.chkIN_OUT.Text = "Check IN_OUT";
            this.chkIN_OUT.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(37, 31);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Work time";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cboxCARDHOLDER
            // 
            this.cboxCARDHOLDER.DataSource = this.cardholderBindingSource;
            this.cboxCARDHOLDER.DisplayMember = "Name";
            this.cboxCARDHOLDER.FormattingEnabled = true;
            this.cboxCARDHOLDER.Location = new System.Drawing.Point(117, 44);
            this.cboxCARDHOLDER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxCARDHOLDER.Name = "cboxCARDHOLDER";
            this.cboxCARDHOLDER.Size = new System.Drawing.Size(245, 24);
            this.cboxCARDHOLDER.TabIndex = 2;
            this.cboxCARDHOLDER.ValueMember = "Name";
            this.cboxCARDHOLDER.SelectedIndexChanged += new System.EventHandler(this.cboxCARDHOLDER_SelectedIndexChanged);
            this.cboxCARDHOLDER.Click += new System.EventHandler(this.cboxCARDHOLDER_Click);
            // 
            // cardholderBindingSource
            //            
            // 
            // lblRadnik
            // 
            this.lblRadnik.AutoSize = true;
            this.lblRadnik.Location = new System.Drawing.Point(55, 48);
            this.lblRadnik.Name = "lblRadnik";
            this.lblRadnik.Size = new System.Drawing.Size(58, 17);
            this.lblRadnik.TabIndex = 3;
            this.lblRadnik.Text = "Worker:";
            // 
            // accessLogBindingSource
            // 
            
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDO);
            this.groupBox2.Controls.Add(this.lblOD);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Location = new System.Drawing.Point(401, 114);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(316, 107);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date";
            // 
            // lblDO
            // 
            this.lblDO.AutoSize = true;
            this.lblDO.Location = new System.Drawing.Point(33, 71);
            this.lblDO.Name = "lblDO";
            this.lblDO.Size = new System.Drawing.Size(25, 17);
            this.lblDO.TabIndex = 3;
            this.lblDO.Text = "To";
            // 
            // lblOD
            // 
            this.lblOD.AutoSize = true;
            this.lblOD.Location = new System.Drawing.Point(20, 28);
            this.lblOD.Name = "lblOD";
            this.lblOD.Size = new System.Drawing.Size(40, 17);
            this.lblOD.TabIndex = 2;
            this.lblOD.Text = "From";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(85, 65);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(85, 25);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.createQuery1);
            // 
            // dgCHECKLIST
            // 
            this.dgCHECKLIST.AllowUserToAddRows = false;
            dataGridViewCellStyle1.NullValue = null;
            this.dgCHECKLIST.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCHECKLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCHECKLIST.Location = new System.Drawing.Point(59, 260);
            this.dgCHECKLIST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgCHECKLIST.Name = "dgCHECKLIST";
            this.dgCHECKLIST.RowTemplate.Height = 24;
            this.dgCHECKLIST.Size = new System.Drawing.Size(659, 257);
            this.dgCHECKLIST.TabIndex = 8;
            this.dgCHECKLIST.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgCHECKLIST_DataBindingComplete);
            // 
            // frmEXCEPTION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 562);
            this.Controls.Add(this.dgCHECKLIST);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cboxCARDHOLDER);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRadnik);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEXCEPTION";
            this.Text = "Exception";
            this.Load += new System.EventHandler(this.frmEXCEPTION_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardholderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessLogBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCHECKLIST)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxCARDHOLDER;
        private System.Windows.Forms.Label lblRadnik;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDO;
        private System.Windows.Forms.Label lblOD;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource accessLogBindingSource;
        private System.Windows.Forms.BindingSource cardholderBindingSource;
        private System.Windows.Forms.DataGridView dgCHECKLIST;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox chkIN_OUT;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}