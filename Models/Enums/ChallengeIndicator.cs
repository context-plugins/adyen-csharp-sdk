using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possibility to specify a preference for receiving a challenge from the issuer.
/// Allowed values:
/// * <c>noPreference</c>
/// * <c>requestNoChallenge</c>
/// * <c>requestChallenge</c>
/// * <c>requestChallengeAsMandate</c>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ChallengeIndicator>))]
public sealed record ChallengeIndicator : StringEnum<ChallengeIndicator>
{
    private ChallengeIndicator(string value) : base(value)
    {
    }

    public static readonly ChallengeIndicator NoPreference = new("noPreference");

    public static readonly ChallengeIndicator RequestNoChallenge = new("requestNoChallenge");

    public static readonly ChallengeIndicator RequestChallenge = new("requestChallenge");

    public static readonly ChallengeIndicator RequestChallengeAsMandate = new("requestChallengeAsMandate");

    public static ChallengeIndicator FromValue(string value) => FromValueCore(value);
}
