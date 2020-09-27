namespace Currency_MVC.Model
{
    public enum CurrencyCode
    {
        Usd, Eur
        // EUR is unused
    }

    public class Currency
    {
        private CurrencyCode Code { get; }

        public decimal Value { get; }

        public Currency(CurrencyCode code, decimal value)
        {
            Code = code;
            Value = value;
        }
    }
}
