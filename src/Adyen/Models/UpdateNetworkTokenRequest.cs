using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record UpdateNetworkTokenRequest
{
    /// <summary>
    /// The new status of the network token. Possible values: <b>active</b>, <b>suspended</b>, <b>closed</b>. The <b>closed</b> status is final and cannot be changed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status16? Status { get; init; }
}
