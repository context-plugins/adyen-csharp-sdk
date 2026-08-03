using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>Alma payment request fee type</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FeeType>))]
public sealed record FeeType : StringEnum<FeeType>
{
    private FeeType(string value) : base(value)
    {
    }

    public static readonly FeeType MerchantPays = new("merchantPays");

    public static readonly FeeType ShopperPays = new("shopperPays");

    public static FeeType FromValue(string value) => FromValueCore(value);
}
