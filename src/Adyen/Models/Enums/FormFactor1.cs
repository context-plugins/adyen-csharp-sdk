using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The form factor of the card.
/// Possible values: <b>virtual</b>, <b>physical</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FormFactor1>))]
public sealed record FormFactor1 : OpenStringEnum<FormFactor1>
{
    private FormFactor1(string value) : base(value)
    {
    }

    public static readonly FormFactor1 Physical = new("physical");

    public static readonly FormFactor1 Unknown = new("unknown");

    public static readonly FormFactor1 Virtual = new("virtual");

    public TResult Match<TResult>(Func<TResult> onPhysical,
        Func<TResult> onUnknown,
        Func<TResult> onVirtual,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Physical => onPhysical(),
            _ when this == Unknown => onUnknown(),
            _ when this == Virtual => onVirtual(),
            _ => otherwise(Value)
        };

    public void Match(Action onPhysical, Action onUnknown, Action onVirtual, Action<string> otherwise)
    {
        if (this == Physical) onPhysical();
        else if (this == Unknown) onUnknown();
        else if (this == Virtual) onVirtual();
        else otherwise(Value);
    }
}
