namespace KENT_SERVICE_PROJECT
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnBuyAMC = new System.Windows.Forms.Button();
            this.btnServiceHistory = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRequest
            // 
            this.btnRequest.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequest.Image = ((System.Drawing.Image)(resources.GetObject("btnRequest.Image")));
            this.btnRequest.Location = new System.Drawing.Point(54, 56);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(216, 207);
            this.btnRequest.TabIndex = 0;
            this.btnRequest.Text = "Request Installation";
            this.btnRequest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnService
            // 
            this.btnService.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnService.Image = ((System.Drawing.Image)(resources.GetObject("btnService.Image")));
            this.btnService.Location = new System.Drawing.Point(307, 56);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(216, 207);
            this.btnService.TabIndex = 1;
            this.btnService.Text = "Service Request";
            this.btnService.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.Image = ((System.Drawing.Image)(resources.GetObject("btnVerify.Image")));
            this.btnVerify.Location = new System.Drawing.Point(54, 269);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(225, 207);
            this.btnVerify.TabIndex = 2;
            this.btnVerify.Text = "KENT Verify";
            this.btnVerify.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVerify.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.Location = new System.Drawing.Point(307, 269);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(225, 203);
            this.btnProducts.TabIndex = 3;
            this.btnProducts.Text = "My Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnBuyAMC
            // 
            this.btnBuyAMC.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyAMC.Image = ((System.Drawing.Image)(resources.GetObject("btnBuyAMC.Image")));
            this.btnBuyAMC.Location = new System.Drawing.Point(54, 482);
            this.btnBuyAMC.Name = "btnBuyAMC";
            this.btnBuyAMC.Size = new System.Drawing.Size(224, 205);
            this.btnBuyAMC.TabIndex = 4;
            this.btnBuyAMC.Text = "Buy AMC";
            this.btnBuyAMC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuyAMC.UseVisualStyleBackColor = true;
            // 
            // btnServiceHistory
            // 
            this.btnServiceHistory.Font = new System.Drawing.Font("Microsoft Tai Le", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnServiceHistory.Image")));
            this.btnServiceHistory.Location = new System.Drawing.Point(307, 482);
            this.btnServiceHistory.Name = "btnServiceHistory";
            this.btnServiceHistory.Size = new System.Drawing.Size(216, 205);
            this.btnServiceHistory.TabIndex = 5;
            this.btnServiceHistory.Text = "Service History";
            this.btnServiceHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnServiceHistory.UseVisualStyleBackColor = true;
            this.btnServiceHistory.Click += new System.EventHandler(this.btnServiceHistory_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(50, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(59, 19);
            this.lblText.TabIndex = 6;
            this.lblText.Text = "label1";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(50, 34);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(53, 19);
            this.lblWelcome.TabIndex = 7;
            this.lblWelcome.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(627, 715);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnServiceHistory);
            this.Controls.Add(this.btnBuyAMC);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.btnRequest);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnBuyAMC;
        private System.Windows.Forms.Button btnServiceHistory;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblWelcome;
    }
}