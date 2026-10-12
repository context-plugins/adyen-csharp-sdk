using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<RequiredShopperField>))]
public sealed record RequiredShopperField : OpenStringEnum<RequiredShopperField>
{
    private RequiredShopperField(string value) : base(value)
    {
    }

    public static readonly RequiredShopperField BillingAddress = new("billingAddress");

    public static readonly RequiredShopperField DeliveryAddress = new("deliveryAddress");

    public static readonly RequiredShopperField ShopperEmail = new("shopperEmail");

    public static readonly RequiredShopperField ShopperName = new("shopperName");

    public static readonly RequiredShopperField TelephoneNumber = new("telephoneNumber");

    public TResult Match<TResult>(Func<TResult> onBillingAddress,
        Func<TResult> onDeliveryAddress,
        Func<TResult> onShopperEmail,
        Func<TResult> onShopperName,
        Func<TResult> onTelephoneNumber,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BillingAddress => onBillingAddress(),
            _ when this == DeliveryAddress => onDeliveryAddress(),
            _ when this == ShopperEmail => onShopperEmail(),
            _ when this == ShopperName => onShopperName(),
            _ when this == TelephoneNumber => onTelephoneNumber(),
            _ => otherwise(Value)
        };

    public void Match(Action onBillingAddress,
        Action onDeliveryAddress,
        Action onShopperEmail,
        Action onShopperName,
        Action onTelephoneNumber,
        Action<string> otherwise)
    {
        if (this == BillingAddress) onBillingAddress();
        else if (this == DeliveryAddress) onDeliveryAddress();
        else if (this == ShopperEmail) onShopperEmail();
        else if (this == ShopperName) onShopperName();
        else if (this == TelephoneNumber) onTelephoneNumber();
        else otherwise(Value);
    }
}
