using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Millionaire
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana giriş yeri
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());//Main window'u çalıştırması için böylelikle oyun başlayacak
        }
    }
}
