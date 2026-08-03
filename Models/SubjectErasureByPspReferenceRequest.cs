using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SubjectErasureByPspReferenceRequest
{
    /// <summary>
    /// Set this to <b>true</b> if you want to delete shopper-related data, even if the shopper has an existing recurring transaction. This only deletes the shopper-related data for the specific payment, but does not cancel the existing recurring transaction.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("forceErasure")]
    public bool? ForceErasure { get; init; }

    /// <summary>
    /// Your merchant account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantAccount")]
    public string? MerchantAccount { get; init; }

    /// <summary>
    /// The PSP reference of the payment. We will delete all shopper-related data for this payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pspReference")]
    public string? PspReference { get; init; }
}
