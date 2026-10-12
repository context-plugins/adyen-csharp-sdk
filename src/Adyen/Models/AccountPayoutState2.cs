using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The payout state of the account holder.
/// </summary>
public record AccountPayoutState2
{
    /// <summary>
    /// Indicates whether payouts are allowed. This field is the overarching payout status, and is the aggregate of multiple conditions (e.g., KYC status, disabled flag, etc). If this field is false, no payouts will be permitted for any of the account holder's accounts. If this field is true, payouts will be permitted for any of the account holder's accounts.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowPayout")]
    public bool? AllowPayout { get; init; }

    /// <summary>
    /// The reason why payouts (to all of the account holder's accounts) have been disabled (by the platform). If the <c>disabled</c> field is true, this field can be used to explain why.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disableReason")]
    public string? DisableReason { get; init; }

    /// <summary>
    /// Indicates whether payouts have been disabled (by the platform) for all of the account holder's accounts. A platform may enable and disable this field at their discretion. If this field is true, <c>allowPayout</c> will be false and no payouts will be permitted for any of the account holder's accounts. If this field is false, <c>allowPayout</c> may or may not be enabled, depending on other factors.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; init; }

    /// <summary>
    /// The reason why payouts (to all of the account holder's accounts) have been disabled (by Adyen). If payouts have been disabled by Adyen, this field will explain why. If this field is blank, payouts have not been disabled by Adyen.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notAllowedReason")]
    public string? NotAllowedReason { get; init; }

    /// <summary>
    /// The maximum amount that payouts are limited to. Only applies if payouts are allowed but limited.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutLimit")]
    public Amount? PayoutLimit { get; init; }

    /// <summary>
    /// The payout tier that the account holder occupies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tierNumber")]
    public int? TierNumber { get; init; }
}
