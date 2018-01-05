namespace wfaTestCsAES
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAES128 = new System.Windows.Forms.Button();
            this.btnAES256 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox1.Location = new System.Drawing.Point(572, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(632, 601);
            this.textBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAES256);
            this.panel1.Controls.Add(this.btnAES128);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 601);
            this.panel1.TabIndex = 1;
            // 
            // btnAES128
            // 
            this.btnAES128.Location = new System.Drawing.Point(50, 39);
            this.btnAES128.Name = "btnAES128";
            this.btnAES128.Size = new System.Drawing.Size(75, 23);
            this.btnAES128.TabIndex = 0;
            this.btnAES128.Text = "AES 128";
            this.btnAES128.UseVisualStyleBackColor = true;
            this.btnAES128.Click += new System.EventHandler(this.btnAES128_Click);
            // 
            // btnAES256
            // 
            this.btnAES256.Location = new System.Drawing.Point(50, 82);
            this.btnAES256.Name = "btnAES256";
            this.btnAES256.Size = new System.Drawing.Size(75, 23);
            this.btnAES256.TabIndex = 1;
            this.btnAES256.Text = "AES 256";
            this.btnAES256.UseVisualStyleBackColor = true;
            this.btnAES256.Click += new System.EventHandler(this.btnAES256_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 601);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAES256;
        private System.Windows.Forms.Button btnAES128;
    }
}

