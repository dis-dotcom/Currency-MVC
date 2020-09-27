using Currency_MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_MVC.Services
{
    public interface ICurrencyExchangeService
    {
        event Action<CurrencyModel> ExchangeRateChanged;

        void Resume();
        void Pause();
    }
}
