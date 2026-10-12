using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the balance account. Payment instruments linked to the balance account can only be used if the balance account status is <b>active</b>.
/// <para>
/// Possible values: <b>active</b>, <b>closed</b>, <b>suspended</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status43>))]
public sealed record Status43 : OpenStringEnum<Status43>
{
    private Status43(string value) : base(value)
    {
    }

    public static readonly Status43 Active = new("active");

    public static readonly Status43 Closed = new("closed");

    public static readonly Status43 Inactive = new("inactive");

    public static readonly Status43 Suspended = new("suspended");

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
