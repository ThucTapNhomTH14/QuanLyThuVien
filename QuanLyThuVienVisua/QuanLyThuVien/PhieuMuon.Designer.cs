namespace QuanLyThuVien
{
    partial class PhieuMuon
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
            this.txtDocGia_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocGia_ten = new System.Windows.Forms.TextBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã độc giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sách mượn";
            // 
            // txtDocGia_ID
            // 
            this.txtDocGia_ID.Location = new System.Drawing.Point(79, 39);
            this.txtDocGia_ID.Name = "txtDocGia_ID";
            this.txtDocGia_ID.Size = new System.Drawing.Size(149, 20);
            this.txtDocGia_ID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên độc giả";
            // 
            // txtDocGia_ten
            // 
            this.txtDocGia_ten.Location = new System.Drawing.Point(79, 81);
            this.txtDocGia_ten.Name = "txtDocGia_ten";
            this.txtDocGia_ten.Size = new System.Drawing.Size(226, 20);
            this.txtDocGia_ten.TabIndex = 4;
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(234, 37);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(71, 23);
            this.btn_check.TabIndex = 5;
            this.btn_check.Text = "Kiểm tra";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // PhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 332);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.txtDocGia_ten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDocGia_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PhieuMuon";
            this.Text = "PhieuMuon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocGia_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDocGia_ten;
        private System.Windows.Forms.Button btn_check;
    }
}