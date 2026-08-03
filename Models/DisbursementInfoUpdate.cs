using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DisbursementInfoUpdate
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("repayment")]
    public DisbursementRepaymentInfoUpdate? Repayment { get; init; }
}
