using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// <b>jcb</b> details
/// </summary>
public record JcbresponseInfo1
{
    /// <summary>
    /// MID (Merchant ID) number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("midNumber")]
    public string? MidNumber { get; init; }

    /// <summary>
    /// Indicates whether the JCB Merchant ID is reused from a previously setup JCB payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reuseMidNumber")]
    public bool? ReuseMidNumber { get; init; }

    /// <summary>
    /// Specifies the service level (settlement type) of this payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("serviceLevel")]
    public string? ServiceLevel { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
