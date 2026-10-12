using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of check.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>BANK_ACCOUNT_VERIFICATION</b>: Used in v5 and earlier. Replaced by <b>PAYOUT_METHOD_VERIFICATION</b> in v6 and later.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>COMPANY_VERIFICATION</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>CARD_VERIFICATION</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>IDENTITY_VERIFICATION</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>LEGAL_ARRANGEMENT_VERIFICATION</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>NONPROFIT_VERIFICATION</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>PASSPORT_VERIFICATION</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>PAYOUT_METHOD_VERIFICATION</b>: Used in v6 and later.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>PCI_VERIFICATION</b></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type211>))]
public sealed record Type211 : OpenStringEnum<Type211>
{
    private Type211(string value) : base(value)
    {
    }

    public static readonly Type211 BankAccountVerification = new("BANK_ACCOUNT_VERIFICATION");

    public static readonly Type211 CardVerification = new("CARD_VERIFICATION");

    public static readonly Type211 CompanyVerification = new("COMPANY_VERIFICATION");

    public static readonly Type211 IdentityVerification = new("IDENTITY_VERIFICATION");

    public static readonly Type211 LegalArrangementVerification = new("LEGAL_ARRANGEMENT_VERIFICATION");

    public static readonly Type211 NonprofitVerification = new("NONPROFIT_VERIFICATION");

    public static readonly Type211 PassportVerification = new("PASSPORT_VERIFICATION");

    public static readonly Type211 PayoutMethodVerification = new("PAYOUT_METHOD_VERIFICATION");

    public static readonly Type211 PciVerification = new("PCI_VERIFICATION");

    public TResult Match<TResult>(Func<TResult> onBankAccountVerification,
        Func<TResult> onCardVerification,
        Func<TResult> onCompanyVerification,
        Func<TResult> onIdentityVerification,
        Func<TResult> onLegalArrangementVerification,
        Func<TResult> onNonprofitVerification,
        Func<TResult> onPassportVerification,
        Func<TResult> onPayoutMethodVerification,
        Func<TResult> onPciVerification,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == BankAccountVerification => onBankAccountVerification(),
            _ when this == CardVerification => onCardVerification(),
            _ when this == CompanyVerification => onCompanyVerification(),
            _ when this == IdentityVerification => onIdentityVerification(),
            _ when this == LegalArrangementVerification => onLegalArrangementVerification(),
            _ when this == NonprofitVerification => onNonprofitVerification(),
            _ when this == PassportVerification => onPassportVerification(),
            _ when this == PayoutMethodVerification => onPayoutMethodVerification(),
            _ when this == PciVerification => onPciVerification(),
            _ => otherwise(Value)
        };

    public void Match(Action onBankAccountVerification,
        Action onCardVerification,
        Action onCompanyVerification,
        Action onIdentityVerification,
        Action onLegalArrangementVerification,
        Action onNonprofitVerification,
        Action onPassportVerification,
        Action onPayoutMethodVerification,
        Action onPciVerification,
        Action<string> otherwise)
    {
        if (this == BankAccountVerification) onBankAccountVerification();
        else if (this == CardVerification) onCardVerification();
        else if (this == CompanyVerification) onCompanyVerification();
        else if (this == IdentityVerification) onIdentityVerification();
        else if (this == LegalArrangementVerification) onLegalArrangementVerification();
        else if (this == NonprofitVerification) onNonprofitVerification();
        else if (this == PassportVerification) onPassportVerification();
        else if (this == PayoutMethodVerification) onPayoutMethodVerification();
        else if (this == PciVerification) onPciVerification();
        else otherwise(Value);
    }
}
