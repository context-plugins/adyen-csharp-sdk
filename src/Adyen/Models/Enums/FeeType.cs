using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>Alma payment request fee type</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FeeType>))]
public sealed record FeeType : OpenStringEnum<FeeType>
{
    private FeeType(string value) : base(value)
    {
    }

    public static readonly FeeType MerchantPays = new("merchantPays");

    public static readonly FeeType ShopperPays = new("shopperPays");

    public TResult Match<TResult>(Func<TResult> onMerchantPays,
        Func<TResult> onShopperPays,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MerchantPays => onMerchantPays(),
            _ when this == ShopperPays => onShopperPays(),
            _ => otherwise(Value)
        };

    public void Match(Action onMerchantPays, Action onShopperPays, Action<string> otherwise)
    {
        if (this == MerchantPays) onMerchantPays();
        else if (this == ShopperPays) onShopperPays();
        else otherwise(Value);
    }
}
