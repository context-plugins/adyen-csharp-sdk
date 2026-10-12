using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record DeleteBankAccountRequest
{
    /// <summary>
    /// The code of the Account Holder from which to delete the Bank Account(s).
    /// </summary>
    [JsonPropertyName("accountHolderCode")]
    public required string AccountHolderCode { get; init; }

    /// <summary>
    /// The code(s) of the Bank Accounts to be deleted.
    /// </summary>
    [JsonPropertyName("bankAccountUUIDs")]
    public required IReadOnlyList<string> BankAccountUuiDs { get; init; }
}
