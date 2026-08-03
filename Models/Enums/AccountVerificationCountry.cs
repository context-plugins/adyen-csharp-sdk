using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<AccountVerificationCountry>))]
public sealed record AccountVerificationCountry : StringEnum<AccountVerificationCountry>
{
    private AccountVerificationCountry(string value) : base(value)
    {
    }

    public static readonly AccountVerificationCountry Se = new("SE");

    public static readonly AccountVerificationCountry Fi = new("FI");

    public static readonly AccountVerificationCountry No = new("NO");

    public static readonly AccountVerificationCountry Dk = new("DK");

    public static readonly AccountVerificationCountry Nl = new("NL");

    public static readonly AccountVerificationCountry It = new("IT");

    public static readonly AccountVerificationCountry De = new("DE");

    public static readonly AccountVerificationCountry At = new("AT");

    public static readonly AccountVerificationCountry Es = new("ES");

    public static readonly AccountVerificationCountry Pt = new("PT");

    public static readonly AccountVerificationCountry Fr = new("FR");

    public static readonly AccountVerificationCountry Gb = new("GB");

    public static readonly AccountVerificationCountry Be = new("BE");

    public static readonly AccountVerificationCountry Lv = new("LV");

    public static readonly AccountVerificationCountry Lt = new("LT");

    public static readonly AccountVerificationCountry Pl = new("PL");

    public static readonly AccountVerificationCountry Ee = new("EE");

    public static readonly AccountVerificationCountry Ie = new("IE");

    public static readonly AccountVerificationCountry Us = new("US");

    public static readonly AccountVerificationCountry Ca = new("CA");

    public static readonly AccountVerificationCountry Au = new("AU");

    public static AccountVerificationCountry FromValue(string value) => FromValueCore(value);
}
