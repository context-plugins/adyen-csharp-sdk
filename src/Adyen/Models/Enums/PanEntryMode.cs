using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates the method used for entering the PAN to initiate a transaction.
/// <para>
/// Possible values: <b>manual</b>, <b>chip</b>, <b>magstripe</b>, <b>contactless</b>, <b>cof</b>, <b>ecommerce</b>, <b>token</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PanEntryMode>))]
public sealed record PanEntryMode : OpenStringEnum<PanEntryMode>
{
    private PanEntryMode(string value) : base(value)
    {
    }

    public static readonly PanEntryMode Chip = new("chip");

    public static readonly PanEntryMode Cof = new("cof");

    public static readonly PanEntryMode Contactless = new("contactless");

    public static readonly PanEntryMode Ecommerce = new("ecommerce");

    public static readonly PanEntryMode Magstripe = new("magstripe");

    public static readonly PanEntryMode Manual = new("manual");

    public static readonly PanEntryMode Token = new("token");

    public TResult Match<TResult>(Func<TResult> onChip,
        Func<TResult> onCof,
        Func<TResult> onContactless,
        Func<TResult> onEcommerce,
        Func<TResult> onMagstripe,
        Func<TResult> onManual,
        Func<TResult> onToken,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Chip => onChip(),
            _ when this == Cof => onCof(),
            _ when this == Contactless => onContactless(),
            _ when this == Ecommerce => onEcommerce(),
            _ when this == Magstripe => onMagstripe(),
            _ when this == Manual => onManual(),
            _ when this == Token => onToken(),
            _ => otherwise(Value)
        };

    public void Match(Action onChip,
        Action onCof,
        Action onContactless,
        Action onEcommerce,
        Action onMagstripe,
        Action onManual,
        Action onToken,
        Action<string> otherwise)
    {
        if (this == Chip) onChip();
        else if (this == Cof) onCof();
        else if (this == Contactless) onContactless();
        else if (this == Ecommerce) onEcommerce();
        else if (this == Magstripe) onMagstripe();
        else if (this == Manual) onManual();
        else if (this == Token) onToken();
        else otherwise(Value);
    }
}
