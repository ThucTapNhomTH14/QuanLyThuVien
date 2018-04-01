namespace QuanLyThuVien
{
    partial class frmTableManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýHệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMượnTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DauSach_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sach_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sach_conlai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýHệThốngToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(567, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýHệThốngToolStripMenuItem
            // 
            this.quảnLýHệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtSáchToolStripMenuItem,
            this.quảnLýĐộcGiảToolStripMenuItem,
            this.quảnLýMượnTrảToolStripMenuItem});
            this.quảnLýHệThốngToolStripMenuItem.Name = "quảnLýHệThốngToolStripMenuItem";
            this.quảnLýHệThốngToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.quảnLýHệThốngToolStripMenuItem.Text = "Quản lý hệ thống";
            this.quảnLýHệThốngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHệThốngToolStripMenuItem_Click);
            // 
            // cậpNhậtSáchToolStripMenuItem
            // 
            this.cậpNhậtSáchToolStripMenuItem.Name = "cậpNhậtSáchToolStripMenuItem";
            this.cậpNhậtSáchToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.cậpNhậtSáchToolStripMenuItem.Text = "Cập nhật sách";
            this.cậpNhậtSáchToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtSáchToolStripMenuItem_Click);
            // 
            // quảnLýĐộcGiảToolStripMenuItem
            // 
            this.quảnLýĐộcGiảToolStripMenuItem.Name = "quảnLýĐộcGiảToolStripMenuItem";
            this.quảnLýĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.quảnLýĐộcGiảToolStripMenuItem.Text = "Quản lý độc giả";
            // 
            // quảnLýMượnTrảToolStripMenuItem
            // 
            this.quảnLýMượnTrảToolStripMenuItem.Name = "quảnLýMượnTrảToolStripMenuItem";
            this.quảnLýMượnTrảToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.quảnLýMượnTrảToolStripMenuItem.Text = "Quản lý mượn trả";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinTàiKhoảnCáNhânToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnCáNhânToolStripMenuItem.Name = "thôngTinTàiKhoảnCáNhânToolStripMenuItem";
            this.thôngTinTàiKhoảnCáNhânToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.thôngTinTàiKhoảnCáNhânToolStripMenuItem.Text = "Thông tin tài khoản cá nhân";
            this.thôngTinTàiKhoảnCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 42);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý thư viện";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DauSach_ID,
            this.Sach_ten,
            this.TacGia_ten,
            this.sach_conlai});
            this.dataGridView1.Location = new System.Drawing.Point(13, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(538, 234);
            this.dataGridView1.TabIndex = 2;
            // 
            // DauSach_ID
            // 
            this.DauSach_ID.DataPropertyName = "DauSach_ID";
            this.DauSach_ID.FillWeight = 197.9695F;
            this.DauSach_ID.HeaderText = "Mã sách";
            this.DauSach_ID.Name = "DauSach_ID";
            this.DauSach_ID.ReadOnly = true;
            // 
            // Sach_ten
            // 
            this.Sach_ten.DataPropertyName = "Sach_ten";
            this.Sach_ten.FillWeight = 51.01523F;
            this.Sach_ten.HeaderText = "Tên sách";
            this.Sach_ten.Name = "Sach_ten";
            this.Sach_ten.ReadOnly = true;
            // 
            // TacGia_ten
            // 
            this.TacGia_ten.DataPropertyName = "TacGia_ten";
            this.TacGia_ten.FillWeight = 51.01523F;
            this.TacGia_ten.HeaderText = "Tác giả";
            this.TacGia_ten.Name = "TacGia_ten";
            this.TacGia_ten.ReadOnly = true;
            // 
            // sach_conlai
            // 
            this.sach_conlai.HeaderText = "Số lượng còn lại";
            this.sach_conlai.Name = "sach_conlai";
            this.sach_conlai.ReadOnly = true;
            // 
            // frmTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 322);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTableManager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐộcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMượnTrảToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DauSach_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sach_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn sach_conlai;
    }
}