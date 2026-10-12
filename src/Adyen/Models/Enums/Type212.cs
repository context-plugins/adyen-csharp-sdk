using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of error.
/// <para>
///
/// </para>
/// <para>
/// Possible values:
/// *  <b>invalidInput</b>
/// *  <b>dataMissing</b>
/// *  <b>pendingStatus</b>
/// *  <b>dataReview</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type212>))]
public sealed record Type212 : OpenStringEnum<Type212>
{
    private Type212(string value) : base(value)
    {
    }

    public static readonly Type212 DataMissing = new("dataMissing");

    public static readonly Type212 DataReview = new("dataReview");

    public static readonly Type212 InvalidInput = new("invalidInput");

    public static readonly Type212 PendingStatus = new("pendingStatus");

    public TResult Match<TResult>(Func<TResult> onDataMissing,
        Func<TResult> onDataReview,
        Func<TResult> onInvalidInput,
        Func<TResult> onPendingStatus,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DataMissing => onDataMissing(),
            _ when this == DataReview => onDataReview(),
            _ when this == InvalidInput => onInvalidInput(),
            _ when this == PendingStatus => onPendingStatus(),
            _ => otherwise(Value)
        };

    public void Match(Action onDataMissing,
        Action onDataReview,
        Action onInvalidInput,
        Action onPendingStatus,
        Action<string> otherwise)
    {
        if (this == DataMissing) onDataMissing();
        else if (this == DataReview) onDataReview();
        else if (this == InvalidInput) onInvalidInput();
        else if (this == PendingStatus) onPendingStatus();
        else otherwise(Value);
    }
}
