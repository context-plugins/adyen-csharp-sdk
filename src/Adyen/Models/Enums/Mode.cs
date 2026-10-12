using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates the type of front end integration. Possible values:
/// * <b>embedded</b> (default): Drop-in or Components integration
/// * <b>hosted</b>: Hosted Checkout integration
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Mode>))]
public sealed record Mode : OpenStringEnum<Mode>
{
    private Mode(string value) : base(value)
    {
    }

    public static readonly Mode Embedded = new("embedded");

    public static readonly Mode Hosted = new("hosted");

    public TResult Match<TResult>(Func<TResult> onEmbedded, Func<TResult> onHosted, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Embedded => onEmbedded(),
            _ when this == Hosted => onHosted(),
            _ => otherwise(Value)
        };

    public void Match(Action onEmbedded, Action onHosted, Action<string> otherwise)
    {
        if (this == Embedded) onEmbedded();
        else if (this == Hosted) onHosted();
        else otherwise(Value);
    }
}
