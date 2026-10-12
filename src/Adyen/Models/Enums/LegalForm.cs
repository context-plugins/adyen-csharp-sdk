using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The form of legal arrangement. Required if <c>type</c> is <b>Trust</b> or <b>Partnership</b>.
/// <para>
/// The possible values depend on the <c>type</c>.
/// </para>
/// <list type="bullet">
///   <item><description>For <c>type</c> <b>Trust</b>:  <b>CashManagementTrust</b>, <b>CorporateUnitTrust</b>, <b>DeceasedEstate</b>, <b>DiscretionaryInvestmentTrust</b>, <b>DiscretionaryServicesManagementTrust</b>, <b>DiscretionaryTradingTrust</b>, <b>FirstHomeSaverAccountsTrust</b>, <b>FixedTrust</b>, <b>FixedUnitTrust</b>, <b>HybridTrust</b>, <b>ListedPublicUnitTrust</b>, <b>OtherTrust</b>, <b>PooledSuperannuationTrust</b>, <b>PublicTradingTrust</b>, or <b>UnlistedPublicUnitTrust</b>.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description>For <c>type</c> <b>Partnership</b>: <b>LimitedPartnership</b>, <b>FamilyPartnership</b>, or <b>OtherPartnership</b></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LegalForm>))]
public sealed record LegalForm : OpenStringEnum<LegalForm>
{
    private LegalForm(string value) : base(value)
    {
    }

    public static readonly LegalForm CashManagementTrust = new("CashManagementTrust");

    public static readonly LegalForm CorporateUnitTrust = new("CorporateUnitTrust");

    public static readonly LegalForm DeceasedEstate = new("DeceasedEstate");

    public static readonly LegalForm DiscretionaryInvestmentTrust = new("DiscretionaryInvestmentTrust");

    public static readonly LegalForm DiscretionaryServicesManagementTrust = new("DiscretionaryServicesManagementTrust");

    public static readonly LegalForm DiscretionaryTradingTrust = new("DiscretionaryTradingTrust");

    public static readonly LegalForm FirstHomeSaverAccountsTrust = new("FirstHomeSaverAccountsTrust");

    public static readonly LegalForm FixedTrust = new("FixedTrust");

    public static readonly LegalForm FixedUnitTrust = new("FixedUnitTrust");

    public static readonly LegalForm HybridTrust = new("HybridTrust");

    public static readonly LegalForm ListedPublicUnitTrust = new("ListedPublicUnitTrust");

    public static readonly LegalForm OtherTrust = new("OtherTrust");

    public static readonly LegalForm PooledSuperannuationTrust = new("PooledSuperannuationTrust");

    public static readonly LegalForm PublicTradingTrust = new("PublicTradingTrust");

    public static readonly LegalForm UnlistedPublicUnitTrust = new("UnlistedPublicUnitTrust");

    public static readonly LegalForm LimitedPartnership = new("LimitedPartnership");

    public static readonly LegalForm FamilyPartnership = new("FamilyPartnership");

    public static readonly LegalForm OtherPartnership = new("OtherPartnership");

    public TResult Match<TResult>(Func<TResult> onCashManagementTrust,
        Func<TResult> onCorporateUnitTrust,
        Func<TResult> onDeceasedEstate,
        Func<TResult> onDiscretionaryInvestmentTrust,
        Func<TResult> onDiscretionaryServicesManagementTrust,
        Func<TResult> onDiscretionaryTradingTrust,
        Func<TResult> onFirstHomeSaverAccountsTrust,
        Func<TResult> onFixedTrust,
        Func<TResult> onFixedUnitTrust,
        Func<TResult> onHybridTrust,
        Func<TResult> onListedPublicUnitTrust,
        Func<TResult> onOtherTrust,
        Func<TResult> onPooledSuperannuationTrust,
        Func<TResult> onPublicTradingTrust,
        Func<TResult> onUnlistedPublicUnitTrust,
        Func<TResult> onLimitedPartnership,
        Func<TResult> onFamilyPartnership,
        Func<TResult> onOtherPartnership,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CashManagementTrust => onCashManagementTrust(),
            _ when this == CorporateUnitTrust => onCorporateUnitTrust(),
            _ when this == DeceasedEstate => onDeceasedEstate(),
            _ when this == DiscretionaryInvestmentTrust => onDiscretionaryInvestmentTrust(),
            _ when this == DiscretionaryServicesManagementTrust => onDiscretionaryServicesManagementTrust(),
            _ when this == DiscretionaryTradingTrust => onDiscretionaryTradingTrust(),
            _ when this == FirstHomeSaverAccountsTrust => onFirstHomeSaverAccountsTrust(),
            _ when this == FixedTrust => onFixedTrust(),
            _ when this == FixedUnitTrust => onFixedUnitTrust(),
            _ when this == HybridTrust => onHybridTrust(),
            _ when this == ListedPublicUnitTrust => onListedPublicUnitTrust(),
            _ when this == OtherTrust => onOtherTrust(),
            _ when this == PooledSuperannuationTrust => onPooledSuperannuationTrust(),
            _ when this == PublicTradingTrust => onPublicTradingTrust(),
            _ when this == UnlistedPublicUnitTrust => onUnlistedPublicUnitTrust(),
            _ when this == LimitedPartnership => onLimitedPartnership(),
            _ when this == FamilyPartnership => onFamilyPartnership(),
            _ when this == OtherPartnership => onOtherPartnership(),
            _ => otherwise(Value)
        };

    public void Match(Action onCashManagementTrust,
        Action onCorporateUnitTrust,
        Action onDeceasedEstate,
        Action onDiscretionaryInvestmentTrust,
        Action onDiscretionaryServicesManagementTrust,
        Action onDiscretionaryTradingTrust,
        Action onFirstHomeSaverAccountsTrust,
        Action onFixedTrust,
        Action onFixedUnitTrust,
        Action onHybridTrust,
        Action onListedPublicUnitTrust,
        Action onOtherTrust,
        Action onPooledSuperannuationTrust,
        Action onPublicTradingTrust,
        Action onUnlistedPublicUnitTrust,
        Action onLimitedPartnership,
        Action onFamilyPartnership,
        Action onOtherPartnership,
        Action<string> otherwise)
    {
        if (this == CashManagementTrust) onCashManagementTrust();
        else if (this == CorporateUnitTrust) onCorporateUnitTrust();
        else if (this == DeceasedEstate) onDeceasedEstate();
        else if (this == DiscretionaryInvestmentTrust) onDiscretionaryInvestmentTrust();
        else if (this == DiscretionaryServicesManagementTrust) onDiscretionaryServicesManagementTrust();
        else if (this == DiscretionaryTradingTrust) onDiscretionaryTradingTrust();
        else if (this == FirstHomeSaverAccountsTrust) onFirstHomeSaverAccountsTrust();
        else if (this == FixedTrust) onFixedTrust();
        else if (this == FixedUnitTrust) onFixedUnitTrust();
        else if (this == HybridTrust) onHybridTrust();
        else if (this == ListedPublicUnitTrust) onListedPublicUnitTrust();
        else if (this == OtherTrust) onOtherTrust();
        else if (this == PooledSuperannuationTrust) onPooledSuperannuationTrust();
        else if (this == PublicTradingTrust) onPublicTradingTrust();
        else if (this == UnlistedPublicUnitTrust) onUnlistedPublicUnitTrust();
        else if (this == LimitedPartnership) onLimitedPartnership();
        else if (this == FamilyPartnership) onFamilyPartnership();
        else if (this == OtherPartnership) onOtherPartnership();
        else otherwise(Value);
    }
}
