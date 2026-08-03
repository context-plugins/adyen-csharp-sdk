using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CreateOrderResponse
{
    /// <summary>
    /// Contains additional information about the payment. Some data fields are included only if you select them first: Go to <b>Customer Area</b> &gt; <b>Developers</b> &gt; <b>Additional data</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalData")]
    public IReadOnlyDictionary<string, string>? AdditionalData { get; init; }

    [JsonPropertyName("amount")]
    public required Amount16 Amount { get; init; }

    /// <summary>
    /// The date that the order will expire.
    /// </summary>
    [JsonPropertyName("expiresAt")]
    public required string ExpiresAt { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fraudResult")]
    public FraudResult? FraudResult { get; init; }

    /// <summary>
    /// The encrypted data that will be used by merchant for adding payments to the order.
    /// </summary>
    [JsonPropertyName("orderData")]
    public required string OrderData { get; init; }

    /// <summary>
    /// Adyen's 16-character reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pspReference")]
    public string? PspReference { get; init; }

    /// <summary>
    /// The reference provided by merchant for creating the order.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    /// <summary>
    /// If the payment's authorisation is refused or an error occurs during authorisation, this field holds Adyen's mapped reason for the refusal or a description of the error. When a transaction fails, the authorisation response includes <c>resultCode</c> and <c>refusalReason</c> values.
    /// <para>
    /// For more information, see <see href="https://docs.adyen.com/development-resources/refusal-reasons">Refusal reasons</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refusalReason")]
    public string? RefusalReason { get; init; }

    [JsonPropertyName("remainingAmount")]
    public required RemainingAmount RemainingAmount { get; init; }

    /// <summary>
    /// The result of the order creation request.
    ///  The value is always <b>Success</b>.
    /// </summary>
    [JsonPropertyName("resultCode")]
    public required ResultCode23 ResultCode { get; init; }
}
