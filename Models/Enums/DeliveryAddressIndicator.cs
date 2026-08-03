using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicator regarding the delivery address.
/// Allowed values:
/// * <c>shipToBillingAddress</c>
/// * <c>shipToVerifiedAddress</c>
/// * <c>shipToNewAddress</c>
/// * <c>shipToStore</c>
/// * <c>digitalGoods</c>
/// * <c>goodsNotShipped</c>
/// * <c>other</c>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DeliveryAddressIndicator>))]
public sealed record DeliveryAddressIndicator : StringEnum<DeliveryAddressIndicator>
{
    private DeliveryAddressIndicator(string value) : base(value)
    {
    }

    public static readonly DeliveryAddressIndicator ShipToBillingAddress = new("shipToBillingAddress");

    public static readonly DeliveryAddressIndicator ShipToVerifiedAddress = new("shipToVerifiedAddress");

    public static readonly DeliveryAddressIndicator ShipToNewAddress = new("shipToNewAddress");

    public static readonly DeliveryAddressIndicator ShipToStore = new("shipToStore");

    public static readonly DeliveryAddressIndicator DigitalGoods = new("digitalGoods");

    public static readonly DeliveryAddressIndicator GoodsNotShipped = new("goodsNotShipped");

    public static readonly DeliveryAddressIndicator Other = new("other");

    public static DeliveryAddressIndicator FromValue(string value) => FromValueCore(value);
}
