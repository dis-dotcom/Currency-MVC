using Currency_MVC.Model;
using System;
using System.Threading;

namespace Currency_MVC.Services
{
    public class CurrencyExchange : ICurrencyExchange
    {
        private Timer _timer;
        private readonly Random _rnd;

        public event Action<Currency> ExchangeRateChanged;

        public CurrencyExchange() 
        {
            _rnd = new Random();
        }

        public void Pause()
        {
            _timer?.Dispose();
            _timer = null;
        }

        public void Resume()
        {
            if (_timer == null)
            {
                _timer = new Timer(TimerTickCallback, null, 0, 1000);
            }
        }

        private void TimerTickCallback(object obj) 
        {
            var value = new decimal(77 + _rnd.NextDouble());

            var currency = new Currency(CurrencyCode.Usd, value);
            ExchangeRateChanged?.Invoke(currency);
        }
    }
}
