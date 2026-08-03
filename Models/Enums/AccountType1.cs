using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Indicates the type of account. For example, for a multi-account card product.
/// Allowed values:
/// * notApplicable
/// * credit
/// * debit
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountType1>))]
public sealed record AccountType1 : StringEnum<AccountType1>
{
    private AccountType1(string value) : base(value)
    {
    }

    public static readonly AccountType1 NotApplicable = new("notApplicable");

    public static readonly AccountType1 Credit = new("credit");

    public static readonly AccountType1 Debit = new("debit");

    public static AccountType1 FromValue(string value) => FromValueCore(value);
}
