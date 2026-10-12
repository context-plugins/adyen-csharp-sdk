using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The code for the status of the grant. Possible values:
/// - <b>Pending</b>
/// - <b>Active</b>
/// - <b>Repaid</b>
/// - <b>WrittenOff</b>
/// - <b>Failed</b>
/// - <b>Revoked</b>
/// - <b>Requested</b>
/// - <b>Reviewing</b>
/// - <b>Approved</b>
/// - <b>Rejected</b>
/// - <b>Cancelled</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Code>))]
public sealed record Code : OpenStringEnum<Code>
{
    private Code(string value) : base(value)
    {
    }

    public static readonly Code Pending = new("Pending");

    public static readonly Code Active = new("Active");

    public static readonly Code Repaid = new("Repaid");

    public static readonly Code WrittenOff = new("WrittenOff");

    public static readonly Code Failed = new("Failed");

    public static readonly Code Revoked = new("Revoked");

    public static readonly Code Requested = new("Requested");

    public static readonly Code Reviewing = new("Reviewing");

    public static readonly Code Approved = new("Approved");

    public static readonly Code Rejected = new("Rejected");

    public static readonly Code Cancelled = new("Cancelled");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onActive,
        Func<TResult> onRepaid,
        Func<TResult> onWrittenOff,
        Func<TResult> onFailed,
        Func<TResult> onRevoked,
        Func<TResult> onRequested,
        Func<TResult> onReviewing,
        Func<TResult> onApproved,
        Func<TResult> onRejected,
        Func<TResult> onCancelled,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Active => onActive(),
            _ when this == Repaid => onRepaid(),
            _ when this == WrittenOff => onWrittenOff(),
            _ when this == Failed => onFailed(),
            _ when this == Revoked => onRevoked(),
            _ when this == Requested => onRequested(),
            _ when this == Reviewing => onReviewing(),
            _ when this == Approved => onApproved(),
            _ when this == Rejected => onRejected(),
            _ when this == Cancelled => onCancelled(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending,
        Action onActive,
        Action onRepaid,
        Action onWrittenOff,
        Action onFailed,
        Action onRevoked,
        Action onRequested,
        Action onReviewing,
        Action onApproved,
        Action onRejected,
        Action onCancelled,
        Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Active) onActive();
        else if (this == Repaid) onRepaid();
        else if (this == WrittenOff) onWrittenOff();
        else if (this == Failed) onFailed();
        else if (this == Revoked) onRevoked();
        else if (this == Requested) onRequested();
        else if (this == Reviewing) onReviewing();
        else if (this == Approved) onApproved();
        else if (this == Rejected) onRejected();
        else if (this == Cancelled) onCancelled();
        else otherwise(Value);
    }
}
