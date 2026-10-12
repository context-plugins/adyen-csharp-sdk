using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The gender.
/// &gt;The following values are permitted: <c>MALE</c>, <c>FEMALE</c>, <c>UNKNOWN</c>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Gender>))]
public sealed record Gender : OpenStringEnum<Gender>
{
    private Gender(string value) : base(value)
    {
    }

    public static readonly Gender Male = new("MALE");

    public static readonly Gender Female = new("FEMALE");

    public static readonly Gender Unknown = new("UNKNOWN");

    public TResult Match<TResult>(Func<TResult> onMale,
        Func<TResult> onFemale,
        Func<TResult> onUnknown,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Male => onMale(),
            _ when this == Female => onFemale(),
            _ when this == Unknown => onUnknown(),
            _ => otherwise(Value)
        };

    public void Match(Action onMale, Action onFemale, Action onUnknown, Action<string> otherwise)
    {
        if (this == Male) onMale();
        else if (this == Female) onFemale();
        else if (this == Unknown) onUnknown();
        else otherwise(Value);
    }
}
