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
    public partial class PhieuMuon : Form
    {
        public PhieuMuon()
        {
            InitializeComponent();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            string docgia_id = txtDocGia_ID.Text;
            string query = "select * from DocGia";
            int check = DataProvider.Instance.ExecuteNoneQuery(query);
            if (check != 1) {
                MessageBox.Show("Độc giả không tồn tại!");
            }
        }
    }
}
