using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The bank account type.
/// <para>
/// Possible values: <b>checking</b> or <b>savings</b>. Defaults to <b>checking</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountType>))]
public sealed record AccountType : StringEnum<AccountType>
{
    private AccountType(string value) : base(value)
    {
    }

    public static readonly AccountType Checking = new("checking");

    public static readonly AccountType Savings = new("savings");

    public static AccountType FromValue(string value) => FromValueCore(value);
}
