using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<RequiredShopperField>))]
public sealed record RequiredShopperField : StringEnum<RequiredShopperField>
{
    private RequiredShopperField(string value) : base(value)
    {
    }

    public static readonly RequiredShopperField BillingAddress = new("billingAddress");

    public static readonly RequiredShopperField DeliveryAddress = new("deliveryAddress");

    public static readonly RequiredShopperField ShopperEmail = new("shopperEmail");

    public static readonly RequiredShopperField ShopperName = new("shopperName");

    public static readonly RequiredShopperField TelephoneNumber = new("telephoneNumber");

    public static RequiredShopperField FromValue(string value) => FromValueCore(value);
}
