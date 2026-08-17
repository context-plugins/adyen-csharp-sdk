using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CreateAccountRequest
{
    /// <summary>
    /// The code of Account Holder under which to create the account.
    /// </summary>
    [JsonPropertyName("accountHolderCode")]
    public required string AccountHolderCode { get; init; }

    /// <summary>
    /// The bankAccountUUID of the bank account held by the account holder to couple the account with. Scheduled payouts in currencies matching the currency of this bank account will be sent to this bank account. Payouts in different currencies will be sent to a matching bank account of the account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankAccountUUID")]
    public string? BankAccountUuid { get; init; }

    /// <summary>
    /// A description of the account, maximum 256 characters. You can use alphanumeric characters (A-Z, a-z, 0-9), white spaces, and underscores <c>_</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// A set of key and value pairs for general use by the merchant.
    /// The keys do not have specific names and may be used for storing miscellaneous data as desired.
    /// &gt; Note that during an update of metadata, the omission of existing key-value pairs will result in the deletion of those key-value pairs.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("metadata")]
    public IReadOnlyDictionary<string, string>? Metadata { get; init; }

    /// <summary>
    /// The payout method code held by the account holder to couple the account with. Scheduled card payouts will be sent using this payout method code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutMethodCode")]
    public string? PayoutMethodCode { get; init; }

    /// <summary>
    /// The payout schedule for the account.
    /// <para>
    /// Possible values: <c>DEFAULT</c>, <c>DAILY</c>, <c>DAILY_US</c>, <c>DAILY_EU</c>, <c>DAILY_AU</c>, <c>DAILY_SG</c>, <c>WEEKLY</c>, <c>WEEKLY_ON_TUE_FRI_MIDNIGHT</c>, <c>BIWEEKLY_ON_1ST_AND_15TH_AT_MIDNIGHT</c>, <c>MONTHLY</c>, <c>HOLD</c>.
    /// &gt; <c>HOLD</c> prevents scheduled payouts, but you can still initiate payouts manually.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutSchedule")]
    public PayoutSchedule? PayoutSchedule { get; init; }

    /// <summary>
    /// The reason for the payout schedule choice.
    /// &gt; This field is required when the <c>payoutSchedule</c> parameter is set to <c>HOLD</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutScheduleReason")]
    public string? PayoutScheduleReason { get; init; }

    /// <summary>
    /// Speed at which payouts for this account are processed.
    /// <para>
    /// Possible values: <c>STANDARD</c> (default), <c>SAME_DAY</c>.
    /// </para>
    /// </summary>
    [JsonPropertyName("payoutSpeed")]
    public PayoutSpeed1? PayoutSpeed { get; init; } = PayoutSpeed1.Standard;
}
