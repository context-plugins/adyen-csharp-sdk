using System.Text.Json.Serialization;

namespace Adyen.Models;

public record UltimateParentCompany
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public ViasAddress? Address { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("businessDetails")]
    public UltimateParentCompanyBusinessDetails? BusinessDetails { get; init; }

    /// <summary>
    /// Adyen-generated unique alphanumeric identifier (UUID) for the entry, returned in the response when you create an ultimate parent company. Required when updating an existing entry in an <c>/updateAccountHolder</c> request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ultimateParentCompanyCode")]
    public string? UltimateParentCompanyCode { get; init; }
}
