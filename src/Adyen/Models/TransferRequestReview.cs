using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TransferRequestReview
{
    /// <summary>
    /// Specifies the number of <see href="https://docs.adyen.com/api-explorer/transfers/latest/post/transfers/approve">approvals</see> required to process the transfer.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("numberOfApprovalsRequired")]
    public int? NumberOfApprovalsRequired { get; init; }

    /// <summary>
    /// Specifies whether you will initiate Strong Customer Authentication (SCA) in thePOST <see href="https://docs.adyen.com/api-explorer/transfers/latest/post/transfers/approve">/transfers/approve</see> request.
    /// <para>
    /// Only applies to transfers made with an Adyen <see href="https://docs.adyen.com/platforms/business-accounts">business account</see>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scaOnApproval")]
    public bool? ScaOnApproval { get; init; }
}
