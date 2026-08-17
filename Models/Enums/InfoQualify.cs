using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>Status</b>
/// * <b>Error</b>
/// * <b>Display</b>
/// * <b>Sound</b>
/// * <b>Input</b>
/// * <b>POIReplication</b>
/// * <b>CustomerAssistance</b>
/// * <b>Receipt</b>
/// * <b>Document</b>
/// * <b>Voucher</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InfoQualify>))]
public sealed record InfoQualify : StringEnum<InfoQualify>
{
    private InfoQualify(string value) : base(value)
    {
    }

    public static readonly InfoQualify Status = new("Status");

    public static readonly InfoQualify Error = new("Error");

    public static readonly InfoQualify Display = new("Display");

    public static readonly InfoQualify Sound = new("Sound");

    public static readonly InfoQualify Input = new("Input");

    public static readonly InfoQualify PoiReplication = new("POIReplication");

    public static readonly InfoQualify CustomerAssistance = new("CustomerAssistance");

    public static readonly InfoQualify Receipt = new("Receipt");

    public static readonly InfoQualify Document = new("Document");

    public static readonly InfoQualify Voucher = new("Voucher");

    public static InfoQualify FromValue(string value) => FromValueCore(value);
}
