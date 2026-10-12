using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the account.
/// &gt;Permitted values: <c>Active</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status42>))]
public sealed record Status42 : OpenStringEnum<Status42>
{
    private Status42(string value) : base(value)
    {
    }

    public static readonly Status42 Active = new("Active");

    public static readonly Status42 Closed = new("Closed");

    public static readonly Status42 Inactive = new("Inactive");

    public static readonly Status42 Suspended = new("Suspended");

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
