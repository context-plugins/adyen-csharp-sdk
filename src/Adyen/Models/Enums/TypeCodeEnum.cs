using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>Personal</b>
/// * <b>Company</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeCodeEnum>))]
public sealed record TypeCodeEnum : OpenStringEnum<TypeCodeEnum>
{
    private TypeCodeEnum(string value) : base(value)
    {
    }

    public static readonly TypeCodeEnum Personal = new("Personal");

    public static readonly TypeCodeEnum Company = new("Company");

    public TResult Match<TResult>(Func<TResult> onPersonal, Func<TResult> onCompany, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Personal => onPersonal(),
            _ when this == Company => onCompany(),
            _ => otherwise(Value)
        };

    public void Match(Action onPersonal, Action onCompany, Action<string> otherwise)
    {
        if (this == Personal) onPersonal();
        else if (this == Company) onCompany();
        else otherwise(Value);
    }
}
