using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
   public class DTO_SinhVien
    {
        private int SINHVIEN_ID;
        private String SINHVIEN_NAME;
        private String SINHVIEN_EMAIL;
        private String SINHVIEN_PHONE;

        public DTO_SinhVien(int sINHVIEN_ID, string sINHVIEN_NAME, string sINHVIEN_EMAIL, string sINHVIEN_PHONE)
        {
            SINHVIEN_ID = sINHVIEN_ID;
            SINHVIEN_NAME = sINHVIEN_NAME;
            SINHVIEN_EMAIL = sINHVIEN_EMAIL;
            SINHVIEN_PHONE = sINHVIEN_PHONE;
        }

        public int SINHVIEN_ID1 { get => SINHVIEN_ID; set => SINHVIEN_ID = value; }
        public string SINHVIEN_NAME1 { get => SINHVIEN_NAME; set => SINHVIEN_NAME = value; }
        public string SINHVIEN_EMAIL1 { get => SINHVIEN_EMAIL; set => SINHVIEN_EMAIL = value; }
        public string SINHVIEN_PHONE1 { get => SINHVIEN_PHONE; set => SINHVIEN_PHONE = value; }
    }
}
