using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The bank account type (checking, savings...).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<BankAccountType>))]
public sealed record BankAccountType : StringEnum<BankAccountType>
{
    private BankAccountType(string value) : base(value)
    {
    }

    public static readonly BankAccountType Balance = new("balance");

    public static readonly BankAccountType Checking = new("checking");

    public static readonly BankAccountType Deposit = new("deposit");

    public static readonly BankAccountType General = new("general");

    public static readonly BankAccountType Other = new("other");

    public static readonly BankAccountType Payment = new("payment");

    public static readonly BankAccountType Savings = new("savings");

    public static BankAccountType FromValue(string value) => FromValueCore(value);
}
