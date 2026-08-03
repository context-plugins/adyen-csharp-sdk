using System.Collections.Generic;
using System.Text.Json.Serialization;
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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("panEntryMode")]
    public PanEntryMode? PanEntryMode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("processingType")]
    public ProcessingType1? ProcessingType { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("relayedAuthorisationData")]
    public RelayedAuthorisationData? RelayedAuthorisationData { get; init; }

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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSecure")]
    public ThreeDsecure? ThreeDsecure { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type512? Type { get; init; }

    /// <summary>
    /// The evaluation of the validation facts. See <see href="https://docs.adyen.com/issuing/validation-checks">validation checks</see> for more information.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("validationFacts")]
    public IReadOnlyList<TransferNotificationValidationFact>? ValidationFacts { get; init; }
}
