using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Action to realise on a transaction. In an <c>EnableService</c> request message:
///   - Starts a transaction by a swipe-ahead mechanism, with the services which are enabled.
///   - Aborts a swipe-ahead transaction or started by a <c>CardAcquisition</c>, and not followed by a service request from the Sale System to complete the transaction.
/// Possible values:
/// * <b>StartTransaction</b>
/// * <b>AbortTransaction</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransactionAction>))]
public sealed record TransactionAction : OpenStringEnum<TransactionAction>
{
    private TransactionAction(string value) : base(value)
    {
    }

    public static readonly TransactionAction StartTransaction = new("StartTransaction");

    public static readonly TransactionAction AbortTransaction = new("AbortTransaction");

    public TResult Match<TResult>(Func<TResult> onStartTransaction,
        Func<TResult> onAbortTransaction,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == StartTransaction => onStartTransaction(),
            _ when this == AbortTransaction => onAbortTransaction(),
            _ => otherwise(Value)
        };

    public void Match(Action onStartTransaction, Action onAbortTransaction, Action<string> otherwise)
    {
        if (this == StartTransaction) onStartTransaction();
        else if (this == AbortTransaction) onAbortTransaction();
        else otherwise(Value);
    }
}
