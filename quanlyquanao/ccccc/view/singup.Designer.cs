namespace ccccc.view
{
    partial class singup
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbt_matkhau = new System.Windows.Forms.TextBox();
            this.tbt_taikhoan = new System.Windows.Forms.TextBox();
            this.btn_dangky = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(229, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "mat khau ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(229, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "tai khoan ";
            // 
            // tbt_matkhau
            // 
            this.tbt_matkhau.Location = new System.Drawing.Point(231, 191);
            this.tbt_matkhau.Name = "tbt_matkhau";
            this.tbt_matkhau.Size = new System.Drawing.Size(340, 27);
            this.tbt_matkhau.TabIndex = 9;
            // 
            // tbt_taikhoan
            // 
            this.tbt_taikhoan.Location = new System.Drawing.Point(231, 114);
            this.tbt_taikhoan.Name = "tbt_taikhoan";
            this.tbt_taikhoan.Size = new System.Drawing.Size(340, 27);
            this.tbt_taikhoan.TabIndex = 8;
            // 
            // btn_dangky
            // 
            this.btn_dangky.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_dangky.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_dangky.Location = new System.Drawing.Point(229, 267);
            this.btn_dangky.Name = "btn_dangky";
            this.btn_dangky.Size = new System.Drawing.Size(340, 48);
            this.btn_dangky.TabIndex = 7;
            this.btn_dangky.Text = "dang ky";
            this.btn_dangky.UseVisualStyleBackColor = false;
            this.btn_dangky.Click += new System.EventHandler(this.btn_dangky_Click);
            // 
            // singup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(921, 573);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbt_matkhau);
            this.Controls.Add(this.tbt_taikhoan);
            this.Controls.Add(this.btn_dangky);
            this.Name = "singup";
            this.Text = "singup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox tbt_matkhau;
        private TextBox tbt_taikhoan;
        private Button btn_dangky;
    }
}