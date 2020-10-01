using System;
using Currency_MVC.Controller;
using Currency_MVC.View;
using Currency_MVC.Services;
using NSubstitute;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Currency_MVC.Model;
using System.Threading;

namespace CurrencyUnitTests
{
    [TestClass]
    public class CurrencyControllerShould
    {
        private CurrencyController _target;

        private ICurrencyView _view;
        private ICurrencyExchangeService _exchangeService;

        [TestInitialize]
        public void Setup() 
        {
            _view = Substitute.For<ICurrencyView>();
            _exchangeService = Substitute.For<ICurrencyExchangeService>();

            _target = new CurrencyController(_view, _exchangeService);
        }

        [TestMethod]
        public void ViewClickStart_JustClick_StartService()
        {
            // Arrange
            // Init not required

            // Act
            _view.StartTrackClick += Raise.Event<Action>();

            // Assert
            _exchangeService.Received(1).Resume();
        }

        [TestMethod]
        public void ExchangeService_CurrencyChanged_UpdatedView()
        {
            // Arrange
            // "fake" model
            var model = new CurrencyModel(CurrencyCode.Usd, 78);

            // Act
            // push "fake" model to event and raise it!
            _exchangeService.ExchangeRateChanged += Raise.Event<Action<CurrencyModel>>(model);

            // Assert
            // after event view has been changed
            _view.Received(1).SetValue(Arg.Any<string>());
        }
    }
}
