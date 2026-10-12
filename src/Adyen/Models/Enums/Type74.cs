using System;
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
public sealed record Type74 : OpenStringEnum<Type74>
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

    public TResult Match<TResult>(Func<TResult> onBusiness,
        Func<TResult> onEmployment,
        Func<TResult> onDonations,
        Func<TResult> onInheritance,
        Func<TResult> onFinancialAid,
        Func<TResult> onRentalIncome,
        Func<TResult> onDividendIncome,
        Func<TResult> onRoyaltyIncome,
        Func<TResult> onThirdPartyFunding,
        Func<TResult> onPensionIncome,
        Func<TResult> onInsuranceSettlement,
        Func<TResult> onCryptocurrencyIncome,
        Func<TResult> onAssetSale,
        Func<TResult> onLoans,
        Func<TResult> onGamblingWinnings,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Business => onBusiness(),
            _ when this == Employment => onEmployment(),
            _ when this == Donations => onDonations(),
            _ when this == Inheritance => onInheritance(),
            _ when this == FinancialAid => onFinancialAid(),
            _ when this == RentalIncome => onRentalIncome(),
            _ when this == DividendIncome => onDividendIncome(),
            _ when this == RoyaltyIncome => onRoyaltyIncome(),
            _ when this == ThirdPartyFunding => onThirdPartyFunding(),
            _ when this == PensionIncome => onPensionIncome(),
            _ when this == InsuranceSettlement => onInsuranceSettlement(),
            _ when this == CryptocurrencyIncome => onCryptocurrencyIncome(),
            _ when this == AssetSale => onAssetSale(),
            _ when this == Loans => onLoans(),
            _ when this == GamblingWinnings => onGamblingWinnings(),
            _ => otherwise(Value)
        };

    public void Match(Action onBusiness,
        Action onEmployment,
        Action onDonations,
        Action onInheritance,
        Action onFinancialAid,
        Action onRentalIncome,
        Action onDividendIncome,
        Action onRoyaltyIncome,
        Action onThirdPartyFunding,
        Action onPensionIncome,
        Action onInsuranceSettlement,
        Action onCryptocurrencyIncome,
        Action onAssetSale,
        Action onLoans,
        Action onGamblingWinnings,
        Action<string> otherwise)
    {
        if (this == Business) onBusiness();
        else if (this == Employment) onEmployment();
        else if (this == Donations) onDonations();
        else if (this == Inheritance) onInheritance();
        else if (this == FinancialAid) onFinancialAid();
        else if (this == RentalIncome) onRentalIncome();
        else if (this == DividendIncome) onDividendIncome();
        else if (this == RoyaltyIncome) onRoyaltyIncome();
        else if (this == ThirdPartyFunding) onThirdPartyFunding();
        else if (this == PensionIncome) onPensionIncome();
        else if (this == InsuranceSettlement) onInsuranceSettlement();
        else if (this == CryptocurrencyIncome) onCryptocurrencyIncome();
        else if (this == AssetSale) onAssetSale();
        else if (this == Loans) onLoans();
        else if (this == GamblingWinnings) onGamblingWinnings();
        else otherwise(Value);
    }
}
