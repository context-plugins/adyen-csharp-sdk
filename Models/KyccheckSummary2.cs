using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// A summary of the execution of the check.
/// </summary>
public record KyccheckSummary2
{
    /// <summary>
    /// The code of the check. For possible values, refer to <see href="https://docs.adyen.com/classic-platforms/verification-process/verification-codes">Verification codes</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("kycCheckCode")]
    public int? KycCheckCode { get; init; }

    /// <summary>
    /// A description of the check.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("kycCheckDescription")]
    public string? KycCheckDescription { get; init; }
}
