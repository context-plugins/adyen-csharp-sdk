using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the transfer.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>pending</b>: the transfer is under internal review by Adyen.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>failed</b>: the transfer failed Adyen's internal review. For details, see <c>reason</c>.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status44>))]
public sealed record Status44 : OpenStringEnum<Status44>
{
    private Status44(string value) : base(value)
    {
    }

    public static readonly Status44 Pending = new("pending");

    public static readonly Status44 Failed = new("failed");

    public TResult Match<TResult>(Func<TResult> onPending, Func<TResult> onFailed, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Failed => onFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending, Action onFailed, Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Failed) onFailed();
        else otherwise(Value);
    }
}
