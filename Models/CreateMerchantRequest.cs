using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CreateMerchantRequest
{
    /// <summary>
    /// The unique identifier of the <see href="https://docs.adyen.com/api-explorer/#/legalentity/latest/post/businessLines">business line</see>. Required for an Adyen for Platforms Manage integration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("businessLineId")]
    public string? BusinessLineId { get; init; }

    /// <summary>
    /// The unique identifier of the company account.
    /// </summary>
    [JsonPropertyName("companyId")]
    public required string CompanyId { get; init; }

    /// <summary>
    /// Your description for the merchant account, maximum 300 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(300)]
    public string? Description { get; init; }

    /// <summary>
    /// The unique identifier of the <see href="https://docs.adyen.com/api-explorer/#/legalentity/latest/post/legalEntities">legal entity</see>. Required for an Adyen for Platforms Manage integration.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("legalEntityId")]
    public string? LegalEntityId { get; init; }

    /// <summary>
    /// Sets the pricing plan for the merchant account. Required for an Adyen for Platforms Manage integration. Your Adyen contact will provide the values that you can use.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pricingPlan")]
    public string? PricingPlan { get; init; }

    /// <summary>
    /// Your reference for the merchant account. To make this reference the unique identifier of the merchant account, your Adyen contact can set up a template on your company account. The template can have 6 to 255 characters with upper- and lower-case letters, underscores, and numbers. When your company account has a template, then the <c>reference</c> is required and must be unique within the company account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    /// <summary>
    /// List of sales channels that the merchant will process payments with
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("salesChannels")]
    public IReadOnlyList<string>? SalesChannels { get; init; }
}
