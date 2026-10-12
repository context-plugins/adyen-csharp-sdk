using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of phone number.
/// Possible values:
/// <b>Landline</b>, <b>Mobile</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type410>))]
public sealed record Type410 : OpenStringEnum<Type410>
{
    private Type410(string value) : base(value)
    {
    }

    public static readonly Type410 Landline = new("landline");

    public static readonly Type410 Mobile = new("mobile");

    public TResult Match<TResult>(Func<TResult> onLandline, Func<TResult> onMobile, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Landline => onLandline(),
            _ when this == Mobile => onMobile(),
            _ => otherwise(Value)
        };

    public void Match(Action onLandline, Action onMobile, Action<string> otherwise)
    {
        if (this == Landline) onLandline();
        else if (this == Mobile) onMobile();
        else otherwise(Value);
    }
}
