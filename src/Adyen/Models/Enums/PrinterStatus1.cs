using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>NoPaper</b>
/// * <b>OK</b>
/// * <b>OutOfOrder</b>
/// * <b>PaperJam</b>
/// * <b>PaperLow</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PrinterStatus1>))]
public sealed record PrinterStatus1 : OpenStringEnum<PrinterStatus1>
{
    private PrinterStatus1(string value) : base(value)
    {
    }

    public static readonly PrinterStatus1 Ok = new("OK");

    public static readonly PrinterStatus1 PaperLow = new("PaperLow");

    public static readonly PrinterStatus1 NoPaper = new("NoPaper");

    public static readonly PrinterStatus1 PaperJam = new("PaperJam");

    public static readonly PrinterStatus1 OutOfOrder = new("OutOfOrder");

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
