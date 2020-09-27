using Currency_MVC.Model;
using System;
using System.Threading;

namespace Currency_MVC.Services
{
    public class CurrencyExchange : ICurrencyExchange
    {
        private Timer timer;
        private Random rnd;

        public event Action<Currency> ExchangeRateChanged;

        public CurrencyExchange() 
        {
            rnd = new Random();
        }

        public void Pause()
        {
            timer?.Dispose();
            timer = null;
        }

        public void Resume()
        {
            if (timer == null)
            {
                timer = new Timer(TimerTickCallback, null, 0, 1000);
            }
        }

        private void TimerTickCallback(object obj) 
        {
            decimal value = new decimal(77 + rnd.NextDouble());

            var currency = new Currency(CurrencyCode.USD, value);
            ExchangeRateChanged?.Invoke(currency);
        }
    }
}
