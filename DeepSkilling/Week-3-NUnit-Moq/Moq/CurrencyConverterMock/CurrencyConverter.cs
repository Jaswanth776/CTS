namespace MoqDemo.CurrencyConverterMock
{
    public class CurrencyConverter
    {
        private readonly ICurrencyService currencyService;

        public CurrencyConverter(ICurrencyService currencyService)
        {
            this.currencyService = currencyService;
        }

        public decimal Convert(decimal amount, string from, string to)
        {
            decimal rate = currencyService.GetExchangeRate(from, to);
            return amount * rate;
        }
    }
}
