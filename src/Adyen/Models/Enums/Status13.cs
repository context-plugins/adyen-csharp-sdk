using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the request for PIN change.
/// <para>
/// Possible values: <b>completed</b>, <b>pending</b>, <b>unavailable</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status13>))]
public sealed record Status13 : OpenStringEnum<Status13>
{
    private Status13(string value) : base(value)
    {
    }

    public static readonly Status13 Completed = new("completed");

    public static readonly Status13 Pending = new("pending");

    public static readonly Status13 Unavailable = new("unavailable");

    public TResult Match<TResult>(Func<TResult> onCompleted,
        Func<TResult> onPending,
        Func<TResult> onUnavailable,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Completed => onCompleted(),
            _ when this == Pending => onPending(),
            _ when this == Unavailable => onUnavailable(),
            _ => otherwise(Value)
        };

    public void Match(Action onCompleted, Action onPending, Action onUnavailable, Action<string> otherwise)
    {
        if (this == Completed) onCompleted();
        else if (this == Pending) onPending();
        else if (this == Unavailable) onUnavailable();
        else otherwise(Value);
    }
}
