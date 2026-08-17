using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record AddressRequirement
{
    /// <summary>
    /// Specifies the required address related fields for a particular route.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// List of address fields.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requiredAddressFields")]
    public IReadOnlyList<RequiredAddressField>? RequiredAddressFields { get; init; }

    /// <summary>
    /// <b>addressRequirement</b>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "addressRequirement";
}
