using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the mandate.
/// <para>
/// Possible values: <b>pending</b>, <b>approved</b>, <b>cancelled</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MandateStatus2>))]
public sealed record MandateStatus2 : OpenStringEnum<MandateStatus2>
{
    private MandateStatus2(string value) : base(value)
    {
    }

    public static readonly MandateStatus2 Pending = new("pending");

    public static readonly MandateStatus2 Approved = new("approved");

    public static readonly MandateStatus2 Cancelled = new("cancelled");

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
