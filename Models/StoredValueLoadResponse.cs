using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record StoredValueLoadResponse
{
    /// <summary>
    /// Authorisation code:
    /// * When the payment is authorised, this field holds the authorisation code for the payment.
    /// * When the payment is not authorised, this field is empty.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authCode")]
    public string? AuthCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currentBalance")]
    public CurrentBalance? CurrentBalance { get; init; }

    /// <summary>
    /// Adyen's 16-character string reference associated with the transaction/request. This value is globally unique; quote it when communicating with us about this request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pspReference")]
    public string? PspReference { get; init; }

    /// <summary>
    /// If the transaction is refused or an error occurs, this field holds Adyen's mapped reason for the refusal or a description of the error.
    /// <para>
    /// When a transaction fails, the authorisation response includes <c>resultCode</c> and <c>refusalReason</c> values.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refusalReason")]
    public string? RefusalReason { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resultCode")]
    public ResultCode3? ResultCode { get; init; }

    /// <summary>
    /// Raw refusal reason received from the third party, where available
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("thirdPartyRefusalReason")]
    public string? ThirdPartyRefusalReason { get; init; }
}
