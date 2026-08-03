using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Company
{
    /// <summary>
    /// The company website's home page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("homepage")]
    public string? Homepage { get; init; }

    /// <summary>
    /// The company name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Registration number of the company.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("registrationNumber")]
    public string? RegistrationNumber { get; init; }

    /// <summary>
    /// Registry location of the company.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("registryLocation")]
    public string? RegistryLocation { get; init; }

    /// <summary>
    /// Tax ID of the company.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxId")]
    public string? TaxId { get; init; }

    /// <summary>
    /// The company type.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public string? Type { get; init; }
}
