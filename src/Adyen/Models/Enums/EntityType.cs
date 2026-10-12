using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the entity the payment is processed for.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EntityType>))]
public sealed record EntityType : OpenStringEnum<EntityType>
{
    private EntityType(string value) : base(value)
    {
    }

    public static readonly EntityType NaturalPerson = new("NaturalPerson");

    public static readonly EntityType CompanyName = new("CompanyName");

    public TResult Match<TResult>(Func<TResult> onNaturalPerson,
        Func<TResult> onCompanyName,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NaturalPerson => onNaturalPerson(),
            _ when this == CompanyName => onCompanyName(),
            _ => otherwise(Value)
        };

    public void Match(Action onNaturalPerson, Action onCompanyName, Action<string> otherwise)
    {
        if (this == NaturalPerson) onNaturalPerson();
        else if (this == CompanyName) onCompanyName();
        else otherwise(Value);
    }
}
