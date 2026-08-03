using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CreateScaInformation
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exemption")]
    public ScaExemption? Exemption { get; init; }

    /// <summary>
    /// Indicates whether to initiate Strong Customer Authentication (SCA) later, during approval, or immediately after you submit this request. Possible values:
    /// * <b>true</b>: you can initiate SCA later, during approval, for all pending transfer limits.
    /// * <b>false</b> (default): you initiate SCA immediately after submitting the transfer limit request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scaOnApproval")]
    public bool? ScaOnApproval { get; init; }
}
