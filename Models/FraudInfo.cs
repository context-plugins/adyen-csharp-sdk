using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record FraudInfo
{
    /// <summary>
    /// The card is no longer in the cardholder's possession. Set to <b>true</b> if the card is lost or stolen.
    /// </summary>
    [JsonPropertyName("cardDoesNotBelongToCardholder")]
    public required bool CardDoesNotBelongToCardholder { get; init; }

    /// <summary>
    /// The card was counterfeited.
    /// </summary>
    [JsonPropertyName("cardWasCounterfeited")]
    public required bool CardWasCounterfeited { get; init; }

    /// <summary>
    /// Your description of the issue for raising a dispute of <c>type</c> <b>fraud</b>.
    /// </summary>
    [JsonPropertyName("descriptionOfIssue")]
    [StringLength(2500, MinimumLength = 0)]
    public required string DescriptionOfIssue { get; init; }

    /// <summary>
    /// Set to <b>true</b> to report fraud to Adyen with no further action, such as a request for a chargeback or fee reversal. The default value is <b>false</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reportOnly")]
    public bool? ReportOnly { get; init; }
}
