namespace KENT_SERVICE_PROJECT
{
    partial class Buy_AMC
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
            this.comboBoxprdt = new System.Windows.Forms.ComboBox();
            this.labelprdt = new System.Windows.Forms.Label();
            this.labelRegion = new System.Windows.Forms.Label();
            this.textBoxaddrss = new System.Windows.Forms.TextBox();
            this.labeladdrss = new System.Windows.Forms.Label();
            this.btnProceed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxprdt
            // 
            this.comboBoxprdt.FormattingEnabled = true;
            this.comboBoxprdt.Location = new System.Drawing.Point(52, 88);
            this.comboBoxprdt.Name = "comboBoxprdt";
            this.comboBoxprdt.Size = new System.Drawing.Size(279, 28);
            this.comboBoxprdt.TabIndex = 0;
            this.comboBoxprdt.Text = "Select Product";
            // 
            // labelprdt
            // 
            this.labelprdt.AutoSize = true;
            this.labelprdt.Location = new System.Drawing.Point(48, 45);
            this.labelprdt.Name = "labelprdt";
            this.labelprdt.Size = new System.Drawing.Size(64, 20);
            this.labelprdt.TabIndex = 1;
            this.labelprdt.Text = "Product";
            // 
            // labelRegion
            // 
            this.labelRegion.AutoSize = true;
            this.labelRegion.Location = new System.Drawing.Point(48, 149);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(60, 20);
            this.labelRegion.TabIndex = 2;
            this.labelRegion.Text = "Region";
            // 
            // textBoxaddrss
            // 
            this.textBoxaddrss.Location = new System.Drawing.Point(52, 314);
            this.textBoxaddrss.Name = "textBoxaddrss";
            this.textBoxaddrss.Size = new System.Drawing.Size(279, 26);
            this.textBoxaddrss.TabIndex = 3;
            this.textBoxaddrss.Text = "Kent Contact Number 09278912345";
            // 
            // labeladdrss
            // 
            this.labeladdrss.AutoSize = true;
            this.labeladdrss.Location = new System.Drawing.Point(48, 268);
            this.labeladdrss.Name = "labeladdrss";
            this.labeladdrss.Size = new System.Drawing.Size(68, 20);
            this.labeladdrss.TabIndex = 4;
            this.labeladdrss.Text = "Address";
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(131, 506);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(155, 65);
            this.btnProceed.TabIndex = 5;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = true;
            // 
            // Buy_AMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 608);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.labeladdrss);
            this.Controls.Add(this.textBoxaddrss);
            this.Controls.Add(this.labelRegion);
            this.Controls.Add(this.labelprdt);
            this.Controls.Add(this.comboBoxprdt);
            this.Name = "Buy_AMC";
            this.Text = "BuyAMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxprdt;
        private System.Windows.Forms.Label labelprdt;
        private System.Windows.Forms.Label labelRegion;
        private System.Windows.Forms.TextBox textBoxaddrss;
        private System.Windows.Forms.Label labeladdrss;
        private System.Windows.Forms.Button btnProceed;
    }
}