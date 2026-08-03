using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record BusinessLine
{
    /// <summary>
    /// The unique identifier of the business line.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// A code that represents the industry of the legal entity for <see href="https://docs.adyen.com/marketplaces/verification-requirements/reference-additional-products/#list-industry-codes">marketplaces</see> or <see href="https://docs.adyen.com/platforms/verification-requirements/reference-additional-products/#list-industry-codes">platforms</see>. For example, <b>4431A</b> for computer software stores.
    /// </summary>
    [JsonPropertyName("industryCode")]
    public required string IndustryCode { get; init; }

    /// <summary>
    /// The description of the industry code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("industryCodeDescription")]
    public string? IndustryCodeDescription { get; init; }

    /// <summary>
    /// Unique identifier of the <see href="https://docs.adyen.com/api-explorer/#/legalentity/latest/post/legalEntities__resParam_id">legal entity</see> that owns the business line.
    /// </summary>
    [JsonPropertyName("legalEntityId")]
    public required string LegalEntityId { get; init; }

    /// <summary>
    /// The verification errors related to capabilities for this supporting entity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("problems")]
    public IReadOnlyList<CapabilityProblem1>? Problems { get; init; }

    /// <summary>
    /// A list of channels where goods or services are sold.
    /// <para>
    /// Possible values: <b>pos</b>, <b>posMoto</b>, <b>eCommerce</b>, <b>ecomMoto</b>, <b>payByLink</b>.
    /// </para>
    /// <para>
    /// Required only in combination with the <c>service</c> <b>paymentProcessing</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("salesChannels")]
    public IReadOnlyList<string>? SalesChannels { get; init; }

    [JsonPropertyName("service")]
    public required Service Service { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sourceOfFunds")]
    public SourceOfFunds? SourceOfFunds { get; init; }

    /// <summary>
    /// List of website URLs where your user's goods or services are sold. When this is required for a service but your user does not have an online presence, provide the reason in the <c>webDataExemption</c> object.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webData")]
    public IReadOnlyList<WebData>? WebData { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webDataExemption")]
    public WebDataExemption? WebDataExemption { get; init; }
}
