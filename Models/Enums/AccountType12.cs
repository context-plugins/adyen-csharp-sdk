using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the bank account. Possible values are <b>CURRENT</b>, <b>SAVINGS</b>, <b>BUSINESS</b>, <b>CREDIT_CARD</b>, <b>LOAN</b>, <b>UNKNOWN</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountType12>))]
public sealed record AccountType12 : StringEnum<AccountType12>
{
    private AccountType12(string value) : base(value)
    {
    }

    public static readonly AccountType12 Current = new("CURRENT");

    public static readonly AccountType12 Savings = new("SAVINGS");

    public static readonly AccountType12 Business = new("BUSINESS");

    public static readonly AccountType12 CreditCard = new("CREDIT_CARD");

    public static readonly AccountType12 Loan = new("LOAN");

    public static readonly AccountType12 Unknown = new("UNKNOWN");

    public static AccountType12 FromValue(string value) => FromValueCore(value);
}
