namespace SukanyasBrowser
{
    partial class Form1
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnGO = new System.Windows.Forms.Button();
            this.btnGetQuote = new System.Windows.Forms.Button();
            this.lblQuoteInfo = new System.Windows.Forms.Label();
            this.txtInputQuote = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtInputEncrypt = new System.Windows.Forms.TextBox();
            this.lblEncryptedMsg = new System.Windows.Forms.Label();
            this.lblDecryptedMsg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(30, 48);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1686, 889);
            this.webBrowser1.TabIndex = 0;
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(5, 3);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(1461, 30);
            this.txtURL.TabIndex = 1;
            this.txtURL.Text = "http://";
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(1501, 3);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(58, 32);
            this.btnGO.TabIndex = 3;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // btnGetQuote
            // 
            this.btnGetQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetQuote.Location = new System.Drawing.Point(720, 800);
            this.btnGetQuote.Name = "btnGetQuote";
            this.btnGetQuote.Size = new System.Drawing.Size(104, 35);
            this.btnGetQuote.TabIndex = 10;
            this.btnGetQuote.Text = "Get Quote";
            this.btnGetQuote.UseVisualStyleBackColor = true;
            this.btnGetQuote.Click += new System.EventHandler(this.btnGetQuote_Click);
            // 
            // lblQuoteInfo
            // 
            this.lblQuoteInfo.AutoSize = true;
            this.lblQuoteInfo.Location = new System.Drawing.Point(1250, 804);
            this.lblQuoteInfo.Name = "lblQuoteInfo";
            this.lblQuoteInfo.Size = new System.Drawing.Size(18, 20);
            this.lblQuoteInfo.TabIndex = 12;
            this.lblQuoteInfo.Text = ">";
            // 
            // txtInputQuote
            // 
            this.txtInputQuote.Location = new System.Drawing.Point(845, 804);
            this.txtInputQuote.Name = "txtInputQuote";
            this.txtInputQuote.Size = new System.Drawing.Size(100, 26);
            this.txtInputQuote.TabIndex = 11;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(719, 851);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(104, 35);
            this.btnEncrypt.TabIndex = 13;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtInputEncrypt
            // 
            this.txtInputEncrypt.Location = new System.Drawing.Point(845, 855);
            this.txtInputEncrypt.Name = "txtInputEncrypt";
            this.txtInputEncrypt.Size = new System.Drawing.Size(201, 26);
            this.txtInputEncrypt.TabIndex = 14;
            // 
            // lblEncryptedMsg
            // 
            this.lblEncryptedMsg.AutoSize = true;
            this.lblEncryptedMsg.Location = new System.Drawing.Point(1250, 855);
            this.lblEncryptedMsg.Name = "lblEncryptedMsg";
            this.lblEncryptedMsg.Size = new System.Drawing.Size(18, 20);
            this.lblEncryptedMsg.TabIndex = 15;
            this.lblEncryptedMsg.Text = ">";
            // 
            // lblDecryptedMsg
            // 
            this.lblDecryptedMsg.AutoSize = true;
            this.lblDecryptedMsg.Location = new System.Drawing.Point(1250, 887);
            this.lblDecryptedMsg.Name = "lblDecryptedMsg";
            this.lblDecryptedMsg.Size = new System.Drawing.Size(18, 20);
            this.lblDecryptedMsg.TabIndex = 16;
            this.lblDecryptedMsg.Text = ">";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1064, 887);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Decrypted Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1064, 855);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Encrypted Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1064, 807);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Quote Details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1703, 949);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDecryptedMsg);
            this.Controls.Add(this.lblEncryptedMsg);
            this.Controls.Add(this.txtInputEncrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.lblQuoteInfo);
            this.Controls.Add(this.txtInputQuote);
            this.Controls.Add(this.btnGetQuote);
            this.Controls.Add(this.btnGO);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SukanyaBrowser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.Button btnGetQuote;
        private System.Windows.Forms.Label lblQuoteInfo;
        private System.Windows.Forms.TextBox txtInputQuote;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtInputEncrypt;
        private System.Windows.Forms.Label lblEncryptedMsg;
        private System.Windows.Forms.Label lblDecryptedMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

