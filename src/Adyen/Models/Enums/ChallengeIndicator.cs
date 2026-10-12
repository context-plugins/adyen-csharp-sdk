using System;
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
public sealed record ChallengeIndicator : OpenStringEnum<ChallengeIndicator>
{
    private ChallengeIndicator(string value) : base(value)
    {
    }

    public static readonly ChallengeIndicator NoPreference = new("noPreference");

    public static readonly ChallengeIndicator RequestNoChallenge = new("requestNoChallenge");

    public static readonly ChallengeIndicator RequestChallenge = new("requestChallenge");

    public static readonly ChallengeIndicator RequestChallengeAsMandate = new("requestChallengeAsMandate");

    public TResult Match<TResult>(Func<TResult> onNoPreference,
        Func<TResult> onRequestNoChallenge,
        Func<TResult> onRequestChallenge,
        Func<TResult> onRequestChallengeAsMandate,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NoPreference => onNoPreference(),
            _ when this == RequestNoChallenge => onRequestNoChallenge(),
            _ when this == RequestChallenge => onRequestChallenge(),
            _ when this == RequestChallengeAsMandate => onRequestChallengeAsMandate(),
            _ => otherwise(Value)
        };

    public void Match(Action onNoPreference,
        Action onRequestNoChallenge,
        Action onRequestChallenge,
        Action onRequestChallengeAsMandate,
        Action<string> otherwise)
    {
        if (this == NoPreference) onNoPreference();
        else if (this == RequestNoChallenge) onRequestNoChallenge();
        else if (this == RequestChallenge) onRequestChallenge();
        else if (this == RequestChallengeAsMandate) onRequestChallengeAsMandate();
        else otherwise(Value);
    }
}
