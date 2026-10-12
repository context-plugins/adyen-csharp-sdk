using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record JcbInfo
{
    /// <summary>
    /// MID (Merchant ID) number. Required for merchants operating in Japan or merchants operating in Canada, Australia and New Zealand when requesting <c>gatewayContract</c> or <c>paymentDesignatorContract</c> service levels.Format: 14 numeric characters for Japan, 10 numeric characters for Canada, Australia and New Zealand.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("midNumber")]
    [MaxLength(14)]
    public string? MidNumber { get; init; }

    /// <summary>
    /// Indicates whether the JCB Merchant ID is reused from a previously setup JCB payment method.
    /// The default value is <b>false</b>.For merchants operating in Japan, this field is required and must be set to <b>true</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reuseMidNumber")]
    public bool? ReuseMidNumber { get; init; } = false;

    /// <summary>
    /// Specifies the service level (settlement type) of this payment method. Required for merchants operating in Japan.
    /// Possible values:
    /// * <b>noContract</b>: Adyen holds the contract with JCB for merchants operating in Japan or American Express for merchants operating in Canada, Australia and New Zealand.
    /// * <b>gatewayContract</b>: JCB or American Express receives the settlement and handles disputes, then pays out to you or your sub-merchant directly.
    /// * <b>paymentDesignatorContract</b>: Available only for merchants operating in Canada, Australia and New Zealand. Adyen receives the settlement, and handles disputes and payouts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceLevel")]
    public ServiceLevel2? ServiceLevel { get; init; }

    /// <summary>
    /// Information regarding the transaction description.
    /// &gt; You cannot configure the transaction description in the test environment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo1? TransactionDescription { get; init; }
}
