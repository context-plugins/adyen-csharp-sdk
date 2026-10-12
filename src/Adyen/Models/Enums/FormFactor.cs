using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Business accounts with a <c>formFactor</c> value of <b>physical</b> are business accounts issued under the central bank of that country. The default value is <b>physical</b> for NL, US, and UK business accounts.
/// <para>
/// Adyen creates a local IBAN for business accounts when the <c>formFactor</c> value is set to <b>virtual</b>. The local IBANs that are supported are for DE and FR, which reference a physical NL account, with funds being routed through the central bank of NL.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FormFactor>))]
public sealed record FormFactor : OpenStringEnum<FormFactor>
{
    private FormFactor(string value) : base(value)
    {
    }

    public static readonly FormFactor Physical = new("physical");

    public static readonly FormFactor Unknown = new("unknown");

    public static readonly FormFactor Virtual = new("virtual");

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
