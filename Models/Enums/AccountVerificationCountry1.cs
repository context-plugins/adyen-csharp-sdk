using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The location where the third-party individual's bank account is registered.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountVerificationCountry1>))]
public sealed record AccountVerificationCountry1 : StringEnum<AccountVerificationCountry1>
{
    private AccountVerificationCountry1(string value) : base(value)
    {
    }

    public static readonly AccountVerificationCountry1 Se = new("SE");

    public static readonly AccountVerificationCountry1 Fi = new("FI");

    public static readonly AccountVerificationCountry1 No = new("NO");

    public static readonly AccountVerificationCountry1 Dk = new("DK");

    public static readonly AccountVerificationCountry1 Nl = new("NL");

    public static readonly AccountVerificationCountry1 It = new("IT");

    public static readonly AccountVerificationCountry1 De = new("DE");

    public static readonly AccountVerificationCountry1 At = new("AT");

    public static readonly AccountVerificationCountry1 Es = new("ES");

    public static readonly AccountVerificationCountry1 Pt = new("PT");

    public static readonly AccountVerificationCountry1 Fr = new("FR");

    public static readonly AccountVerificationCountry1 Gb = new("GB");

    public static readonly AccountVerificationCountry1 Be = new("BE");

    public static readonly AccountVerificationCountry1 Lv = new("LV");

    public static readonly AccountVerificationCountry1 Lt = new("LT");

    public static readonly AccountVerificationCountry1 Pl = new("PL");

    public static readonly AccountVerificationCountry1 Ee = new("EE");

    public static readonly AccountVerificationCountry1 Ie = new("IE");

    public static readonly AccountVerificationCountry1 Us = new("US");

    public static readonly AccountVerificationCountry1 Ca = new("CA");

    public static readonly AccountVerificationCountry1 Au = new("AU");

    public static AccountVerificationCountry1 FromValue(string value) => FromValueCore(value);
}
