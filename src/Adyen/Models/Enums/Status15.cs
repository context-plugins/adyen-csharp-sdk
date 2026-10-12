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
///   <item><description><b>credited</b>: the funds are credited to your user's transfer instrument or bank account.- <b>accepted</b>: the request is accepted by the integration.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status15>))]
public sealed record Status15 : OpenStringEnum<Status15>
{
    private Status15(string value) : base(value)
    {
    }

    public static readonly Status15 Credited = new("credited");

    public static readonly Status15 Accepted = new("accepted");

    public TResult Match<TResult>(Func<TResult> onCredited,
        Func<TResult> onAccepted,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Credited => onCredited(),
            _ when this == Accepted => onAccepted(),
            _ => otherwise(Value)
        };

    public void Match(Action onCredited, Action onAccepted, Action<string> otherwise)
    {
        if (this == Credited) onCredited();
        else if (this == Accepted) onAccepted();
        else otherwise(Value);
    }
}
