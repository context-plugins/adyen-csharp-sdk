using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of trust.
/// <para>
/// See possible values for trusts in <see href="https://docs.adyen.com/platforms/verification-requirements/?tab=trust_3_4#trust-types-in-australia">Australia</see> and <see href="https://docs.adyen.com/platforms/verification-requirements/?tab=trust_3_4#trust-types-in-new-zealand">New Zealand</see>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type171>))]
public sealed record Type171 : OpenStringEnum<Type171>
{
    private Type171(string value) : base(value)
    {
    }

    public static readonly Type171 BusinessTrust = new("businessTrust");

    public static readonly Type171 CashManagementTrust = new("cashManagementTrust");

    public static readonly Type171 CharitableTrust = new("charitableTrust");

    public static readonly Type171 CorporateUnitTrust = new("corporateUnitTrust");

    public static readonly Type171 DeceasedEstate = new("deceasedEstate");

    public static readonly Type171 DiscretionaryTrust = new("discretionaryTrust");

    public static readonly Type171 DiscretionaryInvestmentTrust = new("discretionaryInvestmentTrust");

    public static readonly Type171 DiscretionaryServicesManagementTrust = new("discretionaryServicesManagementTrust");

    public static readonly Type171 DiscretionaryTradingTrust = new("discretionaryTradingTrust");

    public static readonly Type171 FamilyTrust = new("familyTrust");

    public static readonly Type171 FirstHomeSaverAccountsTrust = new("firstHomeSaverAccountsTrust");

    public static readonly Type171 FixedTrust = new("fixedTrust");

    public static readonly Type171 FixedUnitTrust = new("fixedUnitTrust");

    public static readonly Type171 HybridTrust = new("hybridTrust");

    public static readonly Type171 ListedPublicUnitTrust = new("listedPublicUnitTrust");

    public static readonly Type171 OtherTrust = new("otherTrust");

    public static readonly Type171 PooledSuperannuationTrust = new("pooledSuperannuationTrust");

    public static readonly Type171 PublicTradingTrust = new("publicTradingTrust");

    public static readonly Type171 UnlistedPublicUnitTrust = new("unlistedPublicUnitTrust");

    public TResult Match<TResult>(Func<TResult> onBusinessTrust,
        Func<TResult> onCashManagementTrust,
        Func<TResult> onCharitableTrust,
        Func<TResult> onCorporateUnitTrust,
        Func<TResult> onDeceasedEstate,
        Func<TResult> onDiscretionaryTrust,
        Func<TResult> onDiscretionaryInvestmentTrust,
        Func<TResult> onDiscretionaryServicesManagementTrust,
        Func<TResult> onDiscretionaryTradingTrust,
        Func<TResult> onFamilyTrust,
        Func<TResult> onFirstHomeSaverAccountsTrust,
        Func<TResult> onFixedTrust,
        Func<TResult> onFixedUnitTrust,
        Func<TResult> onHybridTrust,
        Func<TResult> onListedPublicUnitTrust,
        Func<TResult> onOtherTrust,
        Func<TResult> onPooledSuperannuationTrust,
        Func<TResult> onPublicTradingTrust,
        Func<TResult> onUnlistedPublicUnitTrust,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BusinessTrust => onBusinessTrust(),
            _ when this == CashManagementTrust => onCashManagementTrust(),
            _ when this == CharitableTrust => onCharitableTrust(),
            _ when this == CorporateUnitTrust => onCorporateUnitTrust(),
            _ when this == DeceasedEstate => onDeceasedEstate(),
            _ when this == DiscretionaryTrust => onDiscretionaryTrust(),
            _ when this == DiscretionaryInvestmentTrust => onDiscretionaryInvestmentTrust(),
            _ when this == DiscretionaryServicesManagementTrust => onDiscretionaryServicesManagementTrust(),
            _ when this == DiscretionaryTradingTrust => onDiscretionaryTradingTrust(),
            _ when this == FamilyTrust => onFamilyTrust(),
            _ when this == FirstHomeSaverAccountsTrust => onFirstHomeSaverAccountsTrust(),
            _ when this == FixedTrust => onFixedTrust(),
            _ when this == FixedUnitTrust => onFixedUnitTrust(),
            _ when this == HybridTrust => onHybridTrust(),
            _ when this == ListedPublicUnitTrust => onListedPublicUnitTrust(),
            _ when this == OtherTrust => onOtherTrust(),
            _ when this == PooledSuperannuationTrust => onPooledSuperannuationTrust(),
            _ when this == PublicTradingTrust => onPublicTradingTrust(),
            _ when this == UnlistedPublicUnitTrust => onUnlistedPublicUnitTrust(),
            _ => otherwise(Value)
        };

    public void Match(Action onBusinessTrust,
        Action onCashManagementTrust,
        Action onCharitableTrust,
        Action onCorporateUnitTrust,
        Action onDeceasedEstate,
        Action onDiscretionaryTrust,
        Action onDiscretionaryInvestmentTrust,
        Action onDiscretionaryServicesManagementTrust,
        Action onDiscretionaryTradingTrust,
        Action onFamilyTrust,
        Action onFirstHomeSaverAccountsTrust,
        Action onFixedTrust,
        Action onFixedUnitTrust,
        Action onHybridTrust,
        Action onListedPublicUnitTrust,
        Action onOtherTrust,
        Action onPooledSuperannuationTrust,
        Action onPublicTradingTrust,
        Action onUnlistedPublicUnitTrust,
        Action<string> otherwise)
    {
        if (this == BusinessTrust) onBusinessTrust();
        else if (this == CashManagementTrust) onCashManagementTrust();
        else if (this == CharitableTrust) onCharitableTrust();
        else if (this == CorporateUnitTrust) onCorporateUnitTrust();
        else if (this == DeceasedEstate) onDeceasedEstate();
        else if (this == DiscretionaryTrust) onDiscretionaryTrust();
        else if (this == DiscretionaryInvestmentTrust) onDiscretionaryInvestmentTrust();
        else if (this == DiscretionaryServicesManagementTrust) onDiscretionaryServicesManagementTrust();
        else if (this == DiscretionaryTradingTrust) onDiscretionaryTradingTrust();
        else if (this == FamilyTrust) onFamilyTrust();
        else if (this == FirstHomeSaverAccountsTrust) onFirstHomeSaverAccountsTrust();
        else if (this == FixedTrust) onFixedTrust();
        else if (this == FixedUnitTrust) onFixedUnitTrust();
        else if (this == HybridTrust) onHybridTrust();
        else if (this == ListedPublicUnitTrust) onListedPublicUnitTrust();
        else if (this == OtherTrust) onOtherTrust();
        else if (this == PooledSuperannuationTrust) onPooledSuperannuationTrust();
        else if (this == PublicTradingTrust) onPublicTradingTrust();
        else if (this == UnlistedPublicUnitTrust) onUnlistedPublicUnitTrust();
        else otherwise(Value);
    }
}
