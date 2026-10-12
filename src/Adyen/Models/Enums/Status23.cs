using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the balance account, set to <b>active</b> by default.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status23>))]
public sealed record Status23 : OpenStringEnum<Status23>
{
    private Status23(string value) : base(value)
    {
    }

    public static readonly Status23 Active = new("active");

    public static readonly Status23 Closed = new("closed");

    public static readonly Status23 Inactive = new("inactive");

    public static readonly Status23 Suspended = new("suspended");

    public TResult Match<TResult>(Func<TResult> onActive,
        Func<TResult> onClosed,
        Func<TResult> onInactive,
        Func<TResult> onSuspended,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Active => onActive(),
            _ when this == Closed => onClosed(),
            _ when this == Inactive => onInactive(),
            _ when this == Suspended => onSuspended(),
            _ => otherwise(Value)
        };

    public void Match(Action onActive, Action onClosed, Action onInactive, Action onSuspended, Action<string> otherwise)
    {
        if (this == Active) onActive();
        else if (this == Closed) onClosed();
        else if (this == Inactive) onInactive();
        else if (this == Suspended) onSuspended();
        else otherwise(Value);
    }
}
