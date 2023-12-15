namespace KENT_SERVICE_PROJECT
{
    partial class RequestInstallation
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.txtSerialNum = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblInstall = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.chkboxwhatsapp = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmbProduct
            // 
            this.cmbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(39, 96);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(268, 28);
            this.cmbProduct.TabIndex = 0;
            this.cmbProduct.Text = "Select Product";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(44, 56);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(64, 20);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Product";
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Location = new System.Drawing.Point(44, 170);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(109, 20);
            this.lblSerialNumber.TabIndex = 2;
            this.lblSerialNumber.Text = "Serial Number";
            // 
            // txtSerialNum
            // 
            this.txtSerialNum.Location = new System.Drawing.Point(39, 207);
            this.txtSerialNum.Name = "txtSerialNum";
            this.txtSerialNum.Size = new System.Drawing.Size(268, 26);
            this.txtSerialNum.TabIndex = 3;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(39, 317);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(274, 26);
            this.dateTimePicker.TabIndex = 4;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(44, 271);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(152, 20);
            this.lblDateTime.TabIndex = 5;
            this.lblDateTime.Text = "Preferred Date/Time";
            // 
            // lblInstall
            // 
            this.lblInstall.AutoSize = true;
            this.lblInstall.Location = new System.Drawing.Point(44, 374);
            this.lblInstall.Name = "lblInstall";
            this.lblInstall.Size = new System.Drawing.Size(149, 20);
            this.lblInstall.TabIndex = 6;
            this.lblInstall.Text = "Installation Address";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(39, 397);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(413, 99);
            this.textBox2.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(155, 558);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(140, 54);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // chkboxwhatsapp
            // 
            this.chkboxwhatsapp.AutoSize = true;
            this.chkboxwhatsapp.Location = new System.Drawing.Point(39, 513);
            this.chkboxwhatsapp.Name = "chkboxwhatsapp";
            this.chkboxwhatsapp.Size = new System.Drawing.Size(231, 24);
            this.chkboxwhatsapp.TabIndex = 9;
            this.chkboxwhatsapp.Text = "Get Updates On WhatsApp";
            this.chkboxwhatsapp.UseVisualStyleBackColor = true;
            // 
            // RequestInstallation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(483, 638);
            this.Controls.Add(this.chkboxwhatsapp);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblInstall);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtSerialNum);
            this.Controls.Add(this.lblSerialNumber);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.cmbProduct);
            this.Name = "RequestInstallation";
            this.Text = "RequestInstallation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.TextBox txtSerialNum;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblInstall;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox chkboxwhatsapp;
    }
}