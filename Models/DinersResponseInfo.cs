using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DinersResponseInfo
{
    /// <summary>
    /// MID (Merchant ID) number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("midNumber")]
    public string? MidNumber { get; init; }

    /// <summary>
    /// Indicates whether the JCB Merchant ID is reused from a previously configured JCB payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reuseMidNumber")]
    public bool? ReuseMidNumber { get; init; }

    /// <summary>
    /// The service level (settlement type) of this payment method. Possible values:
    ///  * <b>noContract</b>: Adyen holds the contract with JCB.
    ///  * <b>gatewayContract</b>: JCB receives the settlement and handles disputes, then pays out to you or your sub-merchant directly.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceLevel")]
    public string? ServiceLevel { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
