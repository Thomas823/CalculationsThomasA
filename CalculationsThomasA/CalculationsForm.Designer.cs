namespace CalculationsThomasA
{
    partial class frmCalculations
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
            this.btnQuestion1 = new System.Windows.Forms.Button();
            this.btnQuestion2 = new System.Windows.Forms.Button();
            this.btnQuestion3 = new System.Windows.Forms.Button();
            this.btnQuestion4 = new System.Windows.Forms.Button();
            this.lblAnswer1 = new System.Windows.Forms.Label();
            this.lblAnswer2 = new System.Windows.Forms.Label();
            this.lblAnswer3 = new System.Windows.Forms.Label();
            this.lblAnswer4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuestion1
            // 
            this.btnQuestion1.Location = new System.Drawing.Point(47, 32);
            this.btnQuestion1.Name = "btnQuestion1";
            this.btnQuestion1.Size = new System.Drawing.Size(75, 23);
            this.btnQuestion1.TabIndex = 0;
            this.btnQuestion1.Text = "5 + 2^3 =";
            this.btnQuestion1.UseVisualStyleBackColor = true;
            this.btnQuestion1.Click += new System.EventHandler(this.btnQuestion1_Click);
            // 
            // btnQuestion2
            // 
            this.btnQuestion2.Location = new System.Drawing.Point(47, 90);
            this.btnQuestion2.Name = "btnQuestion2";
            this.btnQuestion2.Size = new System.Drawing.Size(75, 23);
            this.btnQuestion2.TabIndex = 1;
            this.btnQuestion2.Text = "4 / 2 + 5 =";
            this.btnQuestion2.UseVisualStyleBackColor = true;
            this.btnQuestion2.Click += new System.EventHandler(this.btnQuestion2_Click);
            // 
            // btnQuestion3
            // 
            this.btnQuestion3.Location = new System.Drawing.Point(47, 152);
            this.btnQuestion3.Name = "btnQuestion3";
            this.btnQuestion3.Size = new System.Drawing.Size(75, 23);
            this.btnQuestion3.TabIndex = 2;
            this.btnQuestion3.Text = "3 + 4 * 2 =";
            this.btnQuestion3.UseVisualStyleBackColor = true;
            this.btnQuestion3.Click += new System.EventHandler(this.btnQuestion3_Click);
            // 
            // btnQuestion4
            // 
            this.btnQuestion4.Location = new System.Drawing.Point(47, 212);
            this.btnQuestion4.Name = "btnQuestion4";
            this.btnQuestion4.Size = new System.Drawing.Size(75, 23);
            this.btnQuestion4.TabIndex = 3;
            this.btnQuestion4.Text = "7 - 3 + 2 =";
            this.btnQuestion4.UseVisualStyleBackColor = true;
            this.btnQuestion4.Click += new System.EventHandler(this.btnQuestion4_Click);
            // 
            // lblAnswer1
            // 
            this.lblAnswer1.AutoSize = true;
            this.lblAnswer1.Location = new System.Drawing.Point(175, 37);
            this.lblAnswer1.Name = "lblAnswer1";
            this.lblAnswer1.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer1.TabIndex = 4;
            // 
            // lblAnswer2
            // 
            this.lblAnswer2.AutoSize = true;
            this.lblAnswer2.Location = new System.Drawing.Point(175, 100);
            this.lblAnswer2.Name = "lblAnswer2";
            this.lblAnswer2.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer2.TabIndex = 5;
            // 
            // lblAnswer3
            // 
            this.lblAnswer3.AutoSize = true;
            this.lblAnswer3.Location = new System.Drawing.Point(175, 157);
            this.lblAnswer3.Name = "lblAnswer3";
            this.lblAnswer3.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer3.TabIndex = 6;
            // 
            // lblAnswer4
            // 
            this.lblAnswer4.AutoSize = true;
            this.lblAnswer4.Location = new System.Drawing.Point(175, 217);
            this.lblAnswer4.Name = "lblAnswer4";
            this.lblAnswer4.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer4.TabIndex = 7;
            // 
            // frmCalculations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblAnswer4);
            this.Controls.Add(this.lblAnswer3);
            this.Controls.Add(this.lblAnswer2);
            this.Controls.Add(this.lblAnswer1);
            this.Controls.Add(this.btnQuestion4);
            this.Controls.Add(this.btnQuestion3);
            this.Controls.Add(this.btnQuestion2);
            this.Controls.Add(this.btnQuestion1);
            this.Name = "frmCalculations";
            this.Text = "Calculations By Thomas Aubin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuestion1;
        private System.Windows.Forms.Button btnQuestion2;
        private System.Windows.Forms.Button btnQuestion3;
        private System.Windows.Forms.Button btnQuestion4;
        private System.Windows.Forms.Label lblAnswer1;
        private System.Windows.Forms.Label lblAnswer2;
        private System.Windows.Forms.Label lblAnswer3;
        private System.Windows.Forms.Label lblAnswer4;
    }
}

