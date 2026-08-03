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
[JsonConverter(typeof(StringEnumConverter<AccountType3>))]
public sealed record AccountType3 : StringEnum<AccountType3>
{
    private AccountType3(string value) : base(value)
    {
    }

    public static readonly AccountType3 Default = new("Default");

    public static readonly AccountType3 Savings = new("Savings");

    public static readonly AccountType3 Checking = new("Checking");

    public static readonly AccountType3 CreditCard = new("CreditCard");

    public static readonly AccountType3 Universal = new("Universal");

    public static readonly AccountType3 Investment = new("Investment");

    public static readonly AccountType3 CardTotals = new("CardTotals");

    public static readonly AccountType3 EpurseCard = new("EpurseCard");

    public static AccountType3 FromValue(string value) => FromValueCore(value);
}
