using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ProductType1>))]
public sealed record ProductType1 : OpenStringEnum<ProductType1>
{
    private ProductType1(string value) : base(value)
    {
    }

    public static readonly ProductType1 Goods = new("goods");

    public static readonly ProductType1 Services = new("services");

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
