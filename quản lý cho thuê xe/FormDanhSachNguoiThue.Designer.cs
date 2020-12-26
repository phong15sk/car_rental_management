namespace quản_lý_cho_thuê_xe
{
    partial class FormDanhSachNguoiThue
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsvXeDap = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvXeMay = new System.Windows.Forms.ListView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnTiemKiem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Người Thuê";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsvXeDap);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1023, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xe Đạp";
            // 
            // lsvXeDap
            // 
            this.lsvXeDap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvXeDap.FullRowSelect = true;
            this.lsvXeDap.GridLines = true;
            this.lsvXeDap.Location = new System.Drawing.Point(19, 28);
            this.lsvXeDap.Name = "lsvXeDap";
            this.lsvXeDap.Size = new System.Drawing.Size(983, 168);
            this.lsvXeDap.TabIndex = 0;
            this.lsvXeDap.UseCompatibleStateImageBehavior = false;
            this.lsvXeDap.View = System.Windows.Forms.View.Details;
            this.lsvXeDap.SelectedIndexChanged += new System.EventHandler(this.lsvXeDap_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsvXeMay);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1076, 224);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xe Máy";
            // 
            // lsvXeMay
            // 
            this.lsvXeMay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvXeMay.FullRowSelect = true;
            this.lsvXeMay.GridLines = true;
            this.lsvXeMay.Location = new System.Drawing.Point(19, 28);
            this.lsvXeMay.Name = "lsvXeMay";
            this.lsvXeMay.Size = new System.Drawing.Size(1051, 186);
            this.lsvXeMay.TabIndex = 0;
            this.lsvXeMay.UseCompatibleStateImageBehavior = false;
            this.lsvXeMay.View = System.Windows.Forms.View.Details;
            this.lsvXeMay.SelectedIndexChanged += new System.EventHandler(this.lsvXeMay_SelectedIndexChanged);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(821, 48);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(244, 29);
            this.txtTimKiem.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::quản_lý_cho_thuê_xe.Properties.Resources.iconfinder_Money_Increase_379473__1_;
            this.pictureBox3.Location = new System.Drawing.Point(1094, 426);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(181, 90);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // btnTiemKiem
            // 
            this.btnTiemKiem.Image = global::quản_lý_cho_thuê_xe.Properties.Resources.iconfinder_kghostview_1325;
            this.btnTiemKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTiemKiem.Location = new System.Drawing.Point(694, 39);
            this.btnTiemKiem.Name = "btnTiemKiem";
            this.btnTiemKiem.Size = new System.Drawing.Size(121, 45);
            this.btnTiemKiem.TabIndex = 6;
            this.btnTiemKiem.Text = "Tiềm kiếm";
            this.btnTiemKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTiemKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTiemKiem.UseVisualStyleBackColor = true;
            this.btnTiemKiem.Click += new System.EventHandler(this.btnTiemKiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Image = global::quản_lý_cho_thuê_xe.Properties.Resources.iconfinder_check_1055094;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(1090, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thanh Toán    ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.Lime;
            this.btnThanhToan.Image = global::quản_lý_cho_thuê_xe.Properties.Resources.tải_xuống;
            this.btnThanhToan.Location = new System.Drawing.Point(1094, 134);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(181, 286);
            this.btnThanhToan.TabIndex = 5;
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::quản_lý_cho_thuê_xe.Properties.Resources.iconfinder_home_36507;
            this.button3.Location = new System.Drawing.Point(54, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 78);
            this.button3.TabIndex = 10;
            this.button3.Text = "HOME";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::quản_lý_cho_thuê_xe.Properties.Resources.iconfinder_options_36532;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(131, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 78);
            this.button4.TabIndex = 11;
            this.button4.Text = "TOOLS";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FormDanhSachNguoiThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 535);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnTiemKiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDanhSachNguoiThue";
            this.Text = "Danh Sách Người Thuê";
            this.Load += new System.EventHandler(this.FormDanhSachNguoiThue_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsvXeDap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lsvXeMay;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTiemKiem;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}