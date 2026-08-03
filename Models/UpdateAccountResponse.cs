using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record UpdateAccountResponse
{
    /// <summary>
    /// The code of the account.
    /// </summary>
    [JsonPropertyName("accountCode")]
    public required string AccountCode { get; init; }

    /// <summary>
    /// The bankAccountUUID of the bank account held by the account holder to couple the account with. Scheduled payouts in currencies matching the currency of this bank account will be sent to this bank account. Payouts in different currencies will be sent to a matching bank account of the account holder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankAccountUUID")]
    public string? BankAccountUuid { get; init; }

    /// <summary>
    /// The description of the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// A list of fields that caused the <c>/updateAccount</c> request to fail.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invalidFields")]
    public IReadOnlyList<ErrorFieldType>? InvalidFields { get; init; }

    /// <summary>
    /// A set of key and value pairs containing metadata.
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

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutSchedule")]
    public PayoutScheduleResponse? PayoutSchedule { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutSpeed")]
    public PayoutSpeed4? PayoutSpeed { get; init; }

    /// <summary>
    /// The reference of a request. Can be used to uniquely identify the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pspReference")]
    public string? PspReference { get; init; }

    /// <summary>
    /// The result code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resultCode")]
    public string? ResultCode { get; init; }
}
