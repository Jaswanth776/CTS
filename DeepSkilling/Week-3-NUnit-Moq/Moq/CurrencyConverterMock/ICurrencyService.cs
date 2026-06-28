namespace MoqDemo.CurrencyConverterMock
{
    public interface ICurrencyService
    {
        decimal GetExchangeRate(string from, string to);
    }
}
