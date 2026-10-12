using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates if the printer is working and usable.
/// Possible values:
/// * <b>OK</b>
/// * <b>PaperLow</b>
/// * <b>NoPaper</b>
/// * <b>PaperJam</b>
/// * <b>OutOfOrder</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PrinterStatus>))]
public sealed record PrinterStatus : OpenStringEnum<PrinterStatus>
{
    private PrinterStatus(string value) : base(value)
    {
    }

    public static readonly PrinterStatus Ok = new("OK");

    public static readonly PrinterStatus PaperLow = new("PaperLow");

    public static readonly PrinterStatus NoPaper = new("NoPaper");

    public static readonly PrinterStatus PaperJam = new("PaperJam");

    public static readonly PrinterStatus OutOfOrder = new("OutOfOrder");

    public TResult Match<TResult>(Func<TResult> onOk,
        Func<TResult> onPaperLow,
        Func<TResult> onNoPaper,
        Func<TResult> onPaperJam,
        Func<TResult> onOutOfOrder,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ok => onOk(),
            _ when this == PaperLow => onPaperLow(),
            _ when this == NoPaper => onNoPaper(),
            _ when this == PaperJam => onPaperJam(),
            _ when this == OutOfOrder => onOutOfOrder(),
            _ => otherwise(Value)
        };

    public void Match(Action onOk,
        Action onPaperLow,
        Action onNoPaper,
        Action onPaperJam,
        Action onOutOfOrder,
        Action<string> otherwise)
    {
        if (this == Ok) onOk();
        else if (this == PaperLow) onPaperLow();
        else if (this == NoPaper) onNoPaper();
        else if (this == PaperJam) onPaperJam();
        else if (this == OutOfOrder) onOutOfOrder();
        else otherwise(Value);
    }
}
