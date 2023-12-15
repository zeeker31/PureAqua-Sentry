namespace KENT_SERVICE_PROJECT
{
    partial class RequestService
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
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.labelprod = new System.Windows.Forms.Label();
            this.labeldatetime = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelproblem = new System.Windows.Forms.Label();
            this.comboBoxProblem = new System.Windows.Forms.ComboBox();
            this.labelRemarks = new System.Windows.Forms.Label();
            this.textBoxRemarks = new System.Windows.Forms.TextBox();
            this.labelInstallation = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxUpdates = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBoxService
            // 
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Location = new System.Drawing.Point(56, 78);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(260, 28);
            this.comboBoxService.TabIndex = 0;
            // 
            // labelprod
            // 
            this.labelprod.AutoSize = true;
            this.labelprod.Location = new System.Drawing.Point(52, 46);
            this.labelprod.Name = "labelprod";
            this.labelprod.Size = new System.Drawing.Size(64, 20);
            this.labelprod.TabIndex = 1;
            this.labelprod.Text = "Product";
            // 
            // labeldatetime
            // 
            this.labeldatetime.AutoSize = true;
            this.labeldatetime.Location = new System.Drawing.Point(52, 129);
            this.labeldatetime.Name = "labeldatetime";
            this.labeldatetime.Size = new System.Drawing.Size(152, 20);
            this.labeldatetime.TabIndex = 2;
            this.labeldatetime.Text = "Preferred Date/Time";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(56, 165);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(260, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // labelproblem
            // 
            this.labelproblem.AutoSize = true;
            this.labelproblem.Location = new System.Drawing.Point(52, 232);
            this.labelproblem.Name = "labelproblem";
            this.labelproblem.Size = new System.Drawing.Size(67, 20);
            this.labelproblem.TabIndex = 4;
            this.labelproblem.Text = "Problem";
            // 
            // comboBoxProblem
            // 
            this.comboBoxProblem.FormattingEnabled = true;
            this.comboBoxProblem.Location = new System.Drawing.Point(56, 267);
            this.comboBoxProblem.Name = "comboBoxProblem";
            this.comboBoxProblem.Size = new System.Drawing.Size(260, 28);
            this.comboBoxProblem.TabIndex = 5;
            this.comboBoxProblem.Text = "Please Select Problem";
            // 
            // labelRemarks
            // 
            this.labelRemarks.AutoSize = true;
            this.labelRemarks.Location = new System.Drawing.Point(52, 328);
            this.labelRemarks.Name = "labelRemarks";
            this.labelRemarks.Size = new System.Drawing.Size(139, 20);
            this.labelRemarks.TabIndex = 6;
            this.labelRemarks.Text = "Remarks(optional)";
            // 
            // textBoxRemarks
            // 
            this.textBoxRemarks.Location = new System.Drawing.Point(56, 363);
            this.textBoxRemarks.Name = "textBoxRemarks";
            this.textBoxRemarks.Size = new System.Drawing.Size(260, 26);
            this.textBoxRemarks.TabIndex = 7;
            this.textBoxRemarks.Text = "Remarks";
            // 
            // labelInstallation
            // 
            this.labelInstallation.AutoSize = true;
            this.labelInstallation.Location = new System.Drawing.Point(52, 418);
            this.labelInstallation.Name = "labelInstallation";
            this.labelInstallation.Size = new System.Drawing.Size(149, 20);
            this.labelInstallation.TabIndex = 8;
            this.labelInstallation.Text = "Installation Address";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 453);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 26);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Kent, office, Noida,UttarPradessh, 201309,09278912345";
            // 
            // checkBoxUpdates
            // 
            this.checkBoxUpdates.AutoSize = true;
            this.checkBoxUpdates.Location = new System.Drawing.Point(56, 560);
            this.checkBoxUpdates.Name = "checkBoxUpdates";
            this.checkBoxUpdates.Size = new System.Drawing.Size(231, 24);
            this.checkBoxUpdates.TabIndex = 10;
            this.checkBoxUpdates.Text = "Get Updates On WhatsApp";
            this.checkBoxUpdates.UseVisualStyleBackColor = true;
            // 
            // RequestService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 637);
            this.Controls.Add(this.checkBoxUpdates);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelInstallation);
            this.Controls.Add(this.textBoxRemarks);
            this.Controls.Add(this.labelRemarks);
            this.Controls.Add(this.comboBoxProblem);
            this.Controls.Add(this.labelproblem);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labeldatetime);
            this.Controls.Add(this.labelprod);
            this.Controls.Add(this.comboBoxService);
            this.Name = "RequestService";
            this.Text = "RequestService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.Label labelprod;
        private System.Windows.Forms.Label labeldatetime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelproblem;
        private System.Windows.Forms.ComboBox comboBoxProblem;
        private System.Windows.Forms.Label labelRemarks;
        private System.Windows.Forms.TextBox textBoxRemarks;
        private System.Windows.Forms.Label labelInstallation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxUpdates;
    }
}