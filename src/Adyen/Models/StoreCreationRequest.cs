using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record StoreCreationRequest
{
    /// <summary>
    /// The address of the store.
    /// </summary>
    [JsonPropertyName("address")]
    public required StoreLocation1 Address { get; init; }

    /// <summary>
    /// The unique identifiers of the <see href="https://docs.adyen.com/api-explorer/legalentity/latest/post/businessLines#responses-200-id">business lines</see> that the store is associated with.
    /// If not specified, the business line of the merchant account is used. Required when there are multiple business lines under the merchant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("businessLineIds")]
    public IReadOnlyList<string>? BusinessLineIds { get; init; }

    /// <summary>
    /// Your description of the store.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

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
    /// Localized information about the store.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("localizedInformation")]
    public LocalizedInformation2? LocalizedInformation { get; init; }

    /// <summary>
    /// The phone number of the store, including '+' and country code in the <see href="https://en.wikipedia.org/wiki/E.164">E.164</see> format. If passed in a different format, we convert and validate the phone number against E.164.
    /// </summary>
    [JsonPropertyName("phoneNumber")]
    public required string PhoneNumber { get; init; }

    /// <summary>
    /// Your reference to recognize the store by. Also known as the store code.
    ///  Allowed characters: lowercase and uppercase letters without diacritics, numbers 0 through 9, hyphen (-), and underscore (_).
    /// <para>
    /// If you do not provide a reference in your POST request, it is populated with the Adyen-generated <see href="https://docs.adyen.com/api-explorer/Management/latest/post/stores#responses-200-id">id</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    /// <summary>
    /// The store name to be shown on the shopper's bank or credit card statement and on the shopper receipt.
    /// Maximum length: 22 characters; can't be all numbers.
    /// </summary>
    [JsonPropertyName("shopperStatement")]
    public required string ShopperStatement { get; init; }

    /// <summary>
    /// Rules for Adyen for Platforms merchants to split the transaction amount and fees.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("splitConfiguration")]
    public StoreSplitConfiguration1? SplitConfiguration { get; init; }

    /// <summary>
    /// The sub-merchant data relevant for registered payment facilitators transacting on standalone terminals.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchantData")]
    public SubMerchantData1? SubMerchantData { get; init; }
}
