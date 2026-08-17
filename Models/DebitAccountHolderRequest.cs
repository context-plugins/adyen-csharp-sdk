using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DebitAccountHolderRequest
{
    /// <summary>
    /// The code of the account holder.
    /// </summary>
    [JsonPropertyName("accountHolderCode")]
    public required string AccountHolderCode { get; init; }

    /// <summary>
    /// The amount to be debited from the account holder's bank account.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount Amount { get; init; }

    /// <summary>
    /// The Adyen-generated unique alphanumeric identifier (UUID) of the account holder's bank account.
    /// </summary>
    [JsonPropertyName("bankAccountUUID")]
    public required string BankAccountUuid { get; init; }

    /// <summary>
    /// A description of the direct debit. Maximum length: 35 characters.
    /// <para>
    /// Allowed characters: <b>a-z</b>, <b>A-Z</b>, <b>0-9</b>, and special characters <b>/?:().,'+ ";</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    [MaxLength(35)]
    public string? Description { get; init; }

    /// <summary>
    /// Your merchant account.
    /// </summary>
    [JsonPropertyName("merchantAccount")]
    public required string MerchantAccount { get; init; }

    /// <summary>
    /// Contains instructions on how to split the funds between the accounts in your platform. The request must have at least one split item.
    /// </summary>
    [JsonPropertyName("splits")]
    public required IReadOnlyList<Split1> Splits { get; init; }
}
