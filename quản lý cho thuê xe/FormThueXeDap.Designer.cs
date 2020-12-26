namespace quản_lý_cho_thuê_xe
{
    partial class FormThueXeDap
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
            this.lblthuexe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnguoithue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsocmnd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmasoxe = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnauto = new System.Windows.Forms.Button();
            this.cmbphuongthucthue = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lsvthuexedap = new System.Windows.Forms.ListView();
            this.btnbatdauthue = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblthuexe
            // 
            this.lblthuexe.AutoSize = true;
            this.lblthuexe.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthuexe.Location = new System.Drawing.Point(409, 27);
            this.lblthuexe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblthuexe.Name = "lblthuexe";
            this.lblthuexe.Size = new System.Drawing.Size(216, 40);
            this.lblthuexe.TabIndex = 0;
            this.lblthuexe.Text = "Thuê Xe Đạp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Người Thuê:";
            // 
            // txtnguoithue
            // 
            this.txtnguoithue.Location = new System.Drawing.Point(171, 47);
            this.txtnguoithue.Name = "txtnguoithue";
            this.txtnguoithue.Size = new System.Drawing.Size(275, 32);
            this.txtnguoithue.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(513, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số CMND/ID:";
            // 
            // txtsocmnd
            // 
            this.txtsocmnd.Location = new System.Drawing.Point(654, 47);
            this.txtsocmnd.Name = "txtsocmnd";
            this.txtsocmnd.Size = new System.Drawing.Size(275, 32);
            this.txtsocmnd.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã Số Xe:";
            // 
            // txtmasoxe
            // 
            this.txtmasoxe.Location = new System.Drawing.Point(186, 111);
            this.txtmasoxe.Name = "txtmasoxe";
            this.txtmasoxe.Size = new System.Drawing.Size(173, 32);
            this.txtmasoxe.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnauto);
            this.groupBox1.Controls.Add(this.cmbphuongthucthue);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmasoxe);
            this.groupBox1.Controls.Add(this.txtnguoithue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtsocmnd);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 192);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NHẬP THÔNG TIN";
            // 
            // btnauto
            // 
            this.btnauto.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnauto.Location = new System.Drawing.Point(365, 111);
            this.btnauto.Name = "btnauto";
            this.btnauto.Size = new System.Drawing.Size(59, 32);
            this.btnauto.TabIndex = 9;
            this.btnauto.Text = "Auto";
            this.btnauto.UseVisualStyleBackColor = true;
            this.btnauto.Click += new System.EventHandler(this.btnauto_Click);
            // 
            // cmbphuongthucthue
            // 
            this.cmbphuongthucthue.FormattingEnabled = true;
            this.cmbphuongthucthue.Location = new System.Drawing.Point(631, 111);
            this.cmbphuongthucthue.Name = "cmbphuongthucthue";
            this.cmbphuongthucthue.Size = new System.Drawing.Size(181, 32);
            this.cmbphuongthucthue.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(441, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phương Thức Thuê:";
            // 
            // lsvthuexedap
            // 
            this.lsvthuexedap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lsvthuexedap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvthuexedap.FullRowSelect = true;
            this.lsvthuexedap.GridLines = true;
            this.lsvthuexedap.Location = new System.Drawing.Point(12, 349);
            this.lsvthuexedap.Name = "lsvthuexedap";
            this.lsvthuexedap.Size = new System.Drawing.Size(960, 134);
            this.lsvthuexedap.TabIndex = 8;
            this.lsvthuexedap.UseCompatibleStateImageBehavior = false;
            this.lsvthuexedap.View = System.Windows.Forms.View.Details;
            this.lsvthuexedap.DoubleClick += new System.EventHandler(this.lsvthuexedap_DoubleClick);
            // 
            // btnbatdauthue
            // 
            this.btnbatdauthue.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbatdauthue.Location = new System.Drawing.Point(161, 285);
            this.btnbatdauthue.Name = "btnbatdauthue";
            this.btnbatdauthue.Size = new System.Drawing.Size(703, 58);
            this.btnbatdauthue.TabIndex = 9;
            this.btnbatdauthue.Text = "BẮT ĐẦU THUÊ";
            this.btnbatdauthue.UseVisualStyleBackColor = true;
            this.btnbatdauthue.Click += new System.EventHandler(this.btnbatdauthue_Click);
            // 
            // FormThueXeDap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 516);
            this.Controls.Add(this.btnbatdauthue);
            this.Controls.Add(this.lsvthuexedap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblthuexe);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormThueXeDap";
            this.Text = "Thuê Xe Đạp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormThueXeDap_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblthuexe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnguoithue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsocmnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmasoxe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbphuongthucthue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lsvthuexedap;
        private System.Windows.Forms.Button btnbatdauthue;
        private System.Windows.Forms.Button btnauto;
    }
}