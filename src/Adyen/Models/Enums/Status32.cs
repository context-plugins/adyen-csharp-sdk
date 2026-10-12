using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the check.
/// <para>
/// Possible values: <b>AWAITING_DATA</b> , <b>DATA_PROVIDED</b>, <b>FAILED</b>, <b>INVALID_DATA</b>, <b>PASSED</b>, <b>PENDING</b>, <b>RETRY_LIMIT_REACHED</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status32>))]
public sealed record Status32 : OpenStringEnum<Status32>
{
    private Status32(string value) : base(value)
    {
    }

    public static readonly Status32 AwaitingData = new("AWAITING_DATA");

    public static readonly Status32 DataProvided = new("DATA_PROVIDED");

    public static readonly Status32 Failed = new("FAILED");

    public static readonly Status32 InvalidData = new("INVALID_DATA");

    public static readonly Status32 Passed = new("PASSED");

    public static readonly Status32 Pending = new("PENDING");

    public static readonly Status32 PendingReview = new("PENDING_REVIEW");

    public static readonly Status32 RetryLimitReached = new("RETRY_LIMIT_REACHED");

    public static readonly Status32 Unchecked = new("UNCHECKED");

    public TResult Match<TResult>(Func<TResult> onAwaitingData,
        Func<TResult> onDataProvided,
        Func<TResult> onFailed,
        Func<TResult> onInvalidData,
        Func<TResult> onPassed,
        Func<TResult> onPending,
        Func<TResult> onPendingReview,
        Func<TResult> onRetryLimitReached,
        Func<TResult> onUnchecked,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AwaitingData => onAwaitingData(),
            _ when this == DataProvided => onDataProvided(),
            _ when this == Failed => onFailed(),
            _ when this == InvalidData => onInvalidData(),
            _ when this == Passed => onPassed(),
            _ when this == Pending => onPending(),
            _ when this == PendingReview => onPendingReview(),
            _ when this == RetryLimitReached => onRetryLimitReached(),
            _ when this == Unchecked => onUnchecked(),
            _ => otherwise(Value)
        };

    public void Match(Action onAwaitingData,
        Action onDataProvided,
        Action onFailed,
        Action onInvalidData,
        Action onPassed,
        Action onPending,
        Action onPendingReview,
        Action onRetryLimitReached,
        Action onUnchecked,
        Action<string> otherwise)
    {
        if (this == AwaitingData) onAwaitingData();
        else if (this == DataProvided) onDataProvided();
        else if (this == Failed) onFailed();
        else if (this == InvalidData) onInvalidData();
        else if (this == Passed) onPassed();
        else if (this == Pending) onPending();
        else if (this == PendingReview) onPendingReview();
        else if (this == RetryLimitReached) onRetryLimitReached();
        else if (this == Unchecked) onUnchecked();
        else otherwise(Value);
    }
}
