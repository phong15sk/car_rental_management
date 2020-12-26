namespace quản_lý_cho_thuê_xe
{
    partial class Form3OXeMay
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
            this.label6 = new System.Windows.Forms.Label();
            this.cmbphuongthucthue = new System.Windows.Forms.ComboBox();
            this.cmbLoaiXe = new System.Windows.Forms.ComboBox();
            this.txtmasoxe = new System.Windows.Forms.TextBox();
            this.txtsocmnd = new System.Windows.Forms.TextBox();
            this.txthovaten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnthuexe = new System.Windows.Forms.Button();
            this.lsvthuexemay = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thuê Xe Máy";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbphuongthucthue);
            this.groupBox1.Controls.Add(this.cmbLoaiXe);
            this.groupBox1.Controls.Add(this.txtmasoxe);
            this.groupBox1.Controls.Add(this.txtsocmnd);
            this.groupBox1.Controls.Add(this.txthovaten);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1053, 216);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(657, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phương Thức Thuê:";
            // 
            // cmbphuongthucthue
            // 
            this.cmbphuongthucthue.FormattingEnabled = true;
            this.cmbphuongthucthue.Location = new System.Drawing.Point(854, 127);
            this.cmbphuongthucthue.Name = "cmbphuongthucthue";
            this.cmbphuongthucthue.Size = new System.Drawing.Size(170, 32);
            this.cmbphuongthucthue.TabIndex = 9;
            // 
            // cmbLoaiXe
            // 
            this.cmbLoaiXe.FormattingEnabled = true;
            this.cmbLoaiXe.Location = new System.Drawing.Point(423, 127);
            this.cmbLoaiXe.Name = "cmbLoaiXe";
            this.cmbLoaiXe.Size = new System.Drawing.Size(219, 32);
            this.cmbLoaiXe.TabIndex = 8;
            this.cmbLoaiXe.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiXe_SelectedIndexChanged);
            // 
            // txtmasoxe
            // 
            this.txtmasoxe.Location = new System.Drawing.Point(146, 127);
            this.txtmasoxe.Name = "txtmasoxe";
            this.txtmasoxe.Size = new System.Drawing.Size(171, 32);
            this.txtmasoxe.TabIndex = 7;
            // 
            // txtsocmnd
            // 
            this.txtsocmnd.Location = new System.Drawing.Point(618, 48);
            this.txtsocmnd.Name = "txtsocmnd";
            this.txtsocmnd.Size = new System.Drawing.Size(281, 32);
            this.txtsocmnd.TabIndex = 5;
            // 
            // txthovaten
            // 
            this.txthovaten.Location = new System.Drawing.Point(146, 48);
            this.txthovaten.Name = "txthovaten";
            this.txthovaten.Size = new System.Drawing.Size(226, 32);
            this.txthovaten.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Loại Xe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số CMND/ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Số Xe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Và Tên:";
            // 
            // btnthuexe
            // 
            this.btnthuexe.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthuexe.Location = new System.Drawing.Point(339, 301);
            this.btnthuexe.Name = "btnthuexe";
            this.btnthuexe.Size = new System.Drawing.Size(348, 57);
            this.btnthuexe.TabIndex = 2;
            this.btnthuexe.Text = "Bắt Đầu Thuê";
            this.btnthuexe.UseVisualStyleBackColor = true;
            this.btnthuexe.Click += new System.EventHandler(this.btnthuexe_Click);
            // 
            // lsvthuexemay
            // 
            this.lsvthuexemay.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lsvthuexemay.FullRowSelect = true;
            this.lsvthuexemay.GridLines = true;
            this.lsvthuexemay.Location = new System.Drawing.Point(12, 364);
            this.lsvthuexemay.Name = "lsvthuexemay";
            this.lsvthuexemay.Size = new System.Drawing.Size(1066, 147);
            this.lsvthuexemay.TabIndex = 3;
            this.lsvthuexemay.UseCompatibleStateImageBehavior = false;
            this.lsvthuexemay.View = System.Windows.Forms.View.Details;
            this.lsvthuexemay.DoubleClick += new System.EventHandler(this.lsvthuexemay_DoubleClick);
            // 
            // Form3OXeMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 541);
            this.Controls.Add(this.lsvthuexemay);
            this.Controls.Add(this.btnthuexe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3OXeMay";
            this.Text = "Thuê Xe Máy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3OXeMay_FormClosing);
            this.Load += new System.EventHandler(this.Form3OXeMay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmasoxe;
        private System.Windows.Forms.TextBox txtsocmnd;
        private System.Windows.Forms.TextBox txthovaten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbphuongthucthue;
        private System.Windows.Forms.ComboBox cmbLoaiXe;
        private System.Windows.Forms.Button btnthuexe;
        private System.Windows.Forms.ListView lsvthuexemay;
    }
}