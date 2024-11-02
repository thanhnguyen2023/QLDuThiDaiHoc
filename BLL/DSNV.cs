using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Models;
using DBConnect;
using System.Globalization;
using System.Security.Principal;
using System.Windows.Forms;
namespace BLL
{
    public class DSNV
    {
        public SinhVien sv;
        public List<NguyenVong> listNguyenVong;
        public List<DiemChuan> listDiemChuan;
        public DiemThi diemThi = new DiemThi();
        public Connection connect;
        public DSNV()
        {
            sv = new SinhVien();
            connect = new Connection();
            listNguyenVong = new List<NguyenVong>();
            listDiemChuan = new List<DiemChuan>();
        }
        //public void getNguyenVong()
        //{
        //    string query = "select nv.ThuTuNV, dc.MaNganh, dc.TenNganh, dc.TongDiem as DiemChuan,(dt.DiemToan + dt.DiemLy + dt.DiemHoa) as TongDiem from NguyenVong nv\r\njoin HoSoThiSinh hsts on hsts.SoBD = nv.SoBD\r\njoin DiemChuan dc on dc.MaNganh = nv.MaNganh\r\njoin DiemThi dt on hsts.SoBD = dt.SoBD\r\nwhere nv.SoBD = @SoBD";
        //    SqlParameter[] parameters =
        //    {
        //        new SqlParameter("@soBD", 1001)
        //    };

        //    SqlDataReader reader = connect.ExecuteReader(query, parameters);
        //    int k = 0;
        //    if (reader != null)
        //    {

        //        while (reader.Read())
        //        {

        //            listNguyenVong.Add(new NguyenVong { ThuTu = reader.GetInt32(0) });
        //            listDiemChuan.Add(new DiemChuan { MaNganh = reader.GetString(1), TongDiem = float.Parse(reader["DiemChuan"].ToString()) });
        //            diemthi.TongDiem = float.Parse(reader["TongDiem"].ToString());
        //            k += 1;
        //        }

        //        reader.Close();
        //    };

        //    string query2 = "select TenNganh from DiemChuan";
        //    SqlDataReader reader2 = connect.ExecuteReader(query2);
        //    int i = 0;
        //    while (reader2.Read())
        //    {
        //        i += 1;

        //    }
        //    reader2.Close();

        //    string query1 = "select TenNganh from DiemChuan";

        //    SqlDataReader reader1 = connect.ExecuteReader(query1);


        //    if (reader1 != null)
        //    {

        //        int m = 0;

        //        while (reader1.Read())
        //        {
        //            for (int j = 0; j < i - k; j++)
        //            {
        //                listDiemChuan.Add(new DiemChuan());
        //            }
        //            if (m <= listDiemChuan.Count)
        //            {
        //                listDiemChuan[m].TenNganh = reader1.GetString(0);

        //                m++;
        //            }
        //        }

        //    }

        //    reader1.Close();
        //}
        public void getNguyenVong(int SoBD, string keyword = "")
        {
            sv.soBD = SoBD;
            connect.OpenConnection();

            string query = @"
        SELECT ThuTuNV, NguyenVong.MaNganh, DiemChuan.TenNganh, DiemChuan.TenTruong, 
               DiemChuan.TongDiem AS DiemChuan, 
               (DiemHoa + DiemLy + DiemToan) AS TongDiem
        FROM NguyenVong 
        JOIN DiemChuan ON DiemChuan.MaNganh = NguyenVong.MaNganh
        JOIN DiemThi ON DiemThi.SoBD = NguyenVong.SoBD
        WHERE NguyenVong.SoBD = @SoBD
        AND CONCAT(NguyenVong.MaNganh, ' ', DiemChuan.TenNganh, ' ', DiemChuan.TenTruong) 
            LIKE @keyword";

            SqlParameter[] parameters =
            {
        new SqlParameter("@SoBD", SoBD),
        new SqlParameter("@keyword", "%" + keyword + "%")
    };

            listNguyenVong.Clear();
            listDiemChuan.Clear();

            SqlDataReader reader = connect.ExecuteReader(query, parameters);

            while (reader.Read())
            {
                listNguyenVong.Add(new NguyenVong
                {
                    ThuTu = int.Parse(reader["ThuTuNV"].ToString()),
                    MaNganh = reader["MaNganh"].ToString()
                });

                listDiemChuan.Add(new DiemChuan
                {
                    TenNganh = reader["TenNganh"].ToString(),
                    TenTruong = reader["TenTruong"].ToString(),
                    TongDiem = float.Parse(reader["DiemChuan"].ToString())
                });

                diemThi.TongDiem = float.Parse(reader["TongDiem"].ToString());
            }

            reader.Close();
            connect.CloseConnection();
        }



        public bool checkLogin(int SoBD, string MatKhau)
        {
            string query = "select SoBD, MatKhau from HoSoThiSinh where SoBD = @SoBD and MatKhau = @MatKhau";
            SqlParameter[] parameters =
            {
                new SqlParameter("@SoBD",SoBD),
                new SqlParameter("@MatKhau",MatKhau)
            };
            SqlDataReader reader = connect.ExecuteReader(query, parameters);

            if (reader.Read())
            {
                return true;
            }

            reader.Close();
            return false;

        }

    }

}
