using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Identify the type of the transaction being authenticated.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransactionType>))]
public sealed record TransactionType : OpenStringEnum<TransactionType>
{
    private TransactionType(string value) : base(value)
    {
    }

    public static readonly TransactionType GoodsOrServicePurchase = new("goodsOrServicePurchase");

    public static readonly TransactionType CheckAcceptance = new("checkAcceptance");

    public static readonly TransactionType AccountFunding = new("accountFunding");

    public static readonly TransactionType QuasiCashTransaction = new("quasiCashTransaction");

    public static readonly TransactionType PrepaidActivationAndLoad = new("prepaidActivationAndLoad");

    public TResult Match<TResult>(Func<TResult> onGoodsOrServicePurchase,
        Func<TResult> onCheckAcceptance,
        Func<TResult> onAccountFunding,
        Func<TResult> onQuasiCashTransaction,
        Func<TResult> onPrepaidActivationAndLoad,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == GoodsOrServicePurchase => onGoodsOrServicePurchase(),
            _ when this == CheckAcceptance => onCheckAcceptance(),
            _ when this == AccountFunding => onAccountFunding(),
            _ when this == QuasiCashTransaction => onQuasiCashTransaction(),
            _ when this == PrepaidActivationAndLoad => onPrepaidActivationAndLoad(),
            _ => otherwise(Value)
        };

    public void Match(Action onGoodsOrServicePurchase,
        Action onCheckAcceptance,
        Action onAccountFunding,
        Action onQuasiCashTransaction,
        Action onPrepaidActivationAndLoad,
        Action<string> otherwise)
    {
        if (this == GoodsOrServicePurchase) onGoodsOrServicePurchase();
        else if (this == CheckAcceptance) onCheckAcceptance();
        else if (this == AccountFunding) onAccountFunding();
        else if (this == QuasiCashTransaction) onQuasiCashTransaction();
        else if (this == PrepaidActivationAndLoad) onPrepaidActivationAndLoad();
        else otherwise(Value);
    }
}
