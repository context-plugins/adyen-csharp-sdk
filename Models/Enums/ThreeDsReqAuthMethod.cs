using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Mechanism used by the Cardholder to authenticate to the 3DS Requestor. Allowed values:
/// * <b>01</b> — No 3DS Requestor authentication occurred (for example, cardholder “logged in” as guest).
/// * <b>02</b> — Login to the cardholder account at the 3DS Requestor system using 3DS Requestor’s own credentials.
/// * <b>03</b> — Login to the cardholder account at the 3DS Requestor system using federated ID.
/// * <b>04</b> — Login to the cardholder account at the 3DS Requestor system using issuer credentials.
/// * <b>05</b> — Login to the cardholder account at the 3DS Requestor system using third-party authentication.
/// * <b>06</b> — Login to the cardholder account at the 3DS Requestor system using FIDO Authenticator., Indicates whether a challenge is requested for this transaction. Possible values:
/// * <b>01</b> — No preference
/// * <b>02</b> — No challenge requested
/// * <b>03</b> — Challenge requested (3DS Requestor preference)
/// * <b>04</b> — Challenge requested (Mandate)
/// * <b>05</b> — No challenge (transactional risk analysis is already performed)
/// * <b>06</b> — Data Only
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ThreeDsReqAuthMethod>))]
public sealed record ThreeDsReqAuthMethod : StringEnum<ThreeDsReqAuthMethod>
{
    private ThreeDsReqAuthMethod(string value) : base(value)
    {
    }

    public static readonly ThreeDsReqAuthMethod _01 = new("01");

    public static readonly ThreeDsReqAuthMethod _02 = new("02");

    public static readonly ThreeDsReqAuthMethod _03 = new("03");

    public static readonly ThreeDsReqAuthMethod _04 = new("04");

    public static readonly ThreeDsReqAuthMethod _05 = new("05");

    public static readonly ThreeDsReqAuthMethod _06 = new("06");

    public static ThreeDsReqAuthMethod FromValue(string value) => FromValueCore(value);
}
