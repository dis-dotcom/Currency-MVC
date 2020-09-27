using Currency_MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_MVC.Services
{
    public interface ICurrencyExchange
    {
        event Action<Currency> ExchangeRateChanged;

        void Resume();
        void Pause();
    }
}
