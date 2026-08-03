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
public sealed record EntityType2 : StringEnum<EntityType2>
{
    private EntityType2(string value) : base(value)
    {
    }

    public static readonly EntityType2 NaturalPerson = new("NaturalPerson");

    public static readonly EntityType2 Company = new("Company");

    public static EntityType2 FromValue(string value) => FromValueCore(value);
}
