namespace quản_lý_cho_thuê_xe
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
            this.label2 = new System.Windows.Forms.Label();
            this.btndoanhthu = new System.Windows.Forms.Button();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.btnthongtin = new System.Windows.Forms.Button();
            this.btndanhsach = new System.Windows.Forms.Button();
            this.btnthuexemay = new System.Windows.Forms.Button();
            this.btnthuexedap = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(428, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ CHO THUÊ XE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(608, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 54);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bé Truyền";
            // 
            // btndoanhthu
            // 
            this.btndoanhthu.Image = global::quản_lý_cho_thuê_xe.Properties.Resources.tải_xuống__3_;
            this.btndoanhthu.Location = new System.Drawing.Point(867, 340);
            this.btndoanhthu.Name = "btndoanhthu";
            this.btndoanhthu.Size = new System.Drawing.Size(269, 194);
            this.btndoanhthu.TabIndex = 7;
            this.btndoanhthu.Text = "Doanh Thu Của Công Ty";
            this.btndoanhthu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btndoanhthu.UseVisualStyleBackColor = true;
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Image = global::quản_lý_cho_thuê_xe.Properties.Resources.tải_xuống__1_1;
            this.btnthanhtoan.Location = new System.Drawing.Point(867, 79);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(269, 255);
            this.btnthanhtoan.TabIndex = 6;
            this.btnthanhtoan.Text = "Thanh Toán";
            this.btnthanhtoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnthanhtoan.UseVisualStyleBackColor = true;
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // btnthongtin
            // 
            this.btnthongtin.Image = global::quản_lý_cho_thuê_xe.Properties.Resources.iconfinder_info_1930258;
            this.btnthongtin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthongtin.Location = new System.Drawing.Point(521, 391);
            this.btnthongtin.Name = "btnthongtin";
            this.btnthongtin.Size = new System.Drawing.Size(257, 143);
            this.btnthongtin.TabIndex = 5;
            this.btnthongtin.Text = "Thông Tin Xe";
            this.btnthongtin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthongtin.UseVisualStyleBackColor = true;
            // 
            // btndanhsach
            // 
            this.btndanhsach.Image = global::quản_lý_cho_thuê_xe.Properties.Resources.iconfinder_icon_40_clipboard_list_315162;
            this.btndanhsach.Location = new System.Drawing.Point(521, 105);
            this.btndanhsach.Name = "btndanhsach";
            this.btndanhsach.Size = new System.Drawing.Size(257, 280);
            this.btndanhsach.TabIndex = 4;
            this.btndanhsach.Text = "Danh Sách Người Thuê";
            this.btndanhsach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btndanhsach.UseVisualStyleBackColor = true;
            this.btndanhsach.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnthuexemay
            // 
            this.btnthuexemay.Image = global::quản_lý_cho_thuê_xe.Properties.Resources.images1;
            this.btnthuexemay.Location = new System.Drawing.Point(106, 306);
            this.btnthuexemay.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnthuexemay.Name = "btnthuexemay";
            this.btnthuexemay.Size = new System.Drawing.Size(288, 228);
            this.btnthuexemay.TabIndex = 1;
            this.btnthuexemay.Text = "Thuê Xe Máy";
            this.btnthuexemay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnthuexemay.UseVisualStyleBackColor = true;
            this.btnthuexemay.Click += new System.EventHandler(this.btnXeMay_Click);
            // 
            // btnthuexedap
            // 
            this.btnthuexedap.BackColor = System.Drawing.SystemColors.Control;
            this.btnthuexedap.Image = global::quản_lý_cho_thuê_xe.Properties.Resources.tải_xuống__2_;
            this.btnthuexedap.Location = new System.Drawing.Point(106, 79);
            this.btnthuexedap.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnthuexedap.Name = "btnthuexedap";
            this.btnthuexedap.Size = new System.Drawing.Size(288, 217);
            this.btnthuexedap.TabIndex = 0;
            this.btnthuexedap.Text = "Thuê Xe Đạp";
            this.btnthuexedap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnthuexedap.UseVisualStyleBackColor = false;
            this.btnthuexedap.Click += new System.EventHandler(this.btnthuexedap_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::quản_lý_cho_thuê_xe.Properties.Resources.iconfinder_options_36532;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 567);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndoanhthu);
            this.Controls.Add(this.btnthanhtoan);
            this.Controls.Add(this.btnthongtin);
            this.Controls.Add(this.btndanhsach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnthuexemay);
            this.Controls.Add(this.btnthuexedap);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Quản lý cho thuê xe";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthuexedap;
        private System.Windows.Forms.Button btnthuexemay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndanhsach;
        private System.Windows.Forms.Button btnthongtin;
        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.Button btndoanhthu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

