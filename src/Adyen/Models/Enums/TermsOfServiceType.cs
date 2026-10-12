using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TermsOfServiceType>))]
public sealed record TermsOfServiceType : OpenStringEnum<TermsOfServiceType>
{
    private TermsOfServiceType(string value) : base(value)
    {
    }

    public static readonly TermsOfServiceType AdyenAccount = new("adyenAccount");

    public static readonly TermsOfServiceType AdyenCapital = new("adyenCapital");

    public static readonly TermsOfServiceType AdyenCard = new("adyenCard");

    public static readonly TermsOfServiceType AdyenChargeCard = new("adyenChargeCard");

    public static readonly TermsOfServiceType AdyenForPlatformsAdvanced = new("adyenForPlatformsAdvanced");

    public static readonly TermsOfServiceType AdyenForPlatformsManage = new("adyenForPlatformsManage");

    public static readonly TermsOfServiceType AdyenFranchisee = new("adyenFranchisee");

    public static readonly TermsOfServiceType AdyenIssuing = new("adyenIssuing");

    public static readonly TermsOfServiceType AdyenPccr = new("adyenPccr");

    public static readonly TermsOfServiceType KycOnInvite = new("kycOnInvite");

    public TResult Match<TResult>(Func<TResult> onAdyenAccount,
        Func<TResult> onAdyenCapital,
        Func<TResult> onAdyenCard,
        Func<TResult> onAdyenChargeCard,
        Func<TResult> onAdyenForPlatformsAdvanced,
        Func<TResult> onAdyenForPlatformsManage,
        Func<TResult> onAdyenFranchisee,
        Func<TResult> onAdyenIssuing,
        Func<TResult> onAdyenPccr,
        Func<TResult> onKycOnInvite,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AdyenAccount => onAdyenAccount(),
            _ when this == AdyenCapital => onAdyenCapital(),
            _ when this == AdyenCard => onAdyenCard(),
            _ when this == AdyenChargeCard => onAdyenChargeCard(),
            _ when this == AdyenForPlatformsAdvanced => onAdyenForPlatformsAdvanced(),
            _ when this == AdyenForPlatformsManage => onAdyenForPlatformsManage(),
            _ when this == AdyenFranchisee => onAdyenFranchisee(),
            _ when this == AdyenIssuing => onAdyenIssuing(),
            _ when this == AdyenPccr => onAdyenPccr(),
            _ when this == KycOnInvite => onKycOnInvite(),
            _ => otherwise(Value)
        };

    public void Match(Action onAdyenAccount,
        Action onAdyenCapital,
        Action onAdyenCard,
        Action onAdyenChargeCard,
        Action onAdyenForPlatformsAdvanced,
        Action onAdyenForPlatformsManage,
        Action onAdyenFranchisee,
        Action onAdyenIssuing,
        Action onAdyenPccr,
        Action onKycOnInvite,
        Action<string> otherwise)
    {
        if (this == AdyenAccount) onAdyenAccount();
        else if (this == AdyenCapital) onAdyenCapital();
        else if (this == AdyenCard) onAdyenCard();
        else if (this == AdyenChargeCard) onAdyenChargeCard();
        else if (this == AdyenForPlatformsAdvanced) onAdyenForPlatformsAdvanced();
        else if (this == AdyenForPlatformsManage) onAdyenForPlatformsManage();
        else if (this == AdyenFranchisee) onAdyenFranchisee();
        else if (this == AdyenIssuing) onAdyenIssuing();
        else if (this == AdyenPccr) onAdyenPccr();
        else if (this == KycOnInvite) onKycOnInvite();
        else otherwise(Value);
    }
}
