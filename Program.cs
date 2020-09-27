using Currency_MVC.Controller;
using Currency_MVC.Services;
using System;
using System.Windows.Forms;
using Currency_MVC.View;

namespace Currency_MVC
{
    public static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var view = new CurrencyView();
            var exchange = new CurrencyExchangeService();
            var controller = new CurrencyController(view, exchange);    // unused

            Application.Run(view);
        }
    }
}
