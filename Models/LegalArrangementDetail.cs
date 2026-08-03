using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record LegalArrangementDetail
{
    [JsonPropertyName("address")]
    public required ViasAddress Address { get; init; }

    /// <summary>
    /// Adyen-generated unique alphanumeric identifier (UUID) for the entry, returned in the response when you create a legal arrangement.
    /// Use only when updating an account holder. If you include this field when creating an account holder, the request will fail.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalArrangementCode")]
    public string? LegalArrangementCode { get; init; }

    /// <summary>
    /// An array containing information about other entities that are part of the legal arrangement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalArrangementEntities")]
    public IReadOnlyList<LegalArrangementEntityDetail>? LegalArrangementEntities { get; init; }

    /// <summary>
    /// Your reference for the legal arrangement. Must be between 3 to 128 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalArrangementReference")]
    public string? LegalArrangementReference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalForm")]
    public LegalForm? LegalForm { get; init; }

    /// <summary>
    /// The legal name of the legal arrangement. Minimum length: 3 characters.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The registration number of the legal arrangement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("registrationNumber")]
    public string? RegistrationNumber { get; init; }

    /// <summary>
    /// The tax identification number of the legal arrangement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("taxNumber")]
    public string? TaxNumber { get; init; }

    [JsonPropertyName("type")]
    public required Type1 Type { get; init; }
}
