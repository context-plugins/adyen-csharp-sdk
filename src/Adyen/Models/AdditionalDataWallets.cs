using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AdditionalDataWallets
{
    /// <summary>
    /// The Android Pay token retrieved from the SDK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("androidpay.token")]
    public string? AndroidpayToken { get; init; }

    /// <summary>
    /// The Mastercard Masterpass Transaction ID retrieved from the SDK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("masterpass.transactionId")]
    public string? MasterpassTransactionId { get; init; }

    /// <summary>
    /// The Apple Pay token retrieved from the SDK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment.token")]
    public string? PaymentToken { get; init; }

    /// <summary>
    /// The Google Pay token retrieved from the SDK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paywithgoogle.token")]
    public string? PaywithgoogleToken { get; init; }

    /// <summary>
    /// The Samsung Pay token retrieved from the SDK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("samsungpay.token")]
    public string? SamsungpayToken { get; init; }

    /// <summary>
    /// The Visa Checkout Call ID retrieved from the SDK.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visacheckout.callId")]
    public string? VisacheckoutCallId { get; init; }
}
