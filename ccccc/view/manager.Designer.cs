namespace ccccc.view
{
    partial class manager
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
            this.btn_ = new System.Windows.Forms.Button();
            this.dtg_show = new System.Windows.Forms.DataGridView();
            this.tbt_msp = new System.Windows.Forms.TextBox();
            this.tbt_name = new System.Windows.Forms.TextBox();
            this.tbt_price = new System.Windows.Forms.TextBox();
            this.tbt_amount = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_
            // 
            this.btn_.Location = new System.Drawing.Point(12, 68);
            this.btn_.Name = "btn_";
            this.btn_.Size = new System.Drawing.Size(240, 47);
            this.btn_.TabIndex = 0;
            this.btn_.Text = "hiển thị";
            this.btn_.UseVisualStyleBackColor = true;
            this.btn_.Click += new System.EventHandler(this.btn__Click);
            // 
            // dtg_show
            // 
            this.dtg_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_show.Location = new System.Drawing.Point(12, 169);
            this.dtg_show.Name = "dtg_show";
            this.dtg_show.RowHeadersWidth = 51;
            this.dtg_show.RowTemplate.Height = 29;
            this.dtg_show.Size = new System.Drawing.Size(682, 460);
            this.dtg_show.TabIndex = 1;
            this.dtg_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_show_CellClick);
            // 
            // tbt_msp
            // 
            this.tbt_msp.Location = new System.Drawing.Point(720, 169);
            this.tbt_msp.Name = "tbt_msp";
            this.tbt_msp.Size = new System.Drawing.Size(251, 27);
            this.tbt_msp.TabIndex = 2;
            // 
            // tbt_name
            // 
            this.tbt_name.Location = new System.Drawing.Point(720, 235);
            this.tbt_name.Name = "tbt_name";
            this.tbt_name.Size = new System.Drawing.Size(251, 27);
            this.tbt_name.TabIndex = 3;
            // 
            // tbt_price
            // 
            this.tbt_price.Location = new System.Drawing.Point(719, 305);
            this.tbt_price.Name = "tbt_price";
            this.tbt_price.Size = new System.Drawing.Size(251, 27);
            this.tbt_price.TabIndex = 4;
            // 
            // tbt_amount
            // 
            this.tbt_amount.Location = new System.Drawing.Point(719, 374);
            this.tbt_amount.Name = "tbt_amount";
            this.tbt_amount.Size = new System.Drawing.Size(251, 27);
            this.tbt_amount.TabIndex = 5;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(719, 495);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(252, 29);
            this.btn_them.TabIndex = 7;
            this.btn_them.Text = "Thêm ";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(718, 546);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(252, 29);
            this.btn_sua.TabIndex = 8;
            this.btn_sua.Text = "Sủa ";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(720, 600);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(251, 29);
            this.btn_Xoa.TabIndex = 9;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(720, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "mã Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(721, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(723, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "giá ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(720, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "số lượng";
            // 
            // manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 648);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.tbt_amount);
            this.Controls.Add(this.tbt_price);
            this.Controls.Add(this.tbt_name);
            this.Controls.Add(this.tbt_msp);
            this.Controls.Add(this.dtg_show);
            this.Controls.Add(this.btn_);
            this.Name = "manager";
            this.Text = "manager";
            this.Load += new System.EventHandler(this.manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_;
        private DataGridView dtg_show;
        private TextBox tbt_msp;
        private TextBox tbt_name;
        private TextBox tbt_price;
        private TextBox tbt_amount;
        private Button btn_them;
        private Button btn_sua;
        private Button btn_Xoa;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
    }
}