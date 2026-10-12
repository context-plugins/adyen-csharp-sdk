using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Contains information about how the payment was processed.
/// <para>
/// Possible values: <b>atmWithdraw</b>, <b>balanceInquiry</b>, <b>ecommerce</b>, <b>moto</b>, <b>pos</b>, <b>purchaseWithCashback</b>, <b>recurring</b>, <b>token</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ProcessingType1>))]
public sealed record ProcessingType1 : OpenStringEnum<ProcessingType1>
{
    private ProcessingType1(string value) : base(value)
    {
    }

    public static readonly ProcessingType1 AtmWithdraw = new("atmWithdraw");

    public static readonly ProcessingType1 BalanceInquiry = new("balanceInquiry");

    public static readonly ProcessingType1 Ecommerce = new("ecommerce");

    public static readonly ProcessingType1 Moto = new("moto");

    public static readonly ProcessingType1 Pos = new("pos");

    public static readonly ProcessingType1 PurchaseWithCashback = new("purchaseWithCashback");

    public static readonly ProcessingType1 Recurring = new("recurring");

    public static readonly ProcessingType1 Token = new("token");

    public TResult Match<TResult>(Func<TResult> onAtmWithdraw,
        Func<TResult> onBalanceInquiry,
        Func<TResult> onEcommerce,
        Func<TResult> onMoto,
        Func<TResult> onPos,
        Func<TResult> onPurchaseWithCashback,
        Func<TResult> onRecurring,
        Func<TResult> onToken,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AtmWithdraw => onAtmWithdraw(),
            _ when this == BalanceInquiry => onBalanceInquiry(),
            _ when this == Ecommerce => onEcommerce(),
            _ when this == Moto => onMoto(),
            _ when this == Pos => onPos(),
            _ when this == PurchaseWithCashback => onPurchaseWithCashback(),
            _ when this == Recurring => onRecurring(),
            _ when this == Token => onToken(),
            _ => otherwise(Value)
        };

    public void Match(Action onAtmWithdraw,
        Action onBalanceInquiry,
        Action onEcommerce,
        Action onMoto,
        Action onPos,
        Action onPurchaseWithCashback,
        Action onRecurring,
        Action onToken,
        Action<string> otherwise)
    {
        if (this == AtmWithdraw) onAtmWithdraw();
        else if (this == BalanceInquiry) onBalanceInquiry();
        else if (this == Ecommerce) onEcommerce();
        else if (this == Moto) onMoto();
        else if (this == Pos) onPos();
        else if (this == PurchaseWithCashback) onPurchaseWithCashback();
        else if (this == Recurring) onRecurring();
        else if (this == Token) onToken();
        else otherwise(Value);
    }
}
