using System.Text.Json.Serialization;

namespace Adyen.Models;

public record UltimateParentCompany
{
    /// <summary>
    /// Address of the ultimate parent company.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public ViasAddress1? Address { get; init; }

    /// <summary>
    /// Details about the ultimate parent company's business.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("businessDetails")]
    public UltimateParentCompanyBusinessDetails2? BusinessDetails { get; init; }

    /// <summary>
    /// Adyen-generated unique alphanumeric identifier (UUID) for the entry, returned in the response when you create an ultimate parent company. Required when updating an existing entry in an <c>/updateAccountHolder</c> request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ultimateParentCompanyCode")]
    public string? UltimateParentCompanyCode { get; init; }
}
