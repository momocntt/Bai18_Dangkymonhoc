namespace Bai18_Dangkymonhoc
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDk = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtMssv = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.cbxNienkhoa = new System.Windows.Forms.ComboBox();
            this.cbxLop = new System.Windows.Forms.ComboBox();
            this.radI = new System.Windows.Forms.RadioButton();
            this.radIi = new System.Windows.Forms.RadioButton();
            this.radIii = new System.Windows.Forms.RadioButton();
            this.radIv = new System.Windows.Forms.RadioButton();
            this.clbMonhoc = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng ký môn học ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "MSSV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ và tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Niên khóa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lớp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Học kỳ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 260);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Môn học";
            // 
            // btnDk
            // 
            this.btnDk.Location = new System.Drawing.Point(25, 369);
            this.btnDk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDk.Name = "btnDk";
            this.btnDk.Size = new System.Drawing.Size(148, 39);
            this.btnDk.TabIndex = 1;
            this.btnDk.Text = "Đăng ký";
            this.btnDk.UseVisualStyleBackColor = true;
            this.btnDk.Click += new System.EventHandler(this.btnDk_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(250, 369);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(148, 39);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(468, 369);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(148, 39);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtMssv
            // 
            this.txtMssv.Location = new System.Drawing.Point(116, 32);
            this.txtMssv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMssv.Name = "txtMssv";
            this.txtMssv.Size = new System.Drawing.Size(148, 22);
            this.txtMssv.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(116, 78);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(148, 22);
            this.txtTen.TabIndex = 2;
            // 
            // cbxNienkhoa
            // 
            this.cbxNienkhoa.FormattingEnabled = true;
            this.cbxNienkhoa.Location = new System.Drawing.Point(116, 116);
            this.cbxNienkhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxNienkhoa.Name = "cbxNienkhoa";
            this.cbxNienkhoa.Size = new System.Drawing.Size(180, 24);
            this.cbxNienkhoa.TabIndex = 3;
            // 
            // cbxLop
            // 
            this.cbxLop.FormattingEnabled = true;
            this.cbxLop.Location = new System.Drawing.Point(116, 156);
            this.cbxLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxLop.Name = "cbxLop";
            this.cbxLop.Size = new System.Drawing.Size(180, 24);
            this.cbxLop.TabIndex = 3;
            // 
            // radI
            // 
            this.radI.AutoSize = true;
            this.radI.Location = new System.Drawing.Point(116, 205);
            this.radI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radI.Name = "radI";
            this.radI.Size = new System.Drawing.Size(29, 20);
            this.radI.TabIndex = 4;
            this.radI.TabStop = true;
            this.radI.Text = "I";
            this.radI.UseVisualStyleBackColor = true;
            // 
            // radIi
            // 
            this.radIi.AutoSize = true;
            this.radIi.Location = new System.Drawing.Point(184, 205);
            this.radIi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radIi.Name = "radIi";
            this.radIi.Size = new System.Drawing.Size(33, 20);
            this.radIi.TabIndex = 4;
            this.radIi.TabStop = true;
            this.radIi.Text = "II";
            this.radIi.UseVisualStyleBackColor = true;
            // 
            // radIii
            // 
            this.radIii.AutoSize = true;
            this.radIii.Location = new System.Drawing.Point(271, 203);
            this.radIii.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radIii.Name = "radIii";
            this.radIii.Size = new System.Drawing.Size(37, 20);
            this.radIii.TabIndex = 4;
            this.radIii.TabStop = true;
            this.radIii.Text = "III";
            this.radIii.UseVisualStyleBackColor = true;
            // 
            // radIv
            // 
            this.radIv.AutoSize = true;
            this.radIv.Location = new System.Drawing.Point(340, 203);
            this.radIv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radIv.Name = "radIv";
            this.radIv.Size = new System.Drawing.Size(39, 20);
            this.radIv.TabIndex = 4;
            this.radIv.TabStop = true;
            this.radIv.Text = "IV";
            this.radIv.UseVisualStyleBackColor = true;
            // 
            // clbMonhoc
            // 
            this.clbMonhoc.FormattingEnabled = true;
            this.clbMonhoc.Location = new System.Drawing.Point(90, 243);
            this.clbMonhoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbMonhoc.Name = "clbMonhoc";
            this.clbMonhoc.Size = new System.Drawing.Size(535, 106);
            this.clbMonhoc.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 517);
            this.Controls.Add(this.clbMonhoc);
            this.Controls.Add(this.radIv);
            this.Controls.Add(this.radIii);
            this.Controls.Add(this.radIi);
            this.Controls.Add(this.radI);
            this.Controls.Add(this.cbxLop);
            this.Controls.Add(this.cbxNienkhoa);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMssv);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDk;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtMssv;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.ComboBox cbxNienkhoa;
        private System.Windows.Forms.ComboBox cbxLop;
        private System.Windows.Forms.RadioButton radI;
        private System.Windows.Forms.RadioButton radIi;
        private System.Windows.Forms.RadioButton radIii;
        private System.Windows.Forms.RadioButton radIv;
        private System.Windows.Forms.CheckedListBox clbMonhoc;
    }
}

