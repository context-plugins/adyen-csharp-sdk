using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the entity the payment is processed for.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EntityType>))]
public sealed record EntityType : StringEnum<EntityType>
{
    private EntityType(string value) : base(value)
    {
    }

    public static readonly EntityType NaturalPerson = new("NaturalPerson");

    public static readonly EntityType CompanyName = new("CompanyName");

    public static EntityType FromValue(string value) => FromValueCore(value);
}
