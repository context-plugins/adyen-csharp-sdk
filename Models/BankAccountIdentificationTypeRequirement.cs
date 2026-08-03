using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record BankAccountIdentificationTypeRequirement
{
    /// <summary>
    /// List of bank account identification types: eg.; [iban , numberAndBic]
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankAccountIdentificationTypes")]
    public IReadOnlyList<BankAccountIdentificationType>? BankAccountIdentificationTypes { get; init; }

    /// <summary>
    /// Specifies the bank account details for a particular route per required field in this object depending on the country of the bank account and the currency of the transfer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// <b>bankAccountIdentificationTypeRequirement</b>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type293 Type { get; init; }
}
