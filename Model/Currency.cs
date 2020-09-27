using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_MVC.Model
{
    public enum CurrencyCode
    {
        USD, EUR
    }

    public class Currency
    {
        public CurrencyCode Code { get; }

        public decimal Value { get; }

        public Currency(CurrencyCode code, decimal value)
        {
            Code = code;
            Value = value;
        }
    }
}
