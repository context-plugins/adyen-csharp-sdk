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
/// * <b>06</b> — Login to the cardholder account at the 3DS Requestor system using FIDO Authenticator.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ThreeDsreqAuthMethod>))]
public sealed record ThreeDsreqAuthMethod : StringEnum<ThreeDsreqAuthMethod>
{
    private ThreeDsreqAuthMethod(string value) : base(value)
    {
    }

    public static readonly ThreeDsreqAuthMethod _01 = new("01");

    public static readonly ThreeDsreqAuthMethod _02 = new("02");

    public static readonly ThreeDsreqAuthMethod _03 = new("03");

    public static readonly ThreeDsreqAuthMethod _04 = new("04");

    public static readonly ThreeDsreqAuthMethod _05 = new("05");

    public static readonly ThreeDsreqAuthMethod _06 = new("06");

    public static ThreeDsreqAuthMethod FromValue(string value) => FromValueCore(value);
}
