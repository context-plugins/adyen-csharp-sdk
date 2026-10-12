using Adyen.Models;

namespace Adyen.Requests.HostedOnboarding;

/// <summary>
/// The inputs of the PostLegalEntitiesIdOnboardingLinks operation.
/// </summary>
public sealed record PostLegalEntitiesIdOnboardingLinksRequest
{
    /// <summary>
    /// The unique identifier of the legal entity
    /// </summary>
    public required string Id { get; init; }

    public OnboardingLinkInfo? Body { get; init; }
}
