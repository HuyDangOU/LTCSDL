using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DAL_QuanLy
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection("Server=833;Database=QLSinhVien;User Id=sa;Password=;");
    }
}
