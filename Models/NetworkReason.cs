using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record NetworkReason
{
    /// <summary>
    /// The reason code provided by the network.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    public string? Code { get; init; }

    /// <summary>
    /// The description of the reason code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The namespace that corresponds to the reason code.
    /// <para>
    /// Possible values:
    /// *  <b>ukFpsRejectionCode</b>
    /// *  <b>ukFpsReturnReasonCode</b>
    /// *  <b>usAchReturnReasonCode</b>
    /// *  <b>iso8583ResponseCode</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("namespace")]
    public Namespace? Namespace { get; init; }
}
