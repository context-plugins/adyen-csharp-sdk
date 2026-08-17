using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The bank account type.
/// <para>
/// Possible values: <b>checking</b> or <b>savings</b>. Defaults to <b>checking</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountType2>))]
public sealed record AccountType2 : StringEnum<AccountType2>
{
    private AccountType2(string value) : base(value)
    {
    }

    public static readonly AccountType2 Checking = new("checking");

    public static readonly AccountType2 Savings = new("savings");

    public static AccountType2 FromValue(string value) => FromValueCore(value);
}
