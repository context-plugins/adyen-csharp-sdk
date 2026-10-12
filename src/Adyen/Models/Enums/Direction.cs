using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The direction of the transfer.
/// <para>
/// Possible values: <b>incoming</b>, <b>outgoing</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Direction>))]
public sealed record Direction : OpenStringEnum<Direction>
{
    private Direction(string value) : base(value)
    {
    }

    public static readonly Direction Incoming = new("incoming");

    public static readonly Direction Outgoing = new("outgoing");

    public TResult Match<TResult>(Func<TResult> onIncoming,
        Func<TResult> onOutgoing,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Incoming => onIncoming(),
            _ when this == Outgoing => onOutgoing(),
            _ => otherwise(Value)
        };

    public void Match(Action onIncoming, Action onOutgoing, Action<string> otherwise)
    {
        if (this == Incoming) onIncoming();
        else if (this == Outgoing) onOutgoing();
        else otherwise(Value);
    }
}
