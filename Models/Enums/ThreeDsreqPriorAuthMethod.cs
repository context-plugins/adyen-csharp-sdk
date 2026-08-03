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
[JsonConverter(typeof(StringEnumConverter<ThreeDsreqPriorAuthMethod>))]
public sealed record ThreeDsreqPriorAuthMethod : StringEnum<ThreeDsreqPriorAuthMethod>
{
    private ThreeDsreqPriorAuthMethod(string value) : base(value)
    {
    }

    public static readonly ThreeDsreqPriorAuthMethod _01 = new("01");

    public static readonly ThreeDsreqPriorAuthMethod _02 = new("02");

    public static readonly ThreeDsreqPriorAuthMethod _03 = new("03");

    public static readonly ThreeDsreqPriorAuthMethod _04 = new("04");

    public static ThreeDsreqPriorAuthMethod FromValue(string value) => FromValueCore(value);
}
