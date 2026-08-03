using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ExchangeSide>))]
public sealed record ExchangeSide : StringEnum<ExchangeSide>
{
    private ExchangeSide(string value) : base(value)
    {
    }

    public static readonly ExchangeSide Buy = new("buy");

    public static readonly ExchangeSide Sell = new("sell");

    public static ExchangeSide FromValue(string value) => FromValueCore(value);
}
