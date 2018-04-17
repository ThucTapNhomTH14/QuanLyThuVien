using QuanLyThuVien.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmTableManager : Form
    {
        private static string f_username;
        public void setUsername(string username)
        {
            f_username = username;
        }
        public frmTableManager()
        {
            InitializeComponent();
            ConfigDGV();
            xemDanhSáchSáchToolStripMenuItem_Click(this,null);
            Reload();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void thôngTinTàiKhoảnCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountProfile f = new frmAccountProfile(f_username);
            f.Show();
        }

        private void quảnLýHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Reload()
        {
            string query = "exec GetAllBook";
            dgv_Book.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        private void ConfigDGV()
        {
            dgv_Book.Columns[0].Width = 100;
            dgv_Book.Columns[2].Width = 150;
            dgv_Book.Columns[1].Width = 288;
        }

        private void cậpNhậtSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void thêmĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xemDanhSáchĐộcGiảToolStripMenuItem_Click(this, null);
            frmThemDocGia f = new frmThemDocGia();
            f.ShowDialog();
            xemDanhSáchĐộcGiảToolStripMenuItem_Click(this,null);
        }

        private void sửaThôngTinĐToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xóaĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selected_row = dgv_Reader.CurrentCell.RowIndex;
            string ID = dgv_Reader.Rows[selected_row].Cells[0].Value.ToString();
            
            using(SqlConnection connection = new SqlConnection(DataProvider.Instance.connectionSRT))
            {
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "exec XoaDocGia @ID";
                cmd.Parameters.Add("@ID", SqlDbType.VarChar, 20).Value = ID;

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            xemDanhSáchĐộcGiảToolStripMenuItem_Click(this, null);
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.connectionSRT))
            {
                SqlCommand cmd = connection.CreateCommand();

                cmd.CommandText = "exec TimKiemSach @string";
                cmd.Parameters.Add("@string", SqlDbType.NVarChar, 40).Value = txtSearchBook.Text;
                
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                dgv_Book.DataSource = data;

                connection.Close();
            }
        }

        private void txtSearchBook_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchBook_Click(this, null);
            }
        }

        private void xemDanhSáchĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Quản lý độc giả";
            cậpNhậtDanhSáchĐộcGiảToolStripMenuItem_Click(this, null);

            dgv_Book.Hide();
            txtSearchBook.Hide();
            btnSearchBook.Hide();

            dgv_Reader.Show();          
            txtSearchReader.Show();
            btnSearchReader.Show();
        }

        private void xemDanhSáchSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Quản lý sách";
            Reload();

            dgv_Book.Show();
            txtSearchBook.Show();
            btnSearchBook.Show();

            dgv_Reader.Hide();
            txtSearchReader.Hide();
            btnSearchReader.Hide();
        }

        private void btnSearchReader_Click(object sender, EventArgs e)
        {
            string query = "exec TimDocGia";
        }

        private void cậpNhậtDanhSáchĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string query = "exec getAllDocGia";
            dgv_Reader.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
