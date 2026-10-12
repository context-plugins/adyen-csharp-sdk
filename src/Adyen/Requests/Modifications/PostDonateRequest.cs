using Adyen.Models;

namespace Adyen.Requests.Modifications;

/// <summary>
/// The inputs of the PostDonate operation.
/// </summary>
public sealed record PostDonateRequest
{
    public DonationRequest? Body { get; init; }
}
