using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of adjustment. Possible values:
/// <list type="bullet">
///   <item><description><b>cardholderInitiatedTransaction</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>merchantInitiatedTransaction</b></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AdjustAuthType>))]
public sealed record AdjustAuthType : OpenStringEnum<AdjustAuthType>
{
    private AdjustAuthType(string value) : base(value)
    {
    }

    public static readonly AdjustAuthType CardholderInitiatedTransaction = new("cardholderInitiatedTransaction");

    public static readonly AdjustAuthType MerchantInitiatedTransaction = new("merchantInitiatedTransaction");

    public TResult Match<TResult>(Func<TResult> onCardholderInitiatedTransaction,
        Func<TResult> onMerchantInitiatedTransaction,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CardholderInitiatedTransaction => onCardholderInitiatedTransaction(),
            _ when this == MerchantInitiatedTransaction => onMerchantInitiatedTransaction(),
            _ => otherwise(Value)
        };

    public void Match(Action onCardholderInitiatedTransaction,
        Action onMerchantInitiatedTransaction,
        Action<string> otherwise)
    {
        if (this == CardholderInitiatedTransaction) onCardholderInitiatedTransaction();
        else if (this == MerchantInitiatedTransaction) onMerchantInitiatedTransaction();
        else otherwise(Value);
    }
}
