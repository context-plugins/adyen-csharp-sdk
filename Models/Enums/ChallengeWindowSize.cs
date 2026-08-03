using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Dimensions of the 3DS2 challenge window to be displayed to the cardholder.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>01</b> - size of 250x400</description></item>
///   <item><description><b>02</b> - size of 390x400</description></item>
///   <item><description><b>03</b> - size of 500x600</description></item>
///   <item><description><b>04</b> - size of 600x400</description></item>
///   <item><description><b>05</b> - Fullscreen</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ChallengeWindowSize>))]
public sealed record ChallengeWindowSize : StringEnum<ChallengeWindowSize>
{
    private ChallengeWindowSize(string value) : base(value)
    {
    }

    public static readonly ChallengeWindowSize _01 = new("01");

    public static readonly ChallengeWindowSize _02 = new("02");

    public static readonly ChallengeWindowSize _03 = new("03");

    public static readonly ChallengeWindowSize _04 = new("04");

    public static readonly ChallengeWindowSize _05 = new("05");

    public static ChallengeWindowSize FromValue(string value) => FromValueCore(value);
}
