using System;
using System.Globalization;
using Currency_MVC.Model;
using Currency_MVC.Services;
using Currency_MVC.View;

namespace Currency_MVC.Controller
{
    internal class CurrencyController : ICurrencyController
    {
        private readonly ICurrencyView _view;
        private readonly ICurrencyExchange _exchange;

        public CurrencyController(ICurrencyView view, ICurrencyExchange exchange)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _exchange = exchange ?? throw new ArgumentNullException(nameof(exchange));

            _view.StartTrackClick += View_StartTrackClick;
            _view.StopTrackClick += View_StopTrackClick;

            _exchange.ExchangeRateChanged += Exchange_ExchangeRateChanged;
        }

        private void Exchange_ExchangeRateChanged(Currency currency)
        {
            _view.SetValue(Round(currency.Value));
        }

        private void View_StopTrackClick()
        {
            _exchange.Pause();
        }

        private void View_StartTrackClick()
        {
            _exchange.Resume();
        }

        private static string Round(decimal value) 
        {
            return Math.Round(value, 4, MidpointRounding.ToEven).ToString(CultureInfo.InvariantCulture);
        }
    }
}
