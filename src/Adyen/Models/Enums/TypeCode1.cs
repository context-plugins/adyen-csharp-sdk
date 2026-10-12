using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of bank check.
/// Possible values:
/// * <b>Company</b>
/// * <b>Personal</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeCode1>))]
public sealed record TypeCode1 : OpenStringEnum<TypeCode1>
{
    private TypeCode1(string value) : base(value)
    {
    }

    public static readonly TypeCode1 Personal = new("Personal");

    public static readonly TypeCode1 Company = new("Company");

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
