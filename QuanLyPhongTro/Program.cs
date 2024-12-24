using QuanLyPhongTro.views;

namespace QuanLyPhongTro
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            ApplicationConfiguration.Initialize();
            frmLogin lg = new frmLogin();
            if(lg.ShowDialog()==DialogResult.OK)
            {
                Application.Run(new frmMain());
            }

        }
    }
}