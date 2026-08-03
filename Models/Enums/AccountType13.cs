using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of cardholder account used for the transaction. Allows a cardholder to select the type of account used for the transaction.
/// Possible values:
/// * <b>CardTotals</b>
/// * <b>Checking</b>
/// * <b>CreditCard</b>
/// * <b>Default</b>
/// * <b>EpurseCard</b>
/// * <b>Investment</b>
/// * <b>Savings</b>
/// * <b>Universal</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountType13>))]
public sealed record AccountType13 : StringEnum<AccountType13>
{
    private AccountType13(string value) : base(value)
    {
    }

    public static readonly AccountType13 Default = new("Default");

    public static readonly AccountType13 Savings = new("Savings");

    public static readonly AccountType13 Checking = new("Checking");

    public static readonly AccountType13 CreditCard = new("CreditCard");

    public static readonly AccountType13 Universal = new("Universal");

    public static readonly AccountType13 Investment = new("Investment");

    public static readonly AccountType13 CardTotals = new("CardTotals");

    public static readonly AccountType13 EpurseCard = new("EpurseCard");

    public static AccountType13 FromValue(string value) => FromValueCore(value);
}
