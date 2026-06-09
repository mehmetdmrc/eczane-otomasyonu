using System;
using System.Windows.Forms;

namespace otomosyan_projesi
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new LoginForm());
        }
    }
}
