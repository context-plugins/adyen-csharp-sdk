using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AccountType3>))]
public sealed record AccountType3 : StringEnum<AccountType3>
{
    private AccountType3(string value) : base(value)
    {
    }

    public static readonly AccountType3 Current = new("CURRENT");

    public static readonly AccountType3 Savings = new("SAVINGS");

    public static readonly AccountType3 Business = new("BUSINESS");

    public static readonly AccountType3 CreditCard = new("CREDIT_CARD");

    public static readonly AccountType3 Loan = new("LOAN");

    public static readonly AccountType3 Unknown = new("UNKNOWN");

    public static AccountType3 FromValue(string value) => FromValueCore(value);
}
