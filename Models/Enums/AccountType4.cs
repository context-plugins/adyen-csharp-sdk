using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of cardholder account used for the transaction. Allows a cardholder to select the type of account used for the transaction.
/// Possible values:
/// * <b>Default</b>
/// * <b>Savings</b>
/// * <b>Checking</b>
/// * <b>CreditCard</b>
/// * <b>Universal</b>
/// * <b>Investment</b>
/// * <b>CardTotals</b>
/// * <b>EpurseCard</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountType4>))]
public sealed record AccountType4 : StringEnum<AccountType4>
{
    private AccountType4(string value) : base(value)
    {
    }

    public static readonly AccountType4 Default = new("Default");

    public static readonly AccountType4 Savings = new("Savings");

    public static readonly AccountType4 Checking = new("Checking");

    public static readonly AccountType4 CreditCard = new("CreditCard");

    public static readonly AccountType4 Universal = new("Universal");

    public static readonly AccountType4 Investment = new("Investment");

    public static readonly AccountType4 CardTotals = new("CardTotals");

    public static readonly AccountType4 EpurseCard = new("EpurseCard");

    public static AccountType4 FromValue(string value) => FromValueCore(value);
}
