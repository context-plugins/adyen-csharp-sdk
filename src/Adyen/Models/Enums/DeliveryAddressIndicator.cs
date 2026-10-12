using System;
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
public sealed record DeliveryAddressIndicator : OpenStringEnum<DeliveryAddressIndicator>
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

    public TResult Match<TResult>(Func<TResult> onShipToBillingAddress,
        Func<TResult> onShipToVerifiedAddress,
        Func<TResult> onShipToNewAddress,
        Func<TResult> onShipToStore,
        Func<TResult> onDigitalGoods,
        Func<TResult> onGoodsNotShipped,
        Func<TResult> onOther,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ShipToBillingAddress => onShipToBillingAddress(),
            _ when this == ShipToVerifiedAddress => onShipToVerifiedAddress(),
            _ when this == ShipToNewAddress => onShipToNewAddress(),
            _ when this == ShipToStore => onShipToStore(),
            _ when this == DigitalGoods => onDigitalGoods(),
            _ when this == GoodsNotShipped => onGoodsNotShipped(),
            _ when this == Other => onOther(),
            _ => otherwise(Value)
        };

    public void Match(Action onShipToBillingAddress,
        Action onShipToVerifiedAddress,
        Action onShipToNewAddress,
        Action onShipToStore,
        Action onDigitalGoods,
        Action onGoodsNotShipped,
        Action onOther,
        Action<string> otherwise)
    {
        if (this == ShipToBillingAddress) onShipToBillingAddress();
        else if (this == ShipToVerifiedAddress) onShipToVerifiedAddress();
        else if (this == ShipToNewAddress) onShipToNewAddress();
        else if (this == ShipToStore) onShipToStore();
        else if (this == DigitalGoods) onDigitalGoods();
        else if (this == GoodsNotShipped) onGoodsNotShipped();
        else if (this == Other) onOther();
        else otherwise(Value);
    }
}
