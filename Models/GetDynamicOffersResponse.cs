using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record GetDynamicOffersResponse
{
    /// <summary>
    /// Contains a list of available dynamic offers for the specified account holder.
    /// </summary>
    [JsonPropertyName("dynamicOffers")]
    public required IReadOnlyList<DynamicOffer> DynamicOffers { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
