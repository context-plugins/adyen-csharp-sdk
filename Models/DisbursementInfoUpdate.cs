using System.Text.Json.Serialization;
using Adyen.Core.Models;

namespace Adyen.Models;

public record DisbursementInfoUpdate
{
    /// <summary>
    /// Contains information about the basis points configured for repaying the disbursement.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("repayment")]
    public DisbursementRepaymentInfoUpdate2? Repayment { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
