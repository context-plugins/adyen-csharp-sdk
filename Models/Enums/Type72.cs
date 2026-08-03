using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the source of funds.
/// <para>
///
/// </para>
/// <para>
/// Possible values:
/// *  <b>business</b>
/// *  <b>employment</b>
/// *  <b>donations</b>
/// *  <b>inheritance</b>
/// *  <b>financialAid</b>
/// *  <b>rentalIncome</b>
/// *  <b>dividendIncome</b>
/// *  <b>royaltyIncome</b>
/// *  <b>thirdPartyFunding</b>
/// *  <b>pensionIncome</b>
/// *  <b>insuranceSettlement</b>
/// *  <b>cryptocurrencyIncome</b>
/// *  <b>assetSale</b>
/// *  <b>loans</b>
/// *  <b>gamblingWinnings</b>
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type72>))]
public sealed record Type72 : StringEnum<Type72>
{
    private Type72(string value) : base(value)
    {
    }

    public static readonly Type72 Business = new("business");

    public static readonly Type72 Employment = new("employment");

    public static readonly Type72 Donations = new("donations");

    public static readonly Type72 Inheritance = new("inheritance");

    public static readonly Type72 FinancialAid = new("financialAid");

    public static readonly Type72 RentalIncome = new("rentalIncome");

    public static readonly Type72 DividendIncome = new("dividendIncome");

    public static readonly Type72 RoyaltyIncome = new("royaltyIncome");

    public static readonly Type72 ThirdPartyFunding = new("thirdPartyFunding");

    public static readonly Type72 PensionIncome = new("pensionIncome");

    public static readonly Type72 InsuranceSettlement = new("insuranceSettlement");

    public static readonly Type72 CryptocurrencyIncome = new("cryptocurrencyIncome");

    public static readonly Type72 AssetSale = new("assetSale");

    public static readonly Type72 Loans = new("loans");

    public static readonly Type72 GamblingWinnings = new("gamblingWinnings");

    public static Type72 FromValue(string value) => FromValueCore(value);
}
