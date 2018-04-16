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
    public partial class frmThemDocGia : Form
    {
        public frmThemDocGia()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(DataProvider.Instance.connectionSRT))
            {
                SqlCommand cmd = connection.CreateCommand();
                
                cmd.CommandText = "exec ThemDocGia @ID, @ten, @birth";
                cmd.Parameters.Add("@ID", SqlDbType.VarChar, 20).Value = txtID.Text;
                cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 20).Value = txtTen.Text;
                cmd.Parameters.Add("@birth",SqlDbType.Date).Value = dateTimePicker1.Value.Date;

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
