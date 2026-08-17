using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Qualification of the information to sent to an output logical device, to display or print to the Cashier or the Customer.
/// Copy.
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
[JsonConverter(typeof(StringEnumConverter<InfoQualify3>))]
public sealed record InfoQualify3 : StringEnum<InfoQualify3>
{
    private InfoQualify3(string value) : base(value)
    {
    }

    public static readonly InfoQualify3 Status = new("Status");

    public static readonly InfoQualify3 Error = new("Error");

    public static readonly InfoQualify3 Display = new("Display");

    public static readonly InfoQualify3 Sound = new("Sound");

    public static readonly InfoQualify3 Input = new("Input");

    public static readonly InfoQualify3 PoiReplication = new("POIReplication");

    public static readonly InfoQualify3 CustomerAssistance = new("CustomerAssistance");

    public static readonly InfoQualify3 Receipt = new("Receipt");

    public static readonly InfoQualify3 Document = new("Document");

    public static readonly InfoQualify3 Voucher = new("Voucher");

    public static InfoQualify3 FromValue(string value) => FromValueCore(value);
}
