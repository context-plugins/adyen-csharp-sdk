using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of identity data. For individuals, the following types are supported. See our <see href="https://docs.adyen.com/platforms/onboard-users/onboarding-steps/?onboarding_type=custom">onboarding guide</see> for other supported countries.
/// <list type="bullet">
///   <item><description>Australia: <b>driversLicense</b>, <b>passport</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description>Hong Kong: <b>driversLicense</b>, <b>nationalIdNumber</b>, <b>passport</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description>New Zealand: <b>driversLicense</b>, <b>passport</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description>Singapore: <b>driversLicense</b>, <b>nationalIdNumber</b>, <b>passport</b></description></item>
/// </list>
/// <list type="bullet">
///   <item><description>All other supported countries: <b>nationalIdNumber</b></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type132>))]
public sealed record Type132 : OpenStringEnum<Type132>
{
    private Type132(string value) : base(value)
    {
    }

    public static readonly Type132 NationalIdNumber = new("nationalIdNumber");

    public static readonly Type132 Passport = new("passport");

    public static readonly Type132 DriversLicense = new("driversLicense");

    public static readonly Type132 IdentityCard = new("identityCard");

    public TResult Match<TResult>(Func<TResult> onNationalIdNumber,
        Func<TResult> onPassport,
        Func<TResult> onDriversLicense,
        Func<TResult> onIdentityCard,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NationalIdNumber => onNationalIdNumber(),
            _ when this == Passport => onPassport(),
            _ when this == DriversLicense => onDriversLicense(),
            _ when this == IdentityCard => onIdentityCard(),
            _ => otherwise(Value)
        };

    public void Match(Action onNationalIdNumber,
        Action onPassport,
        Action onDriversLicense,
        Action onIdentityCard,
        Action<string> otherwise)
    {
        if (this == NationalIdNumber) onNationalIdNumber();
        else if (this == Passport) onPassport();
        else if (this == DriversLicense) onDriversLicense();
        else if (this == IdentityCard) onIdentityCard();
        else otherwise(Value);
    }
}
