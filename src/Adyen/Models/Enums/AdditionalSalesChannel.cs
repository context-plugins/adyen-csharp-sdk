using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AdditionalSalesChannel>))]
public sealed record AdditionalSalesChannel : OpenStringEnum<AdditionalSalesChannel>
{
    private AdditionalSalesChannel(string value) : base(value)
    {
    }

    public static readonly AdditionalSalesChannel ECommerce = new("eCommerce");

    public static readonly AdditionalSalesChannel EcomMoto = new("ecomMoto");

    public static readonly AdditionalSalesChannel Pos = new("pos");

    public static readonly AdditionalSalesChannel PosMoto = new("posMoto");

    public TResult Match<TResult>(Func<TResult> onECommerce,
        Func<TResult> onEcomMoto,
        Func<TResult> onPos,
        Func<TResult> onPosMoto,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ECommerce => onECommerce(),
            _ when this == EcomMoto => onEcomMoto(),
            _ when this == Pos => onPos(),
            _ when this == PosMoto => onPosMoto(),
            _ => otherwise(Value)
        };

    public void Match(Action onECommerce, Action onEcomMoto, Action onPos, Action onPosMoto, Action<string> otherwise)
    {
        if (this == ECommerce) onECommerce();
        else if (this == EcomMoto) onEcomMoto();
        else if (this == Pos) onPos();
        else if (this == PosMoto) onPosMoto();
        else otherwise(Value);
    }
}
