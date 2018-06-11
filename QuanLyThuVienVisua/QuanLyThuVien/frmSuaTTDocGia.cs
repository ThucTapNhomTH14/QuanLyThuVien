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
    public partial class frmSuaTTDocGia : Form
    {
        private string ID;
        private string name;
        private DateTime birth;

        public frmSuaTTDocGia(string ID, string name, DateTime birth)
        {
            InitializeComponent();
            this.ID = ID;
            this.name = name;
            this.birth = birth;
            txtID.Text = ID;
            txtName.Text = name;
            dateTimePicker1.Value = birth;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            string connection = DataProvider.Instance.connectionSRT;
            string query = "exec updateTTDocGia @id,@name,@birth";

            using (SqlConnection con = new SqlConnection(connection))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = query;
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 20).Value = txtID.Text;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 40).Value = txtName.Text;
                cmd.Parameters.Add("@birth", SqlDbType.Date).Value = dateTimePicker1.Value;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            this.Close();
        }
    }
}
