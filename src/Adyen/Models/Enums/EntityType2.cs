using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the entity the payout is processed for.
/// <para>
/// Allowed values:
/// * NaturalPerson
/// * Company
/// &gt; This field is required to update the existing <c>entityType</c> that is associated with this recurring contract.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EntityType2>))]
public sealed record EntityType2 : OpenStringEnum<EntityType2>
{
    private EntityType2(string value) : base(value)
    {
    }

    public static readonly EntityType2 NaturalPerson = new("NaturalPerson");

    public static readonly EntityType2 Company = new("Company");

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
