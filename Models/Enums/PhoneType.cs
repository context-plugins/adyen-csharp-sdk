using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the phone number.
/// &gt;The following values are permitted: <c>Landline</c>, <c>Mobile</c>, <c>SIP</c>, <c>Fax</c>., The type of the phone number.
/// Possible values: <b>Landline</b>, <b>Mobile</b>, <b>SIP</b>, <b>Fax</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PhoneType>))]
public sealed record PhoneType : StringEnum<PhoneType>
{
    private PhoneType(string value) : base(value)
    {
    }

    public static readonly PhoneType Fax = new("Fax");

    public static readonly PhoneType Landline = new("Landline");

    public static readonly PhoneType Mobile = new("Mobile");

    public static readonly PhoneType Sip = new("SIP");

    public static PhoneType FromValue(string value) => FromValueCore(value);
}
