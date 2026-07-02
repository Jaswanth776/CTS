namespace ConverterLib;

public class CurrencyConverter
{
    private readonly ICurrencyConverter _converter;

    public CurrencyConverter(ICurrencyConverter converter)
    {
        _converter = converter;
    }

    public double ConvertAmount(double amount, string from, string to)
    {
        return _converter.Convert(amount, from, to);
    }
}
