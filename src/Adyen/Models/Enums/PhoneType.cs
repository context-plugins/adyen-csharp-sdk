using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the phone number.
/// &gt;The following values are permitted: <c>Landline</c>, <c>Mobile</c>, <c>SIP</c>, <c>Fax</c>., The type of the phone number.
/// Possible values: <b>Landline</b>, <b>Mobile</b>, <b>SIP</b>, <b>Fax</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PhoneType>))]
public sealed record PhoneType : OpenStringEnum<PhoneType>
{
    private PhoneType(string value) : base(value)
    {
    }

    public static readonly PhoneType Fax = new("Fax");

    public static readonly PhoneType Landline = new("Landline");

    public static readonly PhoneType Mobile = new("Mobile");

    public static readonly PhoneType Sip = new("SIP");

    public TResult Match<TResult>(Func<TResult> onFax,
        Func<TResult> onLandline,
        Func<TResult> onMobile,
        Func<TResult> onSip,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Fax => onFax(),
            _ when this == Landline => onLandline(),
            _ when this == Mobile => onMobile(),
            _ when this == Sip => onSip(),
            _ => otherwise(Value)
        };

    public void Match(Action onFax, Action onLandline, Action onMobile, Action onSip, Action<string> otherwise)
    {
        if (this == Fax) onFax();
        else if (this == Landline) onLandline();
        else if (this == Mobile) onMobile();
        else if (this == Sip) onSip();
        else otherwise(Value);
    }
}
