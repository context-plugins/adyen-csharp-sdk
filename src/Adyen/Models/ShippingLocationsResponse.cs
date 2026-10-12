using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ShippingLocationsResponse
{
    /// <summary>
    /// Physical locations where orders can be shipped to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("data")]
    public IReadOnlyList<ShippingLocation>? Data { get; init; }
}
