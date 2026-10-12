using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SubmitResponse
{
    /// <summary>
    /// This field contains additional data, which may be returned in a particular response.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalData")]
    public IReadOnlyDictionary<string, string>? AdditionalData { get; init; }

    /// <summary>
    /// A new reference to uniquely identify this request.
    /// </summary>
    [JsonPropertyName("pspReference")]
    public required string PspReference { get; init; }

    /// <summary>
    /// In case of refusal, an informational message for the reason.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("refusalReason")]
    public string? RefusalReason { get; init; }

    /// <summary>
    /// The response:
    /// * In case of success, it is <c>payout-submit-received</c>.
    /// * In case of an error, an informational message is returned.
    /// </summary>
    [JsonPropertyName("resultCode")]
    public required string ResultCode { get; init; }
}
