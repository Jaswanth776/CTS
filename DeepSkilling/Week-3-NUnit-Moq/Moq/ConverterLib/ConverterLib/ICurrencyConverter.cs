namespace ConverterLib;

public interface ICurrencyConverter
{
    double Convert(double amount, string fromCurrency, string toCurrency);
}
