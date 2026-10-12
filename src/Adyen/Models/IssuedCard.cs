using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record IssuedCard
{
    /// <summary>
    /// The authorisation type. For example, <b>defaultAuthorisation</b>, <b>preAuthorisation</b>, <b>finalAuthorisation</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("authorisationType")]
    public string? AuthorisationType { get; init; }

    /// <summary>
    /// Indicates the method used for entering the PAN to initiate a transaction.
    /// <para>
    /// Possible values: <b>manual</b>, <b>chip</b>, <b>magstripe</b>, <b>contactless</b>, <b>cof</b>, <b>ecommerce</b>, <b>token</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("panEntryMode")]
    public PanEntryMode? PanEntryMode { get; init; }

    /// <summary>
    /// Contains information about how the payment was processed.
    /// <para>
    /// Possible values: <b>atmWithdraw</b>, <b>balanceInquiry</b>, <b>ecommerce</b>, <b>moto</b>, <b>pos</b>, <b>purchaseWithCashback</b>, <b>recurring</b>, <b>token</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processingType")]
    public ProcessingType1? ProcessingType { get; init; }

    /// <summary>
    /// If you are using relayed authorisation, this object contains information from the relayed authorisation response from your server.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("relayedAuthorisationData")]
    public RelayedAuthorisationData2? RelayedAuthorisationData { get; init; }

    /// <summary>
    /// The identifier of the original payment. This ID is provided by the scheme and can be alphanumeric or numeric, depending on the scheme. The <c>schemeTraceID</c> should refer to an original <c>schemeUniqueTransactionID</c> provided in an earlier payment (not necessarily processed by Adyen). A <c>schemeTraceId</c> is typically available for authorization adjustments or recurring payments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("schemeTraceId")]
    public string? SchemeTraceId { get; init; }

    /// <summary>
    /// The unique identifier created by the scheme. This ID can be alphanumeric or numeric depending on the scheme.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("schemeUniqueTransactionId")]
    public string? SchemeUniqueTransactionId { get; init; }

    /// <summary>
    /// The data of the result from the 3DS authentication.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSecure")]
    public ThreeDSecure2? ThreeDSecure { get; init; }

    /// <summary>
    /// <b>issuedCard</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type511? Type { get; init; } = Type511.IssuedCard;

    /// <summary>
    /// The evaluation of the validation facts. See <see href="https://docs.adyen.com/issuing/validation-checks">validation checks</see> for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("validationFacts")]
    public IReadOnlyList<TransferNotificationValidationFact>? ValidationFacts { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
