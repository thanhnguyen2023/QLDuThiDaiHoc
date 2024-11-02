using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBConnect
{
    public class Connection
    {
        public string DataSource { get; set; } = "DESKTOP-MBTO88F";
        public string DatabaseName { get; set; } = "DuThiDaiHoc";
        public string ConnectionString => $"Data Source={DataSource};Initial Catalog={DatabaseName};Integrated Security=True";
        private SqlConnection conn;

        // Constructor mở kết nối ngay khi khởi tạo đối tượng
        public Connection()
        {
            conn = new SqlConnection(ConnectionString);
        }

        // Mở kết nối
        public void OpenConnection()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xảy ra: {ex.Message}", "Lỗi");
            }
        }

        // Đóng kết nối
        public void CloseConnection()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
        }

        // Thực hiện lệnh SELECT, trả về nhiều dòng dữ liệu qua SqlDataReader
        public SqlDataReader ExecuteReader(string query, SqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand(query, conn);

                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                return command.ExecuteReader(CommandBehavior.CloseConnection); // Kết nối sẽ tự đóng khi Reader đóng
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
                return null;
            }
        }

        // Thực hiện lệnh SELECT, trả về giá trị đơn lẻ
        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);
                    

                    return command.ExecuteScalar(); // Trả về giá trị đơn lẻ
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }

        // Thực hiện lệnh INSERT, UPDATE, DELETE, trả về số dòng bị ảnh hưởng
        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            try
            {
                OpenConnection();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    return command.ExecuteNonQuery(); // Trả về số dòng bị ảnh hưởng
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
                return 0;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
