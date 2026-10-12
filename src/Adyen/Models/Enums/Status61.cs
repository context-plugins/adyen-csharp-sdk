using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the card order.
/// <para>
/// Possible values: <b>Open</b>, <b>Closed</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status61>))]
public sealed record Status61 : OpenStringEnum<Status61>
{
    private Status61(string value) : base(value)
    {
    }

    public static readonly Status61 Closed = new("closed");

    public static readonly Status61 Open = new("open");

    public TResult Match<TResult>(Func<TResult> onClosed, Func<TResult> onOpen, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Closed => onClosed(),
            _ when this == Open => onOpen(),
            _ => otherwise(Value)
        };

    public void Match(Action onClosed, Action onOpen, Action<string> otherwise)
    {
        if (this == Closed) onClosed();
        else if (this == Open) onOpen();
        else otherwise(Value);
    }
}
