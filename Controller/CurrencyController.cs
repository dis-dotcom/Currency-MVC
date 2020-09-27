using Currency_MVC.Services;
using Currency_MVC.View;
using System;

namespace Currency_MVC.Controller
{
    class CurrencyController : ICurrencyController
    {
        ICurrencyView view;
        ICurrencyExchange exchange;

        public CurrencyController(ICurrencyView view, ICurrencyExchange exchange)
        {
            this.view = view ?? throw new ArgumentNullException(nameof(view));
            this.exchange = exchange ?? throw new ArgumentNullException(nameof(exchange));

            this.view.StartTrackClick += View_StartTrackClick;
            this.view.StopTrackClick += View_StopTrackClick;

            this.exchange.ExchangeRateChanged += Exchange_ExchangeRateChanged;
        }

        private void Exchange_ExchangeRateChanged(Model.Currency currency)
        {
            view.SetValue(Round(currency.Value));
        }

        private void View_StopTrackClick()
        {
            exchange.Pause();
        }

        private void View_StartTrackClick()
        {
            exchange.Resume();
        }

        private string Round(decimal value) 
        {
            return Math.Round(value, 4, MidpointRounding.ToEven).ToString();
        }
    }
}
