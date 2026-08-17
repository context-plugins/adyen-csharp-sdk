using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record UpdateStoreRequest
{
    /// <summary>
    /// The address of the store. It is not possible to update the country of the store.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public UpdatableAddress1? Address { get; init; }

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

    /// <summary>
    /// Rules for Adyen for Platforms merchants to split the transaction amount and fees.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("splitConfiguration")]
    public StoreSplitConfiguration1? SplitConfiguration { get; init; }

    /// <summary>
    /// The status of the store. Possible values are:
    /// <list type="bullet">
    ///   <item><description><b>active</b>: This value is assigned automatically when a store is created.</description></item>
    ///   <item><description><b>inactive</b>: The maximum <see href="https://docs.adyen.com/point-of-sale/determine-account-structure/configure-features#payment-features">transaction limits and number of Store-and-Forward transactions</see> for the store are set to 0. This blocks new transactions, but captures are still possible.</description></item>
    ///   <item><description><b>closed</b>: The terminals of the store are reassigned to the merchant inventory, so they can't process payments.</description></item>
    /// </list>
    /// <para>
    /// You can change the status from <b>active</b> to <b>inactive</b>, and from <b>inactive</b> to <b>active</b> or <b>closed</b>.
    /// Once <b>closed</b>, a store can't be reopened.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status41? Status { get; init; }

    /// <summary>
    /// The sub-merchant data relevant for registered payment facilitators transacting on standalone terminals.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subMerchantData")]
    public SubMerchantData1? SubMerchantData { get; init; }
}
