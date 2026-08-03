using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of PIN Service.
/// Possible values:
/// * <b>PINVerify</b>
/// * <b>PINVerifyOnly</b>
/// * <b>PINEnter</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PinrequestType>))]
public sealed record PinrequestType : StringEnum<PinrequestType>
{
    private PinrequestType(string value) : base(value)
    {
    }

    public static readonly PinrequestType Pinverify = new("PINVerify");

    public static readonly PinrequestType PinverifyOnly = new("PINVerifyOnly");

    public static readonly PinrequestType Pinenter = new("PINEnter");

    public static PinrequestType FromValue(string value) => FromValueCore(value);
}
