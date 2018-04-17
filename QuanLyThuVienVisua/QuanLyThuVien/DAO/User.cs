using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    public class User
    {
        private string id;
        private string username;
        private int type;

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public int Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        private void setUser(string id, string username, int type)
        {
            this.id = id;
            this.username = username;
            this.type = type;
        }

        public void GetUserInfo()
        {
            string lg = " where UserName="+"'"+this.username+"'";
            string query = "select * from Account" + lg;
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            string id = dt.Rows[0][0].ToString();
            string username = this.username;
            int type = int.Parse(dt.Rows[0][4].ToString());

            setUser(id, username, type);
        }
    }
}
