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
public sealed record PrinterStatus : StringEnum<PrinterStatus>
{
    private PrinterStatus(string value) : base(value)
    {
    }

    public static readonly PrinterStatus Ok = new("OK");

    public static readonly PrinterStatus PaperLow = new("PaperLow");

    public static readonly PrinterStatus NoPaper = new("NoPaper");

    public static readonly PrinterStatus PaperJam = new("PaperJam");

    public static readonly PrinterStatus OutOfOrder = new("OutOfOrder");

    public static PrinterStatus FromValue(string value) => FromValueCore(value);
}
