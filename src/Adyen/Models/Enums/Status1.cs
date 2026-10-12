using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the donation transaction.
/// <para>
/// Possible values:
/// * <b>completed</b>
/// * <b>pending</b>
/// * <b>refused</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status1>))]
public sealed record Status1 : OpenStringEnum<Status1>
{
    private Status1(string value) : base(value)
    {
    }

    public static readonly Status1 Completed = new("completed");

    public static readonly Status1 Pending = new("pending");

    public static readonly Status1 Refused = new("refused");

    public TResult Match<TResult>(Func<TResult> onCompleted,
        Func<TResult> onPending,
        Func<TResult> onRefused,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Completed => onCompleted(),
            _ when this == Pending => onPending(),
            _ when this == Refused => onRefused(),
            _ => otherwise(Value)
        };

    public void Match(Action onCompleted, Action onPending, Action onRefused, Action<string> otherwise)
    {
        if (this == Completed) onCompleted();
        else if (this == Pending) onPending();
        else if (this == Refused) onRefused();
        else otherwise(Value);
    }
}
