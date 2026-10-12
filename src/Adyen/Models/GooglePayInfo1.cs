using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>googlepay</b>.
/// </summary>
public record GooglePayInfo1
{
    /// <summary>
    /// Google Pay <see href="https://support.google.com/paymentscenter/answer/7163092?hl=en">Merchant ID</see>. Character length and limitations: 16 alphanumeric characters or 20 numeric characters.
    /// </summary>
    [JsonPropertyName("merchantId")]
    [StringLength(20, MinimumLength = 16)]
    public required string MerchantId { get; init; }

    /// <summary>
    /// Indicates whether the Google Pay Merchant ID is used for several merchant accounts. Default value: <b>false</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reuseMerchantId")]
    public bool? ReuseMerchantId { get; init; }
}
