namespace Currency_MVC.Model
{
    public enum CurrencyCode
    {
        Usd, Eur
        // EUR is unused
    }

    public class CurrencyModel
    {
        private CurrencyCode Code { get; }

        public decimal Value { get; }

        public CurrencyModel(CurrencyCode code, decimal value)
        {
            Code = code;
            Value = value;
        }
    }
}
