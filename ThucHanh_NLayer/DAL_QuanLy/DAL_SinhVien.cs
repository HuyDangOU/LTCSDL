using System;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_SinhVien : DBConnect
    {
        public DataTable getSinhVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SINHVIEN", conn);
            DataTable dtSinhvien = new DataTable();
            da.Fill(dtSinhvien);
            
            return dtSinhvien;
            
        }

        public bool themSinhVien(DTO_SinhVien sv)
        {
            try
            {
                
                conn.Open();
                string SQL = string.Format("INSERT INTO SINHVIEN(SV_NAME, SV_PHONE,SV_EMAIL) VALUES('{0}', '{1}', '{2}')", sv.SINHVIEN_NAME1, sv.SINHVIEN_PHONE1, sv.SINHVIEN_EMAIL1);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
            finally
            {
              
                conn.Close();
            }
            return false;
        }
        public bool suaSinhVien(DTO_SinhVien sv)
        {
            try
            {
                
                conn.Open();
                
                string SQL = string.Format("UPDATE SINHVIEN SET SV_NAME = '{0}',SV_PHONE = '{1}', SV_EMAIL = '{2}' WHERE SV_ID = '{3}'",sv.SINHVIEN_NAME1, sv.SINHVIEN_PHONE1, sv.SINHVIEN_EMAIL1, sv.SINHVIEN_ID1);
                SqlCommand cmd = new SqlCommand(SQL,conn);
                
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
            }
            finally
            {
               
               conn.Close();
            }
            return false;
        }
        public bool xoaSinhVien(int SV_ID)
        {
            try
            {
              
                conn.Open();
               
                string SQL = string.Format("DELETE FROM SINHVIEN WHERE SV_ID = {0}", SV_ID);
                
                SqlCommand cmd = new SqlCommand(SQL, conn);
               
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
            }
            finally
            {
                
               conn.Close();
            }
            return false;
        }
    }
}
