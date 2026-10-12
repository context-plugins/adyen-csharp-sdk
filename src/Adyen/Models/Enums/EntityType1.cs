using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the entity the payout is processed for.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EntityType1>))]
public sealed record EntityType1 : OpenStringEnum<EntityType1>
{
    private EntityType1(string value) : base(value)
    {
    }

    public static readonly EntityType1 NaturalPerson = new("NaturalPerson");

    public static readonly EntityType1 Company = new("Company");

    public TResult Match<TResult>(Func<TResult> onNaturalPerson,
        Func<TResult> onCompany,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NaturalPerson => onNaturalPerson(),
            _ when this == Company => onCompany(),
            _ => otherwise(Value)
        };

    public void Match(Action onNaturalPerson, Action onCompany, Action<string> otherwise)
    {
        if (this == NaturalPerson) onNaturalPerson();
        else if (this == Company) onCompany();
        else otherwise(Value);
    }
}
