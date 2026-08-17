using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record TransferInstrument
{
    /// <summary>
    /// Contains information about the legal entity's bank account.
    /// </summary>
    [JsonPropertyName("bankAccount")]
    public required BankAccountInfo1 BankAccount { get; init; }

    /// <summary>
    /// List of capabilities for this transfer instrument.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("capabilities")]
    public IReadOnlyDictionary<string, SupportingEntityCapability>? Capabilities { get; init; }

    /// <summary>
    /// List of documents uploaded for the transfer instrument.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("documentDetails")]
    public IReadOnlyList<DocumentReference>? DocumentDetails { get; init; }

    /// <summary>
    /// The unique identifier of the transfer instrument.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The unique identifier of the <see href="https://docs.adyen.com/api-explorer/legalentity/latest/post/legalEntities#responses-200-id">legal entity</see> that owns the transfer instrument.
    /// </summary>
    [JsonPropertyName("legalEntityId")]
    public required string LegalEntityId { get; init; }

    /// <summary>
    /// The verification errors related to capabilities for this transfer instrument.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("problems")]
    public IReadOnlyList<CapabilityProblem1>? Problems { get; init; }

    /// <summary>
    /// The type of transfer instrument.
    /// <para>
    /// Possible value: <b>bankAccount</b>.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type221 Type { get; init; }
}
