using QuanLyThuVien.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmTableManager : Form
    {
        public frmTableManager()
        {
            InitializeComponent();
            ConfigDGV();
            Reload();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinTàiKhoảnCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountProfile f = new frmAccountProfile();
            f.ShowDialog();
        }

        private void quảnLýHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Reload()
        {
            string query = "exec GetAllBook";
            dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
        private void ConfigDGV()
        {
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[1].Width = 288;
        }

        private void cậpNhậtSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
