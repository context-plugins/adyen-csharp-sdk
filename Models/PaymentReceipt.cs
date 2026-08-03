using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Customer or Merchant payment receipt.
/// If the payment receipts are printed by the Sale system and the POI or the Sale does not implement the Print exchange (Basic profile).
/// </summary>
public record PaymentReceipt
{
    [JsonPropertyName("DocumentQualifier")]
    public required DocumentQualifier1 DocumentQualifier { get; init; }

    /// <summary>
    /// Type of the print integrated to other prints.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("IntegratedPrintFlag")]
    public bool? IntegratedPrintFlag { get; init; }

    /// <summary>
    /// Indicate that the cardholder payment receipt requires a physical signature by the Customer.
    /// </summary>
    [JsonPropertyName("RequiredSignatureFlag")]
    public bool? RequiredSignatureFlag { get; init; } = false;

    [JsonPropertyName("OutputContent")]
    public required OutputContent2 OutputContent { get; init; }
}
