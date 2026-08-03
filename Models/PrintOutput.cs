using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PrintOutput
{
    [JsonPropertyName("DocumentQualifier")]
    public required DocumentQualifier2 DocumentQualifier { get; init; }

    [JsonPropertyName("ResponseMode")]
    public required ResponseMode1 ResponseMode { get; init; }

    /// <summary>
    /// Type of the print integrated in other prints. Allows a separated printing (paper cut if available), or integration with the sale receipt or other print. If the printing is integrated, the response is always immediate, even if the <c>ResponseMode</c> is set to <c>PrintEnd</c>.
    /// </summary>
    [JsonPropertyName("IntegratedPrintFlag")]
    public bool? IntegratedPrintFlag { get; init; } = false;

    /// <summary>
    /// Indicates that the cardholder payment receipt requires a physical signature by the Customer.
    /// </summary>
    [JsonPropertyName("RequiredSignatureFlag")]
    public bool? RequiredSignatureFlag { get; init; } = false;

    [JsonPropertyName("OutputContent")]
    public required OutputContent2 OutputContent { get; init; }
}
