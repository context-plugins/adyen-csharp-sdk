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
[JsonConverter(typeof(StringEnumConverter<AccountType>))]
public sealed record AccountType : StringEnum<AccountType>
{
    private AccountType(string value) : base(value)
    {
    }

    public static readonly AccountType NotApplicable = new("notApplicable");

    public static readonly AccountType Credit = new("credit");

    public static readonly AccountType Debit = new("debit");

    public static AccountType FromValue(string value) => FromValueCore(value);
}
