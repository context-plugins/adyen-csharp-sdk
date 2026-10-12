using System.ComponentModel.DataAnnotations;
using Adyen.Models;

namespace Adyen.Requests.DynamicOffers;

/// <summary>
/// The inputs of the PostDynamicOffersIdGrantOffer operation.
/// </summary>
public sealed record PostDynamicOffersIdGrantOfferRequest
{
    /// <summary>
    /// The unique identifier of the dynamic offer from which the user selected the financing amount.
    /// </summary>
    [MinLength(1)]
    public required string Id { get; init; }

    public CreateGrantOfferRequest? Body { get; init; }
}
