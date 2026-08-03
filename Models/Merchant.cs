using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record Merchant
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("_links")]
    public CompanyLinks? Links { get; init; }

    /// <summary>
    /// The <see href="https://docs.adyen.com/online-payments/capture#capture-delay">capture delay</see> set for the merchant account.
    /// <para>
    /// Possible values:
    /// * <b>Immediate</b>
    /// * <b>Manual</b>
    /// * Number of days from <b>1</b> to <b>29</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("captureDelay")]
    public string? CaptureDelay { get; init; }

    /// <summary>
    /// The unique identifier of the company account this merchant belongs to
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("companyId")]
    public string? CompanyId { get; init; }

    /// <summary>
    /// List of available data centers.
    /// <para>
    /// Adyen has several data centers around the world.In the URL that you use for making API requests, we recommend you use the live URL prefix from the data center closest to your shoppers.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dataCenters")]
    public IReadOnlyList<DataCenter>? DataCenters { get; init; }

    /// <summary>
    /// The default <see href="https://docs.adyen.com/api-explorer/#/CheckoutService/v68/post/payments__reqParam_shopperInteraction"><c>shopperInteraction</c></see> value used when processing payments through this merchant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("defaultShopperInteraction")]
    public string? DefaultShopperInteraction { get; init; }

    /// <summary>
    /// Your description for the merchant account, maximum 300 characters
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The unique identifier of the merchant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The city where the legal entity of this merchant account is registered.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantCity")]
    public string? MerchantCity { get; init; }

    /// <summary>
    /// The name of the legal entity associated with the merchant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// Only applies to merchant accounts managed by Adyen's partners. The name of the pricing plan assigned to the merchant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pricingPlan")]
    public string? PricingPlan { get; init; }

    /// <summary>
    /// The currency of the country where the legal entity of this merchant account is registered. Format: <see href="https://docs.adyen.com/development-resources/currency-codes">ISO currency code</see>. For example, a legal entity based in the United States has USD as the primary settlement currency.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("primarySettlementCurrency")]
    public string? PrimarySettlementCurrency { get; init; }

    /// <summary>
    /// Reference of the merchant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    /// <summary>
    /// The URL for the ecommerce website used with this merchant account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shopWebAddress")]
    public string? ShopWebAddress { get; init; }

    /// <summary>
    /// The status of the merchant account.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>PreActive</b>: The merchant account has been created. Users cannot access the merchant account in the Customer Area. The account cannot process payments.</description></item>
    ///   <item><description><b>Active</b>: Users can access the merchant account in the Customer Area. If the company account is also <b>Active</b>, then payment processing and payouts are enabled.</description></item>
    ///   <item><description><b>InactiveWithModifications</b>: Users can access the merchant account in the Customer Area. You cannot process new payments but you can still modify payments, for example issue refunds. You can still receive payouts.</description></item>
    ///   <item><description><b>Inactive</b>: Users can access the merchant account in the Customer Area. Payment processing and payouts are disabled.</description></item>
    ///   <item><description><b>Closed</b>: The account is closed and this cannot be reversed. Users cannot log in. Payment processing and payouts are disabled.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public string? Status { get; init; }
}
