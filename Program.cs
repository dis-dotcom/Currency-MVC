using Currency_MVC.Controller;
using Currency_MVC.Services;
using System;
using System.Windows.Forms;

namespace Currency_MVC
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var view = new CurrencyView();
            var exchange = new CurrencyExchange();
            var controller = new CurrencyController(view, exchange);

            Application.Run(view);
        }
    }
}
