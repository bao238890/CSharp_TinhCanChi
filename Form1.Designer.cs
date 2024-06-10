namespace CSharp_TinhCanChi
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
            this.btnTinh = new System.Windows.Forms.Button();
            this.lblNam = new System.Windows.Forms.Label();
            this.lblkq = new System.Windows.Forms.Label();
            this.txtDuonglich = new System.Windows.Forms.TextBox();
            this.txtAmlich = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(328, 64);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 0;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // lblNam
            // 
            this.lblNam.AutoSize = true;
            this.lblNam.Location = new System.Drawing.Point(86, 69);
            this.lblNam.Name = "lblNam";
            this.lblNam.Size = new System.Drawing.Size(29, 13);
            this.lblNam.TabIndex = 1;
            this.lblNam.Text = "Năm";
            // 
            // lblkq
            // 
            this.lblkq.AutoSize = true;
            this.lblkq.Location = new System.Drawing.Point(86, 103);
            this.lblkq.Name = "lblkq";
            this.lblkq.Size = new System.Drawing.Size(44, 13);
            this.lblkq.TabIndex = 2;
            this.lblkq.Text = "Kết quả";
            // 
            // txtDuonglich
            // 
            this.txtDuonglich.Location = new System.Drawing.Point(163, 66);
            this.txtDuonglich.Name = "txtDuonglich";
            this.txtDuonglich.Size = new System.Drawing.Size(100, 20);
            this.txtDuonglich.TabIndex = 3;
            // 
            // txtAmlich
            // 
            this.txtAmlich.Location = new System.Drawing.Point(163, 103);
            this.txtAmlich.Name = "txtAmlich";
            this.txtAmlich.Size = new System.Drawing.Size(100, 20);
            this.txtAmlich.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(482, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(224, 225);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtAmlich);
            this.Controls.Add(this.txtDuonglich);
            this.Controls.Add(this.lblkq);
            this.Controls.Add(this.lblNam);
            this.Controls.Add(this.btnTinh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label lblNam;
        private System.Windows.Forms.Label lblkq;
        private System.Windows.Forms.TextBox txtDuonglich;
        private System.Windows.Forms.TextBox txtAmlich;
        private System.Windows.Forms.ListBox listBox1;
    }
}

