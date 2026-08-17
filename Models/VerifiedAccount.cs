using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record VerifiedAccount
{
    /// <summary>
    /// The unique identifier for the bank account.
    /// </summary>
    [JsonPropertyName("accountId")]
    public required string AccountId { get; init; }

    /// <summary>
    /// The name of the bank account. This name is assigned by the banking institution, and it describes the type of bank account.
    /// </summary>
    [JsonPropertyName("accountName")]
    public required string AccountName { get; init; }

    /// <summary>
    /// The account number of the bank account.
    /// </summary>
    [JsonPropertyName("accountNumber")]
    public required string AccountNumber { get; init; }

    /// <summary>
    /// The type of the bank account. Possible values are <b>CURRENT</b>, <b>SAVINGS</b>, <b>BUSINESS</b>, <b>CREDIT_CARD</b>, <b>LOAN</b>, <b>UNKNOWN</b>.
    /// </summary>
    [JsonPropertyName("accountType")]
    public required AccountType11 AccountType { get; init; }

    /// <summary>
    /// The name of the banking institution where the bank account is held.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankName")]
    public string? BankName { get; init; }

    /// <summary>
    /// The currency of the funds in the bank account.
    /// </summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>
    /// Contains various codes and details used to uniquely identify the bank account across different regions.
    /// </summary>
    [JsonPropertyName("identifiers")]
    public required AccountIdentifiers1 Identifiers { get; init; }

    /// <summary>
    /// Contains details of all parties associated with the report.
    /// </summary>
    [JsonPropertyName("parties")]
    public required IReadOnlyList<AccountParty> Parties { get; init; }
}
