namespace KENT_SERVICE_PROJECT
{
    partial class ManualVerification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManualVerification));
            this.labelSerialNo = new System.Windows.Forms.Label();
            this.textBoxSerialNo = new System.Windows.Forms.TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.picboxNote = new System.Windows.Forms.PictureBox();
            this.btnVer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picboxNote)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSerialNo
            // 
            this.labelSerialNo.AutoSize = true;
            this.labelSerialNo.Location = new System.Drawing.Point(38, 51);
            this.labelSerialNo.Name = "labelSerialNo";
            this.labelSerialNo.Size = new System.Drawing.Size(160, 20);
            this.labelSerialNo.TabIndex = 0;
            this.labelSerialNo.Text = "Spare Serial Number ";
            // 
            // textBoxSerialNo
            // 
            this.textBoxSerialNo.Location = new System.Drawing.Point(42, 95);
            this.textBoxSerialNo.Name = "textBoxSerialNo";
            this.textBoxSerialNo.Size = new System.Drawing.Size(355, 26);
            this.textBoxSerialNo.TabIndex = 1;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Location = new System.Drawing.Point(38, 189);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(43, 20);
            this.labelNotes.TabIndex = 2;
            this.labelNotes.Text = "Note";
            // 
            // picboxNote
            // 
            this.picboxNote.Image = ((System.Drawing.Image)(resources.GetObject("picboxNote.Image")));
            this.picboxNote.Location = new System.Drawing.Point(78, 228);
            this.picboxNote.Name = "picboxNote";
            this.picboxNote.Size = new System.Drawing.Size(287, 107);
            this.picboxNote.TabIndex = 3;
            this.picboxNote.TabStop = false;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(182, 514);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(136, 75);
            this.btnVer.TabIndex = 4;
            this.btnVer.Text = "Verify";
            this.btnVer.UseVisualStyleBackColor = true;
            // 
            // ManualVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 652);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.picboxNote);
            this.Controls.Add(this.labelNotes);
            this.Controls.Add(this.textBoxSerialNo);
            this.Controls.Add(this.labelSerialNo);
            this.Name = "ManualVerification";
            this.Text = "ManualVerification";
            ((System.ComponentModel.ISupportInitialize)(this.picboxNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSerialNo;
        private System.Windows.Forms.TextBox textBoxSerialNo;
        private System.Windows.Forms.Label labelNotes;
        private System.Windows.Forms.PictureBox picboxNote;
        private System.Windows.Forms.Button btnVer;
    }
}