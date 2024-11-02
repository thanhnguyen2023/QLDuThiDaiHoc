namespace DuThiDaiHoc
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new LoginForm()); // Thay bằng form của bạn
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chạy chương trình: {ex.Message}");
            }
        }

    }
}   