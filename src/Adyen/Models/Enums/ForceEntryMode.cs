using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ForceEntryMode>))]
public sealed record ForceEntryMode : OpenStringEnum<ForceEntryMode>
{
    private ForceEntryMode(string value) : base(value)
    {
    }

    public static readonly ForceEntryMode Rfid = new("RFID");

    public static readonly ForceEntryMode Keyed = new("Keyed");

    public static readonly ForceEntryMode Manual = new("Manual");

    public static readonly ForceEntryMode File = new("File");

    public static readonly ForceEntryMode Scanned = new("Scanned");

    public static readonly ForceEntryMode MagStripe = new("MagStripe");

    public static readonly ForceEntryMode Icc = new("ICC");

    public static readonly ForceEntryMode SynchronousIcc = new("SynchronousICC");

    public static readonly ForceEntryMode Tapped = new("Tapped");

    public static readonly ForceEntryMode Contactless = new("Contactless");

    public static readonly ForceEntryMode CheckReader = new("CheckReader");

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
        Func<TResult> onCheckReader,
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
            _ when this == CheckReader => onCheckReader(),
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
        Action onCheckReader,
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
        else if (this == CheckReader) onCheckReader();
        else otherwise(Value);
    }
}
