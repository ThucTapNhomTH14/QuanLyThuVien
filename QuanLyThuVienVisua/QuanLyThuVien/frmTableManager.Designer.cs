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
            this.thêmSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaThôngTinSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemDanhSáchSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýĐộcGiảToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemDanhSáchĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mượnTrảSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpPhiếuMượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trảSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Book = new System.Windows.Forms.DataGridView();
            this.DauSach_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sach_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sach_conlai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchBook = new System.Windows.Forms.TextBox();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.btnSearchReader = new System.Windows.Forms.Button();
            this.dgv_Reader = new System.Windows.Forms.DataGridView();
            this.txtSearchReader = new System.Windows.Forms.TextBox();
            this.cậpNhậtDanhSáchĐộcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reader)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýHệThốngToolStripMenuItem,
            this.quảnLýĐộcGiảToolStripMenuItem1,
            this.mượnTrảSáchToolStripMenuItem,
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
            this.xemDanhSáchSáchToolStripMenuItem,
            this.cậpNhậtSáchToolStripMenuItem,
            this.thêmSáchToolStripMenuItem,
            this.sửaThôngTinSáchToolStripMenuItem,
            this.xóaSáchToolStripMenuItem});
            this.quảnLýHệThốngToolStripMenuItem.Name = "quảnLýHệThốngToolStripMenuItem";
            this.quảnLýHệThốngToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.quảnLýHệThốngToolStripMenuItem.Text = "Quản lý hệ thống";
            this.quảnLýHệThốngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýHệThốngToolStripMenuItem_Click);
            // 
            // cậpNhậtSáchToolStripMenuItem
            // 
            this.cậpNhậtSáchToolStripMenuItem.Name = "cậpNhậtSáchToolStripMenuItem";
            this.cậpNhậtSáchToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cậpNhậtSáchToolStripMenuItem.Text = "Cập nhật sách";
            this.cậpNhậtSáchToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtSáchToolStripMenuItem_Click);
            // 
            // thêmSáchToolStripMenuItem
            // 
            this.thêmSáchToolStripMenuItem.Name = "thêmSáchToolStripMenuItem";
            this.thêmSáchToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.thêmSáchToolStripMenuItem.Text = "Thêm sách";
            // 
            // sửaThôngTinSáchToolStripMenuItem
            // 
            this.sửaThôngTinSáchToolStripMenuItem.Name = "sửaThôngTinSáchToolStripMenuItem";
            this.sửaThôngTinSáchToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.sửaThôngTinSáchToolStripMenuItem.Text = "Sửa thông tin sách";
            // 
            // xóaSáchToolStripMenuItem
            // 
            this.xóaSáchToolStripMenuItem.Name = "xóaSáchToolStripMenuItem";
            this.xóaSáchToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.xóaSáchToolStripMenuItem.Text = "Xóa sách";
            // 
            // xemDanhSáchSáchToolStripMenuItem
            // 
            this.xemDanhSáchSáchToolStripMenuItem.Name = "xemDanhSáchSáchToolStripMenuItem";
            this.xemDanhSáchSáchToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.xemDanhSáchSáchToolStripMenuItem.Text = "Xem danh mục sách";
            this.xemDanhSáchSáchToolStripMenuItem.Click += new System.EventHandler(this.xemDanhSáchSáchToolStripMenuItem_Click);
            // 
            // quảnLýĐộcGiảToolStripMenuItem1
            // 
            this.quảnLýĐộcGiảToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemDanhSáchĐộcGiảToolStripMenuItem,
            this.cậpNhậtDanhSáchĐộcGiảToolStripMenuItem,
            this.thêmĐộcGiảToolStripMenuItem,
            this.xóaĐộcGiảToolStripMenuItem});
            this.quảnLýĐộcGiảToolStripMenuItem1.Name = "quảnLýĐộcGiảToolStripMenuItem1";
            this.quảnLýĐộcGiảToolStripMenuItem1.Size = new System.Drawing.Size(102, 20);
            this.quảnLýĐộcGiảToolStripMenuItem1.Text = "Quản lý độc giả";
            // 
            // thêmĐộcGiảToolStripMenuItem
            // 
            this.thêmĐộcGiảToolStripMenuItem.Name = "thêmĐộcGiảToolStripMenuItem";
            this.thêmĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.thêmĐộcGiảToolStripMenuItem.Text = "Thêm độc giả";
            this.thêmĐộcGiảToolStripMenuItem.Click += new System.EventHandler(this.thêmĐộcGiảToolStripMenuItem_Click);
            // 
            // xóaĐộcGiảToolStripMenuItem
            // 
            this.xóaĐộcGiảToolStripMenuItem.Name = "xóaĐộcGiảToolStripMenuItem";
            this.xóaĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.xóaĐộcGiảToolStripMenuItem.Text = "Xóa độc giả";
            this.xóaĐộcGiảToolStripMenuItem.Click += new System.EventHandler(this.xóaĐộcGiảToolStripMenuItem_Click);
            // 
            // xemDanhSáchĐộcGiảToolStripMenuItem
            // 
            this.xemDanhSáchĐộcGiảToolStripMenuItem.Name = "xemDanhSáchĐộcGiảToolStripMenuItem";
            this.xemDanhSáchĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.xemDanhSáchĐộcGiảToolStripMenuItem.Text = "Xem danh sách độc giả";
            this.xemDanhSáchĐộcGiảToolStripMenuItem.Click += new System.EventHandler(this.xemDanhSáchĐộcGiảToolStripMenuItem_Click);
            // 
            // mượnTrảSáchToolStripMenuItem
            // 
            this.mượnTrảSáchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lậpPhiếuMượnToolStripMenuItem,
            this.trảSáchToolStripMenuItem});
            this.mượnTrảSáchToolStripMenuItem.Name = "mượnTrảSáchToolStripMenuItem";
            this.mượnTrảSáchToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.mượnTrảSáchToolStripMenuItem.Text = "Mượn/Trả sách";
            // 
            // lậpPhiếuMượnToolStripMenuItem
            // 
            this.lậpPhiếuMượnToolStripMenuItem.Name = "lậpPhiếuMượnToolStripMenuItem";
            this.lậpPhiếuMượnToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.lậpPhiếuMượnToolStripMenuItem.Text = "Lập phiếu mượn";
            // 
            // trảSáchToolStripMenuItem
            // 
            this.trảSáchToolStripMenuItem.Name = "trảSáchToolStripMenuItem";
            this.trảSáchToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.trảSáchToolStripMenuItem.Text = "Trả sách";
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
            this.label1.Text = "Quản lý sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_Book
            // 
            this.dgv_Book.AllowUserToAddRows = false;
            this.dgv_Book.AllowUserToDeleteRows = false;
            this.dgv_Book.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Book.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Book.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DauSach_ID,
            this.Sach_ten,
            this.TacGia_ten,
            this.sach_conlai});
            this.dgv_Book.Location = new System.Drawing.Point(13, 118);
            this.dgv_Book.Name = "dgv_Book";
            this.dgv_Book.ReadOnly = true;
            this.dgv_Book.RowHeadersVisible = false;
            this.dgv_Book.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Book.Size = new System.Drawing.Size(538, 192);
            this.dgv_Book.TabIndex = 2;
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
            this.sach_conlai.DataPropertyName = "SL";
            this.sach_conlai.HeaderText = "Số lượng còn lại";
            this.sach_conlai.Name = "sach_conlai";
            this.sach_conlai.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm kiếm";
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.Location = new System.Drawing.Point(65, 84);
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(405, 20);
            this.txtSearchBook.TabIndex = 4;
            this.txtSearchBook.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchBook_KeyPress);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.Location = new System.Drawing.Point(476, 82);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(75, 23);
            this.btnSearchBook.TabIndex = 5;
            this.btnSearchBook.Text = "Tìm";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // btnSearchReader
            // 
            this.btnSearchReader.Location = new System.Drawing.Point(476, 82);
            this.btnSearchReader.Name = "btnSearchReader";
            this.btnSearchReader.Size = new System.Drawing.Size(75, 23);
            this.btnSearchReader.TabIndex = 1;
            this.btnSearchReader.Text = "Tìm";
            this.btnSearchReader.UseVisualStyleBackColor = true;
            this.btnSearchReader.Click += new System.EventHandler(this.btnSearchReader_Click);
            // 
            // dgv_Reader
            // 
            this.dgv_Reader.AllowUserToAddRows = false;
            this.dgv_Reader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Reader.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Reader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Reader.Location = new System.Drawing.Point(13, 118);
            this.dgv_Reader.Name = "dgv_Reader";
            this.dgv_Reader.RowHeadersVisible = false;
            this.dgv_Reader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Reader.Size = new System.Drawing.Size(538, 193);
            this.dgv_Reader.TabIndex = 7;
            // 
            // txtSearchReader
            // 
            this.txtSearchReader.Location = new System.Drawing.Point(65, 84);
            this.txtSearchReader.Name = "txtSearchReader";
            this.txtSearchReader.Size = new System.Drawing.Size(405, 20);
            this.txtSearchReader.TabIndex = 6;
            // 
            // cậpNhậtDanhSáchĐộcGiảToolStripMenuItem
            // 
            this.cậpNhậtDanhSáchĐộcGiảToolStripMenuItem.Name = "cậpNhậtDanhSáchĐộcGiảToolStripMenuItem";
            this.cậpNhậtDanhSáchĐộcGiảToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.cậpNhậtDanhSáchĐộcGiảToolStripMenuItem.Text = "Cập nhật danh sách độc giả";
            this.cậpNhậtDanhSáchĐộcGiảToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtDanhSáchĐộcGiảToolStripMenuItem_Click);
            // 
            // frmTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 322);
            this.Controls.Add(this.dgv_Reader);
            this.Controls.Add(this.txtSearchReader);
            this.Controls.Add(this.btnSearchReader);
            this.Controls.Add(this.btnSearchBook);
            this.Controls.Add(this.txtSearchBook);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_Book);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTableManager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reader)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn DauSach_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sach_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn sach_conlai;
        private System.Windows.Forms.ToolStripMenuItem mượnTrảSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpPhiếuMượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trảSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýĐộcGiảToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thêmĐộcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaĐộcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemDanhSáchĐộcGiảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaThôngTinSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaSáchToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchBook;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.ToolStripMenuItem xemDanhSáchSáchToolStripMenuItem;
        private System.Windows.Forms.Button btnSearchReader;
        private System.Windows.Forms.DataGridView dgv_Reader;
        private System.Windows.Forms.TextBox txtSearchReader;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtDanhSáchĐộcGiảToolStripMenuItem;
    }
}