using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The location where the third-party individual's bank account is registered. Adyen uses this information to determine an available open banking provider, and to configure the open banking flow for that respective location.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountVerificationCountry2>))]
public sealed record AccountVerificationCountry2 : StringEnum<AccountVerificationCountry2>
{
    private AccountVerificationCountry2(string value) : base(value)
    {
    }

    public static readonly AccountVerificationCountry2 Se = new("SE");

    public static readonly AccountVerificationCountry2 Fi = new("FI");

    public static readonly AccountVerificationCountry2 No = new("NO");

    public static readonly AccountVerificationCountry2 Dk = new("DK");

    public static readonly AccountVerificationCountry2 Nl = new("NL");

    public static readonly AccountVerificationCountry2 It = new("IT");

    public static readonly AccountVerificationCountry2 De = new("DE");

    public static readonly AccountVerificationCountry2 At = new("AT");

    public static readonly AccountVerificationCountry2 Es = new("ES");

    public static readonly AccountVerificationCountry2 Pt = new("PT");

    public static readonly AccountVerificationCountry2 Fr = new("FR");

    public static readonly AccountVerificationCountry2 Gb = new("GB");

    public static readonly AccountVerificationCountry2 Be = new("BE");

    public static readonly AccountVerificationCountry2 Lv = new("LV");

    public static readonly AccountVerificationCountry2 Lt = new("LT");

    public static readonly AccountVerificationCountry2 Pl = new("PL");

    public static readonly AccountVerificationCountry2 Ee = new("EE");

    public static readonly AccountVerificationCountry2 Ie = new("IE");

    public static readonly AccountVerificationCountry2 Us = new("US");

    public static readonly AccountVerificationCountry2 Ca = new("CA");

    public static readonly AccountVerificationCountry2 Au = new("AU");

    public static AccountVerificationCountry2 FromValue(string value) => FromValueCore(value);
}
