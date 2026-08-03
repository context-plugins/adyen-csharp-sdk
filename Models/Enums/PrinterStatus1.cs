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
public sealed record PrinterStatus1 : StringEnum<PrinterStatus1>
{
    private PrinterStatus1(string value) : base(value)
    {
    }

    public static readonly PrinterStatus1 Ok = new("OK");

    public static readonly PrinterStatus1 PaperLow = new("PaperLow");

    public static readonly PrinterStatus1 NoPaper = new("NoPaper");

    public static readonly PrinterStatus1 PaperJam = new("PaperJam");

    public static readonly PrinterStatus1 OutOfOrder = new("OutOfOrder");

    public static PrinterStatus1 FromValue(string value) => FromValueCore(value);
}
