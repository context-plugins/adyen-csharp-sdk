using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the entity the payout is processed for.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EntityType1>))]
public sealed record EntityType1 : StringEnum<EntityType1>
{
    private EntityType1(string value) : base(value)
    {
    }

    public static readonly EntityType1 NaturalPerson = new("NaturalPerson");

    public static readonly EntityType1 Company = new("Company");

    public static EntityType1 FromValue(string value) => FromValueCore(value);
}
