using Adyen.Models;

namespace Adyen.Requests.Donations;

/// <summary>
/// The inputs of the PostDonationCampaigns operation.
/// </summary>
public sealed record PostDonationCampaignsRequest
{
    /// <summary>
    /// A unique identifier for the message with a maximum of 64 characters (we recommend a UUID).
    /// </summary>
    public string? IdempotencyKey { get; init; }

    public DonationCampaignsRequest? Body { get; init; }
}
