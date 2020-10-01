using System;
using Currency_MVC.Controller;
using Currency_MVC.View;
using Currency_MVC.Services;
using NSubstitute;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            //Assert.Fail("Error");
        }
    }
}
