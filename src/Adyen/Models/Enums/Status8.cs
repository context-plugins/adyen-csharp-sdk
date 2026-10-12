using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the store. Possible values: <b>Pending</b>, <b>Active</b>, <b>Inactive</b>, <b>InactiveWithModifications</b>, <b>Closed</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status8>))]
public sealed record Status8 : OpenStringEnum<Status8>
{
    private Status8(string value) : base(value)
    {
    }

    public static readonly Status8 Active = new("Active");

    public static readonly Status8 Closed = new("Closed");

    public static readonly Status8 Inactive = new("Inactive");

    public static readonly Status8 InactiveWithModifications = new("InactiveWithModifications");

    public static readonly Status8 Pending = new("Pending");

    public TResult Match<TResult>(Func<TResult> onActive,
        Func<TResult> onClosed,
        Func<TResult> onInactive,
        Func<TResult> onInactiveWithModifications,
        Func<TResult> onPending,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Active => onActive(),
            _ when this == Closed => onClosed(),
            _ when this == Inactive => onInactive(),
            _ when this == InactiveWithModifications => onInactiveWithModifications(),
            _ when this == Pending => onPending(),
            _ => otherwise(Value)
        };

    public void Match(Action onActive,
        Action onClosed,
        Action onInactive,
        Action onInactiveWithModifications,
        Action onPending,
        Action<string> otherwise)
    {
        if (this == Active) onActive();
        else if (this == Closed) onClosed();
        else if (this == Inactive) onInactive();
        else if (this == InactiveWithModifications) onInactiveWithModifications();
        else if (this == Pending) onPending();
        else otherwise(Value);
    }
}
