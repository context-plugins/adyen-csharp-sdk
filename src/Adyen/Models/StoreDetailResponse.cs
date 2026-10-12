using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record StoreDetailResponse
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
    /// The token which you can use later on for submitting the payout.
    /// </summary>
    [JsonPropertyName("recurringDetailReference")]
    public required string RecurringDetailReference { get; init; }

    /// <summary>
    /// The result code of the transaction. <c>Success</c> indicates that the details were stored successfully.
    /// </summary>
    [JsonPropertyName("resultCode")]
    public required string ResultCode { get; init; }
}
