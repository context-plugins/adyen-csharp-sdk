using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<EntryMode>))]
public sealed record EntryMode : OpenStringEnum<EntryMode>
{
    private EntryMode(string value) : base(value)
    {
    }

    public static readonly EntryMode Rfid = new("RFID");

    public static readonly EntryMode Keyed = new("Keyed");

    public static readonly EntryMode Manual = new("Manual");

    public static readonly EntryMode File = new("File");

    public static readonly EntryMode Scanned = new("Scanned");

    public static readonly EntryMode MagStripe = new("MagStripe");

    public static readonly EntryMode Icc = new("ICC");

    public static readonly EntryMode SynchronousIcc = new("SynchronousICC");

    public static readonly EntryMode Tapped = new("Tapped");

    public static readonly EntryMode Contactless = new("Contactless");

    public static readonly EntryMode Mobile = new("Mobile");

    public TResult Match<TResult>(Func<TResult> onRfid,
        Func<TResult> onKeyed,
        Func<TResult> onManual,
        Func<TResult> onFile,
        Func<TResult> onScanned,
        Func<TResult> onMagStripe,
        Func<TResult> onIcc,
        Func<TResult> onSynchronousIcc,
        Func<TResult> onTapped,
        Func<TResult> onContactless,
        Func<TResult> onMobile,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Rfid => onRfid(),
            _ when this == Keyed => onKeyed(),
            _ when this == Manual => onManual(),
            _ when this == File => onFile(),
            _ when this == Scanned => onScanned(),
            _ when this == MagStripe => onMagStripe(),
            _ when this == Icc => onIcc(),
            _ when this == SynchronousIcc => onSynchronousIcc(),
            _ when this == Tapped => onTapped(),
            _ when this == Contactless => onContactless(),
            _ when this == Mobile => onMobile(),
            _ => otherwise(Value)
        };

    public void Match(Action onRfid,
        Action onKeyed,
        Action onManual,
        Action onFile,
        Action onScanned,
        Action onMagStripe,
        Action onIcc,
        Action onSynchronousIcc,
        Action onTapped,
        Action onContactless,
        Action onMobile,
        Action<string> otherwise)
    {
        if (this == Rfid) onRfid();
        else if (this == Keyed) onKeyed();
        else if (this == Manual) onManual();
        else if (this == File) onFile();
        else if (this == Scanned) onScanned();
        else if (this == MagStripe) onMagStripe();
        else if (this == Icc) onIcc();
        else if (this == SynchronousIcc) onSynchronousIcc();
        else if (this == Tapped) onTapped();
        else if (this == Contactless) onContactless();
        else if (this == Mobile) onMobile();
        else otherwise(Value);
    }
}
