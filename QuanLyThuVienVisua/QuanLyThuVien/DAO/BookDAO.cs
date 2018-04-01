using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAO
{
    class BookDAO
    {
        private string sach_ma;
        private string sach_ten;
        private string sach_tacgia;
        private int sach_soluong_conlai;

        public string Sach_ma
        {
            get
            {
                return sach_ma;
            }

            set
            {
                sach_ma = value;
            }
        }

        public string Sach_ten
        {
            get
            {
                return sach_ten;
            }

            set
            {
                sach_ten = value;
            }
        }

        public string Sach_tacgia
        {
            get
            {
                return sach_tacgia;
            }

            set
            {
                sach_tacgia = value;
            }
        }

        public int Sach_soluong_conlai
        {
            get
            {
                return sach_soluong_conlai;
            }

            set
            {
                sach_soluong_conlai = value;
            }
        }
    }
}
