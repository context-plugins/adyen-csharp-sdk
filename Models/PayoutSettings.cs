using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PayoutSettings
{
    /// <summary>
    /// Indicates if payouts to the bank account are allowed. This value is set automatically based on the status of the verification process. The value is:
    /// <list type="bullet">
    ///   <item><description><b>true</b> if <c>verificationStatus</c> is <b>valid</b>.</description></item>
    ///   <item><description><b>false</b> for all other values.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowed")]
    public bool? Allowed { get; init; }

    /// <summary>
    /// Indicates if payouts to this bank account are enabled. Default: <b>true</b>.
    /// <para>
    /// To receive payouts into this bank account, both <c>enabled</c> and <c>allowed</c> must be <b>true</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; init; }

    /// <summary>
    /// The date when Adyen starts paying out to this bank account.
    /// <para>
    /// Format: <see href="https://www.w3.org/TR/NOTE-datetime">ISO 8601</see>, for example, <b>2019-11-23T12:25:28Z</b> or <b>2020-05-27T20:25:28+08:00</b>.
    /// </para>
    /// <para>
    /// If not specified, the <c>enabled</c> field indicates if payouts are enabled for this bank account.
    /// </para>
    /// <para>
    /// If a date is specified and:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>enabled</c>: <b>true</b>, payouts are enabled starting the specified date.</description></item>
    ///   <item><description><c>enabled</c>: <b>false</b>, payouts are disabled until the specified date. On the specified date, <c>enabled</c> changes to <b>true</b> and this field is reset to <b>null</b>.</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enabledFromDate")]
    public string? EnabledFromDate { get; init; }

    /// <summary>
    /// The unique identifier of the payout setting.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Determines how long it takes for the funds to reach the bank account. Adyen pays out based on the <see href="https://docs.adyen.com/account/getting-paid#payout-frequency">payout frequency</see>. Depending on the currencies and banks involved in transferring the money, it may take up to three days for the payout funds to arrive in the bank account.
    /// <para>
    ///  Possible values:
    /// * <b>first</b>: same day.
    /// * <b>urgent</b>: the next day.
    /// * <b>normal</b>: between 1 and 3 days.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("priority")]
    public Priority? Priority { get; init; }

    /// <summary>
    /// The unique identifier of the <see href="https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments">transfer instrument</see> that contains the details of the bank account.
    /// </summary>
    [JsonPropertyName("transferInstrumentId")]
    public required string TransferInstrumentId { get; init; }

    /// <summary>
    /// The status of the verification process for the bank account.
    /// <para>
    /// Possible values:
    /// * <b>valid</b>: the verification was successful.
    /// * <b>pending</b>: the verification is in progress.
    /// * <b>invalid</b>: the information provided is not complete.
    /// * <b>rejected</b>:  there are reasons to refuse working with this entity.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("verificationStatus")]
    public VerificationStatus1? VerificationStatus { get; init; }
}
