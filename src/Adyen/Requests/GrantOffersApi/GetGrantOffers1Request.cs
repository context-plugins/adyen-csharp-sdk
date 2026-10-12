using System.ComponentModel.DataAnnotations;

namespace Adyen.Requests.GrantOffersApi;

/// <summary>
/// The inputs of the GetGrantOffers1 operation.
/// </summary>
public sealed record GetGrantOffers1Request
{
    /// <summary>
    /// The unique identifier of the account holder for which you want to get the available static offers.
    /// </summary>
    [MinLength(1)]
    public required string AccountHolderId { get; init; }
}
