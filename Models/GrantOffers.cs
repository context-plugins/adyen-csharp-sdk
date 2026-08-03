using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GrantOffers
{
    /// <summary>
    /// A list of available grant offers.
    /// </summary>
    [JsonPropertyName("grantOffers")]
    public required IReadOnlyList<GrantOffer> GrantOffersValue { get; init; }
}
