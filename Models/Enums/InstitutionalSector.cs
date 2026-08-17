using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The institutional sector the organization operates within.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InstitutionalSector>))]
public sealed record InstitutionalSector : StringEnum<InstitutionalSector>
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

    public static readonly InstitutionalSector CaptiveFinancialInstitutionsAndMoneyLenders = new("captiveFinancialInstitutionsAndMoneyLenders");

    public static readonly InstitutionalSector InsuranceCorporations = new("insuranceCorporations");

    public static readonly InstitutionalSector PensionFunds = new("pensionFunds");

    public static readonly InstitutionalSector CentralGovernment = new("centralGovernment");

    public static readonly InstitutionalSector StateGovernment = new("stateGovernment");

    public static readonly InstitutionalSector LocalGovernment = new("localGovernment");

    public static readonly InstitutionalSector SocialSecurityFunds = new("socialSecurityFunds");

    public static readonly InstitutionalSector NonProfitInstitutionsServingHouseholds = new("nonProfitInstitutionsServingHouseholds");

    public static InstitutionalSector FromValue(string value) => FromValueCore(value);
}
