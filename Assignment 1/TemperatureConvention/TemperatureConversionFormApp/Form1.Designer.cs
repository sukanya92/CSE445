namespace TemperatureConversionFormApp
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
            this.labelCtoF = new System.Windows.Forms.Label();
            this.txtInputC = new System.Windows.Forms.TextBox();
            this.labelResultF = new System.Windows.Forms.Label();
            this.btnC2F = new System.Windows.Forms.Button();
            this.btnF2C = new System.Windows.Forms.Button();
            this.labelResultC = new System.Windows.Forms.Label();
            this.txtInputF = new System.Windows.Forms.TextBox();
            this.labelF2C = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCtoF
            // 
            this.labelCtoF.AutoSize = true;
            this.labelCtoF.Location = new System.Drawing.Point(62, 78);
            this.labelCtoF.Name = "labelCtoF";
            this.labelCtoF.Size = new System.Drawing.Size(287, 20);
            this.labelCtoF.TabIndex = 0;
            this.labelCtoF.Text = "Please enter the temperature in Celsius";
            // 
            // txtInputC
            // 
            this.txtInputC.Location = new System.Drawing.Point(399, 75);
            this.txtInputC.Name = "txtInputC";
            this.txtInputC.Size = new System.Drawing.Size(47, 26);
            this.txtInputC.TabIndex = 1;
            // 
            // labelResultF
            // 
            this.labelResultF.AutoSize = true;
            this.labelResultF.Location = new System.Drawing.Point(405, 137);
            this.labelResultF.Name = "labelResultF";
            this.labelResultF.Size = new System.Drawing.Size(130, 20);
            this.labelResultF.TabIndex = 2;
            this.labelResultF.Text = "Shows result in F";
            this.labelResultF.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnC2F
            // 
            this.btnC2F.Location = new System.Drawing.Point(66, 125);
            this.btnC2F.Name = "btnC2F";
            this.btnC2F.Size = new System.Drawing.Size(75, 32);
            this.btnC2F.TabIndex = 3;
            this.btnC2F.Text = "C2F";
            this.btnC2F.UseVisualStyleBackColor = true;
            this.btnC2F.Click += new System.EventHandler(this.btnC2F_Click);
            // 
            // btnF2C
            // 
            this.btnF2C.Location = new System.Drawing.Point(66, 303);
            this.btnF2C.Name = "btnF2C";
            this.btnF2C.Size = new System.Drawing.Size(75, 32);
            this.btnF2C.TabIndex = 7;
            this.btnF2C.Text = "F2C";
            this.btnF2C.UseVisualStyleBackColor = true;
            this.btnF2C.Click += new System.EventHandler(this.btnF2C_Click);
            // 
            // labelResultC
            // 
            this.labelResultC.AutoSize = true;
            this.labelResultC.Location = new System.Drawing.Point(405, 317);
            this.labelResultC.Name = "labelResultC";
            this.labelResultC.Size = new System.Drawing.Size(131, 20);
            this.labelResultC.TabIndex = 6;
            this.labelResultC.Text = "Shows result in C";
            // 
            // txtInputF
            // 
            this.txtInputF.Location = new System.Drawing.Point(399, 255);
            this.txtInputF.Name = "txtInputF";
            this.txtInputF.Size = new System.Drawing.Size(47, 26);
            this.txtInputF.TabIndex = 5;
            // 
            // labelF2C
            // 
            this.labelF2C.AutoSize = true;
            this.labelF2C.Location = new System.Drawing.Point(62, 258);
            this.labelF2C.Name = "labelF2C";
            this.labelF2C.Size = new System.Drawing.Size(304, 20);
            this.labelF2C.TabIndex = 4;
            this.labelF2C.Text = "Please enter the temperature in Farenheit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 445);
            this.Controls.Add(this.btnF2C);
            this.Controls.Add(this.labelResultC);
            this.Controls.Add(this.txtInputF);
            this.Controls.Add(this.labelF2C);
            this.Controls.Add(this.btnC2F);
            this.Controls.Add(this.labelResultF);
            this.Controls.Add(this.txtInputC);
            this.Controls.Add(this.labelCtoF);
            this.Name = "Form1";
            this.Text = "Sukanya_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCtoF;
        private System.Windows.Forms.TextBox txtInputC;
        private System.Windows.Forms.Label labelResultF;
        private System.Windows.Forms.Button btnC2F;
        private System.Windows.Forms.Button btnF2C;
        private System.Windows.Forms.Label labelResultC;
        private System.Windows.Forms.TextBox txtInputF;
        private System.Windows.Forms.Label labelF2C;
    }
}

