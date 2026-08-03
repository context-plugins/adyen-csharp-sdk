using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the bank account.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountType11>))]
public sealed record AccountType11 : StringEnum<AccountType11>
{
    private AccountType11(string value) : base(value)
    {
    }

    public static readonly AccountType11 Balance = new("balance");

    public static readonly AccountType11 Checking = new("checking");

    public static readonly AccountType11 Deposit = new("deposit");

    public static readonly AccountType11 General = new("general");

    public static readonly AccountType11 Other = new("other");

    public static readonly AccountType11 Payment = new("payment");

    public static readonly AccountType11 Savings = new("savings");

    public static AccountType11 FromValue(string value) => FromValueCore(value);
}
