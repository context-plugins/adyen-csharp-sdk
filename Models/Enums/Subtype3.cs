using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The external service from which to fetch the token. Supported only for specific companies. Contact Adyen if you want to use this feature.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Subtype3>))]
public sealed record Subtype3 : StringEnum<Subtype3>
{
    private Subtype3(string value) : base(value)
    {
    }

    public static readonly Subtype3 Hilton = new("hilton");

    public static Subtype3 FromValue(string value) => FromValueCore(value);
}
