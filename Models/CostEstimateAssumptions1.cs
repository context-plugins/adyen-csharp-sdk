using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Assumptions made for the expected characteristics of the transaction, for which the charges are being estimated.
/// </summary>
public record CostEstimateAssumptions1
{
    /// <summary>
    /// If true, the cardholder is expected to successfully authorise via 3D Secure.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("assume3DSecureAuthenticated")]
    public bool? Assume3DSecureAuthenticated { get; init; }

    /// <summary>
    /// If true, the transaction is expected to have valid Level 3 data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("assumeLevel3Data")]
    public bool? AssumeLevel3Data { get; init; }

    /// <summary>
    /// If not zero, the number of installments.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("installments")]
    public int? Installments { get; init; }
}
