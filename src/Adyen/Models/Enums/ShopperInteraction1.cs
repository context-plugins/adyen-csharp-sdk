using System;
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
[JsonConverter(typeof(StringEnumConverter<ShopperInteraction1>))]
public sealed record ShopperInteraction1 : OpenStringEnum<ShopperInteraction1>
{
    private ShopperInteraction1(string value) : base(value)
    {
    }

    public static readonly ShopperInteraction1 ECommerce = new("eCommerce");

    public static readonly ShopperInteraction1 Pos = new("pos");

    public static readonly ShopperInteraction1 Moto = new("moto");

    public static readonly ShopperInteraction1 ContAuth = new("contAuth");

    public TResult Match<TResult>(Func<TResult> onECommerce,
        Func<TResult> onPos,
        Func<TResult> onMoto,
        Func<TResult> onContAuth,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ECommerce => onECommerce(),
            _ when this == Pos => onPos(),
            _ when this == Moto => onMoto(),
            _ when this == ContAuth => onContAuth(),
            _ => otherwise(Value)
        };

    public void Match(Action onECommerce, Action onPos, Action onMoto, Action onContAuth, Action<string> otherwise)
    {
        if (this == ECommerce) onECommerce();
        else if (this == Pos) onPos();
        else if (this == Moto) onMoto();
        else if (this == ContAuth) onContAuth();
        else otherwise(Value);
    }
}
