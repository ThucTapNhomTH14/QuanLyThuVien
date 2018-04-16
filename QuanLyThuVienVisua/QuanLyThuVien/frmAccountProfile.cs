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
    public partial class frmAccountProfile : Form
    {
        public frmAccountProfile(string login_name)
        {
            User u = new User();
            u.Username = login_name;
            u.GetUserInfo();
            InitializeComponent(u.Id,u.Username);
        }
    }
}
