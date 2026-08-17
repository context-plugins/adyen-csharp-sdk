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
[JsonConverter(typeof(StringEnumConverter<PinRequestType>))]
public sealed record PinRequestType : StringEnum<PinRequestType>
{
    private PinRequestType(string value) : base(value)
    {
    }

    public static readonly PinRequestType PinVerify = new("PINVerify");

    public static readonly PinRequestType PinVerifyOnly = new("PINVerifyOnly");

    public static readonly PinRequestType PinEnter = new("PINEnter");

    public static PinRequestType FromValue(string value) => FromValueCore(value);
}
