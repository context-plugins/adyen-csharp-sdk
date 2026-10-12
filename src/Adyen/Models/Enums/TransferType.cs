using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of transfer to which the limit applies. Possible values:
/// * <b>instant</b>: the limit applies to transfers with an <b>instant</b> priority.
/// * <b>all</b>: the limit applies to all transfers, regardless of priority.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TransferType>))]
public sealed record TransferType : OpenStringEnum<TransferType>
{
    private TransferType(string value) : base(value)
    {
    }

    public static readonly TransferType Instant = new("instant");

    public static readonly TransferType All = new("all");

    public TResult Match<TResult>(Func<TResult> onInstant, Func<TResult> onAll, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Instant => onInstant(),
            _ when this == All => onAll(),
            _ => otherwise(Value)
        };

    public void Match(Action onInstant, Action onAll, Action<string> otherwise)
    {
        if (this == Instant) onInstant();
        else if (this == All) onAll();
        else otherwise(Value);
    }
}
