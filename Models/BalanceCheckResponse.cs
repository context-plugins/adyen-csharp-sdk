using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record BalanceCheckResponse
{
    /// <summary>
    /// Contains additional information about the payment. Some data fields are included only if you select them first: Go to <b>Customer Area</b> &gt; <b>Developers</b> &gt; <b>Additional data</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalData")]
    public IReadOnlyDictionary<string, string>? AdditionalData { get; init; }

    [JsonPropertyName("balance")]
    public required Balance1 Balance { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fraudResult")]
    public FraudResult? FraudResult { get; init; }

    /// <summary>
    /// Adyen's 16-character reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pspReference")]
    public string? PspReference { get; init; }

    /// <summary>
    /// If the payment's authorisation is refused or an error occurs during authorisation, this field holds Adyen's mapped reason for the refusal or a description of the error. When a transaction fails, the authorisation response includes <c>resultCode</c> and <c>refusalReason</c> values.
    /// <para>
    /// For more information, see <see href="https://docs.adyen.com/development-resources/refusal-reasons">Refusal reasons</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refusalReason")]
    public string? RefusalReason { get; init; }

    [JsonPropertyName("resultCode")]
    public required ResultCode ResultCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionLimit")]
    public TransactionLimit? TransactionLimit { get; init; }
}
