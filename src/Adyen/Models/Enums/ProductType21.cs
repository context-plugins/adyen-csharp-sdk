using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of product that you expected to receive.
/// <para>
/// Possible values: <b>goods</b>, <b>services</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ProductType21>))]
public sealed record ProductType21 : OpenStringEnum<ProductType21>
{
    private ProductType21(string value) : base(value)
    {
    }

    public static readonly ProductType21 Goods = new("goods");

    public static readonly ProductType21 Services = new("services");

    public TResult Match<TResult>(Func<TResult> onGoods, Func<TResult> onServices, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Goods => onGoods(),
            _ when this == Services => onServices(),
            _ => otherwise(Value)
        };

    public void Match(Action onGoods, Action onServices, Action<string> otherwise)
    {
        if (this == Goods) onGoods();
        else if (this == Services) onServices();
        else otherwise(Value);
    }
}
