using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Value4>))]
public sealed record Value4 : OpenStringEnum<Value4>
{
    private Value4(string value) : base(value)
    {
    }

    public static readonly Value4 AtmWithdraw = new("atmWithdraw");

    public static readonly Value4 BalanceInquiry = new("balanceInquiry");

    public static readonly Value4 Ecommerce = new("ecommerce");

    public static readonly Value4 Moto = new("moto");

    public static readonly Value4 Pos = new("pos");

    public static readonly Value4 Recurring = new("recurring");

    public static readonly Value4 Token = new("token");

    public static readonly Value4 Unknown = new("unknown");

    public TResult Match<TResult>(Func<TResult> onAtmWithdraw,
        Func<TResult> onBalanceInquiry,
        Func<TResult> onEcommerce,
        Func<TResult> onMoto,
        Func<TResult> onPos,
        Func<TResult> onRecurring,
        Func<TResult> onToken,
        Func<TResult> onUnknown,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AtmWithdraw => onAtmWithdraw(),
            _ when this == BalanceInquiry => onBalanceInquiry(),
            _ when this == Ecommerce => onEcommerce(),
            _ when this == Moto => onMoto(),
            _ when this == Pos => onPos(),
            _ when this == Recurring => onRecurring(),
            _ when this == Token => onToken(),
            _ when this == Unknown => onUnknown(),
            _ => otherwise(Value)
        };

    public void Match(Action onAtmWithdraw,
        Action onBalanceInquiry,
        Action onEcommerce,
        Action onMoto,
        Action onPos,
        Action onRecurring,
        Action onToken,
        Action onUnknown,
        Action<string> otherwise)
    {
        if (this == AtmWithdraw) onAtmWithdraw();
        else if (this == BalanceInquiry) onBalanceInquiry();
        else if (this == Ecommerce) onEcommerce();
        else if (this == Moto) onMoto();
        else if (this == Pos) onPos();
        else if (this == Recurring) onRecurring();
        else if (this == Token) onToken();
        else if (this == Unknown) onUnknown();
        else otherwise(Value);
    }
}
