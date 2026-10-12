using Adyen.Models;

namespace Adyen.Requests.HostedOnboardingPage;

/// <summary>
/// The inputs of the PostGetOnboardingUrl operation.
/// </summary>
public sealed record PostGetOnboardingUrlRequest
{
    public GetOnboardingUrlRequest? Body { get; init; }
}
