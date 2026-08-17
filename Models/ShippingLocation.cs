using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ShippingLocation
{
    /// <summary>
    /// The address details of the shipping location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public Address21? Address { get; init; }

    /// <summary>
    /// The contact details for the shipping location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("contact")]
    public Contact1? Contact { get; init; }

    /// <summary>
    /// The unique identifier of the shipping location, for use as <c>shippingLocationId</c> when creating an order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The unique name of the shipping location.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
