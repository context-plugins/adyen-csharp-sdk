using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The new status of the network token. Possible values: <b>active</b>, <b>suspended</b>, <b>closed</b>. The <b>closed</b> status is final and cannot be changed.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status16>))]
public sealed record Status16 : OpenStringEnum<Status16>
{
    private Status16(string value) : base(value)
    {
    }

    public static readonly Status16 Active = new("active");

    public static readonly Status16 Suspended = new("suspended");

    public static readonly Status16 Closed = new("closed");

    public TResult Match<TResult>(Func<TResult> onActive,
        Func<TResult> onSuspended,
        Func<TResult> onClosed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Active => onActive(),
            _ when this == Suspended => onSuspended(),
            _ when this == Closed => onClosed(),
            _ => otherwise(Value)
        };

    public void Match(Action onActive, Action onSuspended, Action onClosed, Action<string> otherwise)
    {
        if (this == Active) onActive();
        else if (this == Suspended) onSuspended();
        else if (this == Closed) onClosed();
        else otherwise(Value);
    }
}
