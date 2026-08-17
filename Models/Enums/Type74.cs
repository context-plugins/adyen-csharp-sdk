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
[JsonConverter(typeof(StringEnumConverter<Type74>))]
public sealed record Type74 : StringEnum<Type74>
{
    private Type74(string value) : base(value)
    {
    }

    public static readonly Type74 Business = new("business");

    public static readonly Type74 Employment = new("employment");

    public static readonly Type74 Donations = new("donations");

    public static readonly Type74 Inheritance = new("inheritance");

    public static readonly Type74 FinancialAid = new("financialAid");

    public static readonly Type74 RentalIncome = new("rentalIncome");

    public static readonly Type74 DividendIncome = new("dividendIncome");

    public static readonly Type74 RoyaltyIncome = new("royaltyIncome");

    public static readonly Type74 ThirdPartyFunding = new("thirdPartyFunding");

    public static readonly Type74 PensionIncome = new("pensionIncome");

    public static readonly Type74 InsuranceSettlement = new("insuranceSettlement");

    public static readonly Type74 CryptocurrencyIncome = new("cryptocurrencyIncome");

    public static readonly Type74 AssetSale = new("assetSale");

    public static readonly Type74 Loans = new("loans");

    public static readonly Type74 GamblingWinnings = new("gamblingWinnings");

    public static Type74 FromValue(string value) => FromValueCore(value);
}
