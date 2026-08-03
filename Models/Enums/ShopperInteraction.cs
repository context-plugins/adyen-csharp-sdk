using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The sales channel. Possible values: <b>Ecommerce</b>, <b>POS</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ShopperInteraction>))]
public sealed record ShopperInteraction : StringEnum<ShopperInteraction>
{
    private ShopperInteraction(string value) : base(value)
    {
    }

    public static readonly ShopperInteraction Ecommerce = new("Ecommerce");

    public static readonly ShopperInteraction Pos = new("POS");

    public static ShopperInteraction FromValue(string value) => FromValueCore(value);
}
