using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the network token. Possible values: <b>active</b>, <b>inactive</b>, <b>suspended</b>, <b>closed</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status91>))]
public sealed record Status91 : OpenStringEnum<Status91>
{
    private Status91(string value) : base(value)
    {
    }

    public static readonly Status91 Active = new("active");

    public static readonly Status91 Inactive = new("inactive");

    public static readonly Status91 Suspended = new("suspended");

    public static readonly Status91 Closed = new("closed");

    public TResult Match<TResult>(Func<TResult> onActive,
        Func<TResult> onInactive,
        Func<TResult> onSuspended,
        Func<TResult> onClosed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Active => onActive(),
            _ when this == Inactive => onInactive(),
            _ when this == Suspended => onSuspended(),
            _ when this == Closed => onClosed(),
            _ => otherwise(Value)
        };

    public void Match(Action onActive, Action onInactive, Action onSuspended, Action onClosed, Action<string> otherwise)
    {
        if (this == Active) onActive();
        else if (this == Inactive) onInactive();
        else if (this == Suspended) onSuspended();
        else if (this == Closed) onClosed();
        else otherwise(Value);
    }
}
