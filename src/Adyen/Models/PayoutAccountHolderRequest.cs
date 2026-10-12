using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record PayoutAccountHolderRequest
{
    /// <summary>
    /// The code of the account from which the payout is to be made.
    /// </summary>
    [JsonPropertyName("accountCode")]
    public required string AccountCode { get; init; }

    /// <summary>
    /// The code of the Account Holder who owns the account from which the payout is to be made.
    /// The Account Holder is the party to which the payout will be made.
    /// </summary>
    [JsonPropertyName("accountHolderCode")]
    public required string AccountHolderCode { get; init; }

    /// <summary>
    /// An object containing the currency and value of the payout.
    /// If the account has multiple currencies, specify the currency to be used.
    /// If the <c>bankAccountUUID</c> is provided in the request, the currency supported by the bank is used.
    /// If the <c>payoutMethodCode</c> is provided in the request, the specified payout method is selected.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("amount")]
    public Amount? Amount { get; init; }

    /// <summary>
    /// The unique ID of the Bank Account held by the Account Holder to which the payout is to be made.
    /// If left blank, a bank account is automatically selected.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankAccountUUID")]
    public string? BankAccountUuid { get; init; }

    /// <summary>
    /// A description of the payout. Maximum 200 characters.
    /// Allowed: <b>abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789/?:().,'+ ";</b>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(200)]
    public string? Description { get; init; }

    /// <summary>
    /// A value that can be supplied at the discretion of the executing user in order to link multiple transactions to one another.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantReference")]
    public string? MerchantReference { get; init; }

    /// <summary>
    /// The unique ID of the payout method held by the Account Holder to which the payout is to be made.
    /// If left blank, a payout instrument is automatically selected.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutMethodCode")]
    public string? PayoutMethodCode { get; init; }

    /// <summary>
    /// Speed with which payouts for this account are processed. Permitted values: <c>STANDARD</c>, <c>SAME_DAY</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payoutSpeed")]
    public PayoutSpeed? PayoutSpeed { get; init; } = PayoutSpeed.Standard;
}
