using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CardIdentification
{
    /// <summary>
    /// The expiry month of the card.
    /// <para>
    /// Format: two digits. Add a leading zero for single-digit months. For example:
    /// * 03 = March
    /// * 11 = November
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiryMonth")]
    [StringLength(2, MinimumLength = 2)]
    public string? ExpiryMonth { get; init; }

    /// <summary>
    /// The expiry year of the card.
    /// <para>
    /// Format: four digits. For example: 2020
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiryYear")]
    [StringLength(4, MinimumLength = 4)]
    public string? ExpiryYear { get; init; }

    /// <summary>
    /// The issue number of the card. Applies only to some UK debit cards.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("issueNumber")]
    [StringLength(2, MinimumLength = 1)]
    public string? IssueNumber { get; init; }

    /// <summary>
    /// The card number without any separators.
    /// <para>
    /// For security, the response only includes the last four digits of the card number.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("number")]
    [StringLength(19, MinimumLength = 4)]
    public string? Number { get; init; }

    /// <summary>
    /// The month when the card was issued. Applies only to some UK debit cards.
    /// <para>
    /// Format: two digits. Add a leading zero for single-digit months. For example:
    /// * 03 = March
    /// * 11 = November
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startMonth")]
    [StringLength(2, MinimumLength = 2)]
    public string? StartMonth { get; init; }

    /// <summary>
    /// The year when the card was issued. Applies only to some UK debit cards.
    /// <para>
    /// Format: four digits. For example: 2020
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("startYear")]
    [StringLength(4, MinimumLength = 4)]
    public string? StartYear { get; init; }

    /// <summary>
    /// The unique <see href="/payouts/payout-service/pay-out-to-cards/manage-card-information#save-card-details">token</see> created to identify the counterparty.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("storedPaymentMethodId")]
    public string? StoredPaymentMethodId { get; init; }
}
