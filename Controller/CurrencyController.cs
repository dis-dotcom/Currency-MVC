using System;
using System.Globalization;
using Currency_MVC.Model;
using Currency_MVC.Services;
using Currency_MVC.View;

namespace Currency_MVC.Controller
{
    public class CurrencyController
    {
        private readonly ICurrencyView _view;
        private readonly ICurrencyExchangeService _exchangeService;

        public CurrencyController(ICurrencyView view, ICurrencyExchangeService exchange)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _exchangeService = exchange ?? throw new ArgumentNullException(nameof(exchange));

            _view.StartTrackClick += View_StartTrackClick;
            _view.StopTrackClick += View_StopTrackClick;

            _exchangeService.ExchangeRateChanged += Exchange_ExchangeRateChanged;
        }

        private void Exchange_ExchangeRateChanged(CurrencyModel currencyModel)
        {
            _view.SetValue(Round(currencyModel.Value));
        }

        private void View_StopTrackClick()
        {
            _exchangeService.Pause();
        }

        private void View_StartTrackClick()
        {
            _exchangeService.Resume();
        }

        private static string Round(decimal value) 
        {
            return Math.Round(value, 4, MidpointRounding.ToEven).ToString(CultureInfo.InvariantCulture);
        }
    }
}
