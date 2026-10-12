using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the store. Possible values are:
/// <list type="bullet">
///   <item><description><b>active</b>. This value is assigned automatically when a store is created.</description></item>
///   <item><description><b>inactive</b>. The terminals under the store are blocked from accepting new transactions, but capturing outstanding transactions is still possible.</description></item>
///   <item><description><b>closed</b>. This status is irreversible. The terminals under the store are reassigned to the merchant inventory.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status11>))]
public sealed record Status11 : OpenStringEnum<Status11>
{
    private Status11(string value) : base(value)
    {
    }

    public static readonly Status11 Active = new("active");

    public static readonly Status11 Closed = new("closed");

    public static readonly Status11 Inactive = new("inactive");

    public TResult Match<TResult>(Func<TResult> onActive,
        Func<TResult> onClosed,
        Func<TResult> onInactive,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Active => onActive(),
            _ when this == Closed => onClosed(),
            _ when this == Inactive => onInactive(),
            _ => otherwise(Value)
        };

    public void Match(Action onActive, Action onClosed, Action onInactive, Action<string> otherwise)
    {
        if (this == Active) onActive();
        else if (this == Closed) onClosed();
        else if (this == Inactive) onInactive();
        else otherwise(Value);
    }
}
