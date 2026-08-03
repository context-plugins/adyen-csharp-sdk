using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Qualification of the information to sent to an output logical device, to display or print to the Cashier or the Customer. Allows the manager of the device, Sale or POI Terminal, to send the information to a particular physical device or to present the information accordingly.
/// Possible values:
/// * <b>CustomerAssistance</b>
/// * <b>Display</b>
/// * <b>Document</b>
/// * <b>Error</b>
/// * <b>Input</b>
/// * <b>POIReplication</b>
/// * <b>Receipt</b>
/// * <b>Sound</b>
/// * <b>Status</b>
/// * <b>Voucher</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InfoQualify1>))]
public sealed record InfoQualify1 : StringEnum<InfoQualify1>
{
    private InfoQualify1(string value) : base(value)
    {
    }

    public static readonly InfoQualify1 Status = new("Status");

    public static readonly InfoQualify1 Error = new("Error");

    public static readonly InfoQualify1 Display = new("Display");

    public static readonly InfoQualify1 Sound = new("Sound");

    public static readonly InfoQualify1 Input = new("Input");

    public static readonly InfoQualify1 Poireplication = new("POIReplication");

    public static readonly InfoQualify1 CustomerAssistance = new("CustomerAssistance");

    public static readonly InfoQualify1 Receipt = new("Receipt");

    public static readonly InfoQualify1 Document = new("Document");

    public static readonly InfoQualify1 Voucher = new("Voucher");

    public static InfoQualify1 FromValue(string value) => FromValueCore(value);
}
