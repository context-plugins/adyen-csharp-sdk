using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Mechanism used by the Cardholder to previously authenticate to the 3DS Requestor. Allowed values:
/// * <b>01</b> — Frictionless authentication occurred by ACS.
/// * <b>02</b> — Cardholder challenge occurred by ACS.
/// * <b>03</b> — AVS verified.
/// * <b>04</b> — Other issuer methods.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ThreeDsReqPriorAuthMethod>))]
public sealed record ThreeDsReqPriorAuthMethod : StringEnum<ThreeDsReqPriorAuthMethod>
{
    private ThreeDsReqPriorAuthMethod(string value) : base(value)
    {
    }

    public static readonly ThreeDsReqPriorAuthMethod _01 = new("01");

    public static readonly ThreeDsReqPriorAuthMethod _02 = new("02");

    public static readonly ThreeDsReqPriorAuthMethod _03 = new("03");

    public static readonly ThreeDsReqPriorAuthMethod _04 = new("04");

    public static ThreeDsReqPriorAuthMethod FromValue(string value) => FromValueCore(value);
}
