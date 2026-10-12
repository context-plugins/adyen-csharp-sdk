using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The sales channel condition that defines whether the split logic applies.
/// <para>
/// Possible values:
/// * <b>Ecommerce</b>: Online transactions where the cardholder is present.
/// * <b>ContAuth</b>: Card on file and/or subscription transactions, where the cardholder is known to the merchant (returning customer).
/// * <b>Moto</b>: Mail-order and telephone-order transactions where the customer is in contact with the merchant via email or telephone.
/// * <b>POS</b>: Point-of-sale transactions where the customer is physically present to make a payment using a secure payment terminal.
/// * <b>ANY</b>: All sales channels.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ShopperInteraction11>))]
public sealed record ShopperInteraction11 : OpenStringEnum<ShopperInteraction11>
{
    private ShopperInteraction11(string value) : base(value)
    {
    }

    public static readonly ShopperInteraction11 Ecommerce = new("Ecommerce");

    public static readonly ShopperInteraction11 ContAuth = new("ContAuth");

    public static readonly ShopperInteraction11 Moto = new("Moto");

    public static readonly ShopperInteraction11 Pos = new("POS");

    public static readonly ShopperInteraction11 Any = new("ANY");

    public TResult Match<TResult>(Func<TResult> onEcommerce,
        Func<TResult> onContAuth,
        Func<TResult> onMoto,
        Func<TResult> onPos,
        Func<TResult> onAny,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ecommerce => onEcommerce(),
            _ when this == ContAuth => onContAuth(),
            _ when this == Moto => onMoto(),
            _ when this == Pos => onPos(),
            _ when this == Any => onAny(),
            _ => otherwise(Value)
        };

    public void Match(Action onEcommerce,
        Action onContAuth,
        Action onMoto,
        Action onPos,
        Action onAny,
        Action<string> otherwise)
    {
        if (this == Ecommerce) onEcommerce();
        else if (this == ContAuth) onContAuth();
        else if (this == Moto) onMoto();
        else if (this == Pos) onPos();
        else if (this == Any) onAny();
        else otherwise(Value);
    }
}
