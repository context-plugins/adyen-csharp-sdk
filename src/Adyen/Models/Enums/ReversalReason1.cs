using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Reason of the payment or loyalty reversal.
/// Possible values:
/// * <b>CustCancel</b>
/// * <b>Malfunction</b>
/// * <b>MerchantCancel</b>
/// * <b>Unable2Compl</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ReversalReason1>))]
public sealed record ReversalReason1 : OpenStringEnum<ReversalReason1>
{
    private ReversalReason1(string value) : base(value)
    {
    }

    public static readonly ReversalReason1 CustCancel = new("CustCancel");

    public static readonly ReversalReason1 MerchantCancel = new("MerchantCancel");

    public static readonly ReversalReason1 Malfunction = new("Malfunction");

    public static readonly ReversalReason1 Unable2Compl = new("Unable2Compl");

    public TResult Match<TResult>(Func<TResult> onCustCancel,
        Func<TResult> onMerchantCancel,
        Func<TResult> onMalfunction,
        Func<TResult> onUnable2Compl,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CustCancel => onCustCancel(),
            _ when this == MerchantCancel => onMerchantCancel(),
            _ when this == Malfunction => onMalfunction(),
            _ when this == Unable2Compl => onUnable2Compl(),
            _ => otherwise(Value)
        };

    public void Match(Action onCustCancel,
        Action onMerchantCancel,
        Action onMalfunction,
        Action onUnable2Compl,
        Action<string> otherwise)
    {
        if (this == CustCancel) onCustCancel();
        else if (this == MerchantCancel) onMerchantCancel();
        else if (this == Malfunction) onMalfunction();
        else if (this == Unable2Compl) onUnable2Compl();
        else otherwise(Value);
    }
}
