using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Qualification of the information to send to an output logical device, to display or print to the Cashier or the Customer.
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
[JsonConverter(typeof(StringEnumConverter<InfoQualify2>))]
public sealed record InfoQualify2 : StringEnum<InfoQualify2>
{
    private InfoQualify2(string value) : base(value)
    {
    }

    public static readonly InfoQualify2 Status = new("Status");

    public static readonly InfoQualify2 Error = new("Error");

    public static readonly InfoQualify2 Display = new("Display");

    public static readonly InfoQualify2 Sound = new("Sound");

    public static readonly InfoQualify2 Input = new("Input");

    public static readonly InfoQualify2 PoiReplication = new("POIReplication");

    public static readonly InfoQualify2 CustomerAssistance = new("CustomerAssistance");

    public static readonly InfoQualify2 Receipt = new("Receipt");

    public static readonly InfoQualify2 Document = new("Document");

    public static readonly InfoQualify2 Voucher = new("Voucher");

    public static InfoQualify2 FromValue(string value) => FromValueCore(value);
}
