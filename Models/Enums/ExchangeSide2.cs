using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The operation performed on the source amount. Possible values:
/// * <b>buy</b>
/// * <b>sell</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ExchangeSide2>))]
public sealed record ExchangeSide2 : StringEnum<ExchangeSide2>
{
    private ExchangeSide2(string value) : base(value)
    {
    }

    public static readonly ExchangeSide2 Buy = new("buy");

    public static readonly ExchangeSide2 Sell = new("sell");

    public static ExchangeSide2 FromValue(string value) => FromValueCore(value);
}
