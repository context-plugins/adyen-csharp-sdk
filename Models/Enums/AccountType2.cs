using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AccountType2>))]
public sealed record AccountType2 : StringEnum<AccountType2>
{
    private AccountType2(string value) : base(value)
    {
    }

    public static readonly AccountType2 Current = new("CURRENT");

    public static readonly AccountType2 Savings = new("SAVINGS");

    public static readonly AccountType2 Business = new("BUSINESS");

    public static readonly AccountType2 CreditCard = new("CREDIT_CARD");

    public static readonly AccountType2 Loan = new("LOAN");

    public static readonly AccountType2 Unknown = new("UNKNOWN");

    public static AccountType2 FromValue(string value) => FromValueCore(value);
}
