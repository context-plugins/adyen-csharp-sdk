using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record TransferReview
{
    /// <summary>
    /// Shows the number of <see href="https://docs.adyen.com/api-explorer/transfers/latest/post/transfers/approve">approvals</see> required to process the transfer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numberOfApprovalsRequired")]
    public int? NumberOfApprovalsRequired { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scaOnApproval")]
    public ScaOnApproval? ScaOnApproval { get; init; }
}
