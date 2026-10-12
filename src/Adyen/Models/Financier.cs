using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Financier
{
    /// <summary>
    /// The amount of the funds the financier provided.
    /// </summary>
    [JsonPropertyName("amount")]
    public required PatchableAmountDto Amount { get; init; }

    /// <summary>
    /// The financier's first name.
    /// </summary>
    [JsonPropertyName("firstName")]
    public required string FirstName { get; init; }

    /// <summary>
    /// The financier's last name.
    /// </summary>
    [JsonPropertyName("lastName")]
    public required string LastName { get; init; }

    /// <summary>
    /// The city and country/region where the financier is currently located. For example: Chicago, USA
    /// </summary>
    [JsonPropertyName("location")]
    public required string Location { get; init; }
}
