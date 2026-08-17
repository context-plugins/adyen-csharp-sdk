using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record ConfirmationTrackingData
{
    /// <summary>
    /// The status of the transfer.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>credited</b>: the funds are credited to your user's transfer instrument or bank account.- <b>accepted</b>: the request is accepted by the integration.</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("status")]
    public required Status15 Status { get; init; }

    /// <summary>
    /// The type of the tracking event.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>confirmation</b>: the transfer passed Adyen's internal review.</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "confirmation";
}
