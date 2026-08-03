using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record UpdateStoreRequest
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public UpdatableAddress? Address { get; init; }

    /// <summary>
    /// The unique identifiers of the <see href="https://docs.adyen.com/api-explorer/#/legalentity/latest/post/businessLines__resParam_id">business lines</see> that the store is associated with.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("businessLineIds")]
    public IReadOnlyList<string>? BusinessLineIds { get; init; }

    /// <summary>
    /// The description of the store.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The unique identifier of the store, used by certain payment methods and tax authorities.
    /// <para>
    /// Required for CNPJ in Brazil, in the format 00.000.000/0000-00 separated by dots, slashes, hyphens, or without separators.
    /// </para>
    /// <para>
    /// Optional for SIRET in France, up to 14 digits.
    /// </para>
    /// <para>
    /// Optional for Zip in Australia, up to 50 digits.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("externalReferenceId")]
    public string? ExternalReferenceId { get; init; }

    /// <summary>
    /// The phone number of the store, including '+' and country code in the <see href="https://en.wikipedia.org/wiki/E.164">E.164</see> format. If passed in a different format, we convert and validate the phone number against E.164.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("splitConfiguration")]
    public StoreSplitConfiguration? SplitConfiguration { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status43? Status { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchantData")]
    public SubMerchantData? SubMerchantData { get; init; }
}
