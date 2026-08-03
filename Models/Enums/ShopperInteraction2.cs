using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The sales channel. Required if:
/// - The merchant account does not have a sales channel.
/// - <c>type</c> is <b>alipay</b>.
/// <para>
/// When you provide this field, it overrides the default sales channel set on the merchant account.
/// </para>
/// <para>
/// Possible values: <b>eCommerce</b>, <b>pos</b>, <b>contAuth</b>, and <b>moto</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ShopperInteraction2>))]
public sealed record ShopperInteraction2 : StringEnum<ShopperInteraction2>
{
    private ShopperInteraction2(string value) : base(value)
    {
    }

    public static readonly ShopperInteraction2 ECommerce = new("eCommerce");

    public static readonly ShopperInteraction2 Pos = new("pos");

    public static readonly ShopperInteraction2 Moto = new("moto");

    public static readonly ShopperInteraction2 ContAuth = new("contAuth");

    public static ShopperInteraction2 FromValue(string value) => FromValueCore(value);
}
