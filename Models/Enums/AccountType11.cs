using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the bank account. Possible values are <b>CURRENT</b>, <b>SAVINGS</b>, <b>BUSINESS</b>, <b>CREDIT_CARD</b>, <b>LOAN</b>, <b>UNKNOWN</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountType11>))]
public sealed record AccountType11 : StringEnum<AccountType11>
{
    private AccountType11(string value) : base(value)
    {
    }

    public static readonly AccountType11 Current = new("CURRENT");

    public static readonly AccountType11 Savings = new("SAVINGS");

    public static readonly AccountType11 Business = new("BUSINESS");

    public static readonly AccountType11 CreditCard = new("CREDIT_CARD");

    public static readonly AccountType11 Loan = new("LOAN");

    public static readonly AccountType11 Unknown = new("UNKNOWN");

    public static AccountType11 FromValue(string value) => FromValueCore(value);
}
