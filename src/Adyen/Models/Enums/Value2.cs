using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Value2>))]
public sealed record Value2 : OpenStringEnum<Value2>
{
    private Value2(string value) : base(value)
    {
    }

    public static readonly Value2 Barcode = new("barcode");

    public static readonly Value2 Chip = new("chip");

    public static readonly Value2 Cof = new("cof");

    public static readonly Value2 Contactless = new("contactless");

    public static readonly Value2 Magstripe = new("magstripe");

    public static readonly Value2 Manual = new("manual");

    public static readonly Value2 Ocr = new("ocr");

    public static readonly Value2 Server = new("server");

    public static readonly Value2 Unknown = new("unknown");

    public TResult Match<TResult>(Func<TResult> onBarcode,
        Func<TResult> onChip,
        Func<TResult> onCof,
        Func<TResult> onContactless,
        Func<TResult> onMagstripe,
        Func<TResult> onManual,
        Func<TResult> onOcr,
        Func<TResult> onServer,
        Func<TResult> onUnknown,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Barcode => onBarcode(),
            _ when this == Chip => onChip(),
            _ when this == Cof => onCof(),
            _ when this == Contactless => onContactless(),
            _ when this == Magstripe => onMagstripe(),
            _ when this == Manual => onManual(),
            _ when this == Ocr => onOcr(),
            _ when this == Server => onServer(),
            _ when this == Unknown => onUnknown(),
            _ => otherwise(Value)
        };

    public void Match(Action onBarcode,
        Action onChip,
        Action onCof,
        Action onContactless,
        Action onMagstripe,
        Action onManual,
        Action onOcr,
        Action onServer,
        Action onUnknown,
        Action<string> otherwise)
    {
        if (this == Barcode) onBarcode();
        else if (this == Chip) onChip();
        else if (this == Cof) onCof();
        else if (this == Contactless) onContactless();
        else if (this == Magstripe) onMagstripe();
        else if (this == Manual) onManual();
        else if (this == Ocr) onOcr();
        else if (this == Server) onServer();
        else if (this == Unknown) onUnknown();
        else otherwise(Value);
    }
}
