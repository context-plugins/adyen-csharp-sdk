using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The institutional sector the organization operates within.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InstitutionalSector>))]
public sealed record InstitutionalSector : OpenStringEnum<InstitutionalSector>
{
    private InstitutionalSector(string value) : base(value)
    {
    }

    public static readonly InstitutionalSector NonFinancialCorporation = new("nonFinancialCorporation");

    public static readonly InstitutionalSector CentralBank = new("centralBank");

    public static readonly InstitutionalSector CreditInstitutions = new("creditInstitutions");

    public static readonly InstitutionalSector DepositTakingCorporations = new("depositTakingCorporations");

    public static readonly InstitutionalSector MoneyMarketFunds = new("moneyMarketFunds");

    public static readonly InstitutionalSector NonMmfInvestmentFunds = new("nonMMFInvestmentFunds");

    public static readonly InstitutionalSector FinancialVehicleCorporation = new("financialVehicleCorporation");

    public static readonly InstitutionalSector OtherFinancialIntermediaries = new("otherFinancialIntermediaries");

    public static readonly InstitutionalSector FinancialAuxiliaries = new("financialAuxiliaries");

    public static readonly InstitutionalSector CaptiveFinancialInstitutionsAndMoneyLenders = new(
        "captiveFinancialInstitutionsAndMoneyLenders");

    public static readonly InstitutionalSector InsuranceCorporations = new("insuranceCorporations");

    public static readonly InstitutionalSector PensionFunds = new("pensionFunds");

    public static readonly InstitutionalSector CentralGovernment = new("centralGovernment");

    public static readonly InstitutionalSector StateGovernment = new("stateGovernment");

    public static readonly InstitutionalSector LocalGovernment = new("localGovernment");

    public static readonly InstitutionalSector SocialSecurityFunds = new("socialSecurityFunds");

    public static readonly InstitutionalSector NonProfitInstitutionsServingHouseholds = new(
        "nonProfitInstitutionsServingHouseholds");

    public TResult Match<TResult>(Func<TResult> onNonFinancialCorporation,
        Func<TResult> onCentralBank,
        Func<TResult> onCreditInstitutions,
        Func<TResult> onDepositTakingCorporations,
        Func<TResult> onMoneyMarketFunds,
        Func<TResult> onNonMmfInvestmentFunds,
        Func<TResult> onFinancialVehicleCorporation,
        Func<TResult> onOtherFinancialIntermediaries,
        Func<TResult> onFinancialAuxiliaries,
        Func<TResult> onCaptiveFinancialInstitutionsAndMoneyLenders,
        Func<TResult> onInsuranceCorporations,
        Func<TResult> onPensionFunds,
        Func<TResult> onCentralGovernment,
        Func<TResult> onStateGovernment,
        Func<TResult> onLocalGovernment,
        Func<TResult> onSocialSecurityFunds,
        Func<TResult> onNonProfitInstitutionsServingHouseholds,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NonFinancialCorporation => onNonFinancialCorporation(),
            _ when this == CentralBank => onCentralBank(),
            _ when this == CreditInstitutions => onCreditInstitutions(),
            _ when this == DepositTakingCorporations => onDepositTakingCorporations(),
            _ when this == MoneyMarketFunds => onMoneyMarketFunds(),
            _ when this == NonMmfInvestmentFunds => onNonMmfInvestmentFunds(),
            _ when this == FinancialVehicleCorporation => onFinancialVehicleCorporation(),
            _ when this == OtherFinancialIntermediaries => onOtherFinancialIntermediaries(),
            _ when this == FinancialAuxiliaries => onFinancialAuxiliaries(),
            _ when this ==
                CaptiveFinancialInstitutionsAndMoneyLenders => onCaptiveFinancialInstitutionsAndMoneyLenders(),
            _ when this == InsuranceCorporations => onInsuranceCorporations(),
            _ when this == PensionFunds => onPensionFunds(),
            _ when this == CentralGovernment => onCentralGovernment(),
            _ when this == StateGovernment => onStateGovernment(),
            _ when this == LocalGovernment => onLocalGovernment(),
            _ when this == SocialSecurityFunds => onSocialSecurityFunds(),
            _ when this == NonProfitInstitutionsServingHouseholds => onNonProfitInstitutionsServingHouseholds(),
            _ => otherwise(Value)
        };

    public void Match(Action onNonFinancialCorporation,
        Action onCentralBank,
        Action onCreditInstitutions,
        Action onDepositTakingCorporations,
        Action onMoneyMarketFunds,
        Action onNonMmfInvestmentFunds,
        Action onFinancialVehicleCorporation,
        Action onOtherFinancialIntermediaries,
        Action onFinancialAuxiliaries,
        Action onCaptiveFinancialInstitutionsAndMoneyLenders,
        Action onInsuranceCorporations,
        Action onPensionFunds,
        Action onCentralGovernment,
        Action onStateGovernment,
        Action onLocalGovernment,
        Action onSocialSecurityFunds,
        Action onNonProfitInstitutionsServingHouseholds,
        Action<string> otherwise)
    {
        if (this == NonFinancialCorporation) onNonFinancialCorporation();
        else if (this == CentralBank) onCentralBank();
        else if (this == CreditInstitutions) onCreditInstitutions();
        else if (this == DepositTakingCorporations) onDepositTakingCorporations();
        else if (this == MoneyMarketFunds) onMoneyMarketFunds();
        else if (this == NonMmfInvestmentFunds) onNonMmfInvestmentFunds();
        else if (this == FinancialVehicleCorporation) onFinancialVehicleCorporation();
        else if (this == OtherFinancialIntermediaries) onOtherFinancialIntermediaries();
        else if (this == FinancialAuxiliaries) onFinancialAuxiliaries();
        else if (this == CaptiveFinancialInstitutionsAndMoneyLenders) onCaptiveFinancialInstitutionsAndMoneyLenders();
        else if (this == InsuranceCorporations) onInsuranceCorporations();
        else if (this == PensionFunds) onPensionFunds();
        else if (this == CentralGovernment) onCentralGovernment();
        else if (this == StateGovernment) onStateGovernment();
        else if (this == LocalGovernment) onLocalGovernment();
        else if (this == SocialSecurityFunds) onSocialSecurityFunds();
        else if (this == NonProfitInstitutionsServingHouseholds) onNonProfitInstitutionsServingHouseholds();
        else otherwise(Value);
    }
}
