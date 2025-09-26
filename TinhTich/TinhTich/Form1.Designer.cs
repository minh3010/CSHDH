namespace TinhTich
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtThreads = new System.Windows.Forms.TextBox();
            this.btnCham = new System.Windows.Forms.Button();
            this.btnNhanh = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbKetqua = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số thread cần chạy :";
            // 
            // txtThreads
            // 
            this.txtThreads.Location = new System.Drawing.Point(186, 14);
            this.txtThreads.Name = "txtThreads";
            this.txtThreads.Size = new System.Drawing.Size(92, 22);
            this.txtThreads.TabIndex = 1;
            // 
            // btnCham
            // 
            this.btnCham.Location = new System.Drawing.Point(297, 14);
            this.btnCham.Name = "btnCham";
            this.btnCham.Size = new System.Drawing.Size(120, 21);
            this.btnCham.TabIndex = 2;
            this.btnCham.Text = "Ưu tiên thấp";
            this.btnCham.UseVisualStyleBackColor = true;
            this.btnCham.Click += new System.EventHandler(this.btnCham_Click);
            // 
            // btnNhanh
            // 
            this.btnNhanh.Location = new System.Drawing.Point(433, 14);
            this.btnNhanh.Name = "btnNhanh";
            this.btnNhanh.Size = new System.Drawing.Size(110, 21);
            this.btnNhanh.TabIndex = 3;
            this.btnNhanh.Text = "Ưu tiên cao";
            this.btnNhanh.UseVisualStyleBackColor = true;
            this.btnNhanh.Click += new System.EventHandler(this.btnNhanh_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(573, 14);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(159, 21);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Tính tích 2 ma trận";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbKetqua
            // 
            this.lbKetqua.FormattingEnabled = true;
            this.lbKetqua.ItemHeight = 16;
            this.lbKetqua.Location = new System.Drawing.Point(24, 42);
            this.lbKetqua.Name = "lbKetqua";
            this.lbKetqua.Size = new System.Drawing.Size(707, 356);
            this.lbKetqua.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbKetqua);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnNhanh);
            this.Controls.Add(this.btnCham);
            this.Controls.Add(this.txtThreads);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThreads;
        private System.Windows.Forms.Button btnCham;
        private System.Windows.Forms.Button btnNhanh;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lbKetqua;
    }
}

