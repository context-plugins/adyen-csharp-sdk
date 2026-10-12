using System.ComponentModel.DataAnnotations;
using Adyen.Models;

namespace Adyen.Requests.DynamicOffers;

/// <summary>
/// The inputs of the PostDynamicOffersIdCalculate operation.
/// </summary>
public sealed record PostDynamicOffersIdCalculateRequest
{
    /// <summary>
    /// The unique identifier of the dynamic offer from which the user selected the financing amount.
    /// </summary>
    [MinLength(1)]
    public required string Id { get; init; }

    public CalculateGrantOfferRequest? Body { get; init; }
}
