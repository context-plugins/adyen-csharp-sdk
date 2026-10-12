using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of error.
/// <para>
/// Possible values:
/// *  <b>invalidInput</b>
/// *  <b>dataMissing</b>
/// *  <b>pendingStatus</b>
/// *  <b>rejected</b>
/// *  <b>dataReview</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type512>))]
public sealed record Type512 : OpenStringEnum<Type512>
{
    private Type512(string value) : base(value)
    {
    }

    public static readonly Type512 DataMissing = new("dataMissing");

    public static readonly Type512 DataReview = new("dataReview");

    public static readonly Type512 InvalidInput = new("invalidInput");

    public static readonly Type512 PendingStatus = new("pendingStatus");

    public static readonly Type512 Rejected = new("rejected");

    public TResult Match<TResult>(Func<TResult> onDataMissing,
        Func<TResult> onDataReview,
        Func<TResult> onInvalidInput,
        Func<TResult> onPendingStatus,
        Func<TResult> onRejected,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DataMissing => onDataMissing(),
            _ when this == DataReview => onDataReview(),
            _ when this == InvalidInput => onInvalidInput(),
            _ when this == PendingStatus => onPendingStatus(),
            _ when this == Rejected => onRejected(),
            _ => otherwise(Value)
        };

    public void Match(Action onDataMissing,
        Action onDataReview,
        Action onInvalidInput,
        Action onPendingStatus,
        Action onRejected,
        Action<string> otherwise)
    {
        if (this == DataMissing) onDataMissing();
        else if (this == DataReview) onDataReview();
        else if (this == InvalidInput) onInvalidInput();
        else if (this == PendingStatus) onPendingStatus();
        else if (this == Rejected) onRejected();
        else otherwise(Value);
    }
}
