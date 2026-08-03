using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record SessionResultResponse
{
    /// <summary>
    /// Contains additional information about the payment. Some fields are included only if you enable them. To enable these fields in your Customer Area, go to <b>Developers</b> &gt; <b>Additional data</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("additionalData")]
    public IReadOnlyDictionary<string, string>? AdditionalData { get; init; }

    /// <summary>
    /// A unique identifier of the session.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// A list of all authorised payments done for this session.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payments")]
    public IReadOnlyList<Payment>? Payments { get; init; }

    /// <summary>
    /// The unique reference that you provided in the original <c>/sessions</c> request. This identifies the payment and is used in all communication with you about the payment status.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    public string? Reference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status52? Status { get; init; }
}
