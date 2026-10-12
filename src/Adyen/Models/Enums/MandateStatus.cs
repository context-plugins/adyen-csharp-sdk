using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<MandateStatus>))]
public sealed record MandateStatus : OpenStringEnum<MandateStatus>
{
    private MandateStatus(string value) : base(value)
    {
    }

    public static readonly MandateStatus Pending = new("pending");

    public static readonly MandateStatus Approved = new("approved");

    public static readonly MandateStatus Cancelled = new("cancelled");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onApproved,
        Func<TResult> onCancelled,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Approved => onApproved(),
            _ when this == Cancelled => onCancelled(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending, Action onApproved, Action onCancelled, Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Approved) onApproved();
        else if (this == Cancelled) onCancelled();
        else otherwise(Value);
    }
}
