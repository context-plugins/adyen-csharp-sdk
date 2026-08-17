using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the bank account.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountType1>))]
public sealed record AccountType1 : StringEnum<AccountType1>
{
    private AccountType1(string value) : base(value)
    {
    }

    public static readonly AccountType1 Balance = new("balance");

    public static readonly AccountType1 Checking = new("checking");

    public static readonly AccountType1 Deposit = new("deposit");

    public static readonly AccountType1 General = new("general");

    public static readonly AccountType1 Other = new("other");

    public static readonly AccountType1 Payment = new("payment");

    public static readonly AccountType1 Savings = new("savings");

    public static AccountType1 FromValue(string value) => FromValueCore(value);
}
