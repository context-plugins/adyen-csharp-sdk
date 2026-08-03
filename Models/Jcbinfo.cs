using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record Jcbinfo
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
    [JsonPropertyName("reuseMidNumber")]
    public bool? ReuseMidNumber { get; init; } = false;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceLevel")]
    public ServiceLevel2? ServiceLevel { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
