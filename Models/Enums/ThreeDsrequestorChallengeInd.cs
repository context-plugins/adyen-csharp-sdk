using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates whether a challenge is requested for this transaction. Possible values:
/// * <b>01</b> — No preference
/// * <b>02</b> — No challenge requested
/// * <b>03</b> — Challenge requested (3DS Requestor preference)
/// * <b>04</b> — Challenge requested (Mandate)
/// * <b>05</b> — No challenge (transactional risk analysis is already performed)
/// * <b>06</b> — Data Only
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ThreeDsrequestorChallengeInd>))]
public sealed record ThreeDsrequestorChallengeInd : StringEnum<ThreeDsrequestorChallengeInd>
{
    private ThreeDsrequestorChallengeInd(string value) : base(value)
    {
    }

    public static readonly ThreeDsrequestorChallengeInd _01 = new("01");

    public static readonly ThreeDsrequestorChallengeInd _02 = new("02");

    public static readonly ThreeDsrequestorChallengeInd _03 = new("03");

    public static readonly ThreeDsrequestorChallengeInd _04 = new("04");

    public static readonly ThreeDsrequestorChallengeInd _05 = new("05");

    public static readonly ThreeDsrequestorChallengeInd _06 = new("06");

    public static ThreeDsrequestorChallengeInd FromValue(string value) => FromValueCore(value);
}
