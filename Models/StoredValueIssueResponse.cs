using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record StoredValueIssueResponse
{
    /// <summary>
    /// Authorisation code:
    /// * When the payment is authorised, this field holds the authorisation code for the payment.
    /// * When the payment is not authorised, this field is empty.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authCode")]
    public string? AuthCode { get; init; }

    /// <summary>
    /// The balance currently on the payment method.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currentBalance")]
    public Amount? CurrentBalance { get; init; }

    /// <summary>
    /// The collection that contains the type of the payment method and its specific information if available
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("paymentMethod")]
    public IReadOnlyDictionary<string, string>? PaymentMethod { get; init; }

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

    /// <summary>
    /// The result of the payment. Possible values:
    /// <list type="bullet">
    ///   <item><description><b>Success</b> – The operation has been completed successfully.</description></item>
    ///   <item><description><b>Refused</b> – The operation was refused. The reason is given in the <c>refusalReason</c> field.</description></item>
    ///   <item><description><b>Error</b> – There was an error when the operation was processed. The reason is given in the <c>refusalReason</c> field.</description></item>
    ///   <item><description><b>NotEnoughBalance</b> – The amount on the payment method is lower than the amount given in the request. Only applicable to balance checks.</description></item>
    /// </list>
    /// </summary>
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
