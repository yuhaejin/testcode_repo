namespace test003
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
            this.lblTest = new System.Windows.Forms.Label();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.lblTest002 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(128, 83);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(62, 12);
            this.lblTest.TabIndex = 0;
            this.lblTest.Text = "Test!!!!!!!!";
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(142, 180);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(100, 21);
            this.txtTest.TabIndex = 1;
            // 
            // lblTest002
            // 
            this.lblTest002.AutoSize = true;
            this.lblTest002.Location = new System.Drawing.Point(83, 120);
            this.lblTest002.Name = "lblTest002";
            this.lblTest002.Size = new System.Drawing.Size(60, 12);
            this.lblTest002.TabIndex = 2;
            this.lblTest002.Text = "Test00002";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblTest002);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.lblTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Label lblTest002;
    }
}

