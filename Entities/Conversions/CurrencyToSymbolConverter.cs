using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreMovies.Entities.Conversions
{
    public class CurrencyToSymbolConverter : ValueConverter<Currency,string>
    {
        public CurrencyToSymbolConverter() :base (value => MapCurrencyToString(value),value => MapStringToCurrency(value))
        {

        }
        public static string MapCurrencyToString(Currency value)
        {
            return value switch
            {
                Currency.DominicanPeso => "RD$",
                Currency.USDollar => "$",
                Currency.Euro => "€",
                Currency.Yen => "¥",
                _ => ""

            };
        }
        public static Currency MapStringToCurrency(string value)
        {
            return value switch
            {
                "RD$" => Currency.DominicanPeso,
                "$" => Currency.USDollar,
                "€" => Currency.Euro,
                "¥" => Currency.Yen,
                _ => Currency.Unknown
            };
        }

    }
    
}
