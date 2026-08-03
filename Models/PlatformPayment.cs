using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PlatformPayment
{
    /// <summary>
    /// The capture's merchant reference included in the transfer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modificationMerchantReference")]
    public string? ModificationMerchantReference { get; init; }

    /// <summary>
    /// The capture reference included in the transfer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("modificationPspReference")]
    public string? ModificationPspReference { get; init; }

    /// <summary>
    /// The payment's merchant reference included in the transfer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentMerchantReference")]
    public string? PaymentMerchantReference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("platformPaymentType")]
    public PlatformPaymentType? PlatformPaymentType { get; init; }

    /// <summary>
    /// The payment reference included in the transfer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pspPaymentReference")]
    public string? PspPaymentReference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type63? Type { get; init; }
}
