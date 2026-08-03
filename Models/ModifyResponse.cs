using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ModifyResponse
{
    /// <summary>
    /// This field contains additional data, which may be returned in a particular response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalData")]
    public IReadOnlyDictionary<string, string>? AdditionalData { get; init; }

    /// <summary>
    /// Adyen's 16-character string reference associated with the transaction. This value is globally unique; quote it when communicating with us about this response.
    /// </summary>
    [JsonPropertyName("pspReference")]
    public required string PspReference { get; init; }

    /// <summary>
    /// The response:
    /// * In case of success, it is either <c>payout-confirm-received</c> or <c>payout-decline-received</c>.
    /// * In case of an error, an informational message is returned.
    /// </summary>
    [JsonPropertyName("response")]
    public required string Response { get; init; }
}
