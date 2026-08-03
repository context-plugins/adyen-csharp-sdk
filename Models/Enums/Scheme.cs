using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The Secure Remote Commerce scheme.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Scheme>))]
public sealed record Scheme : StringEnum<Scheme>
{
    private Scheme(string value) : base(value)
    {
    }

    public static readonly Scheme Mc = new("mc");

    public static readonly Scheme Visa = new("visa");

    public static Scheme FromValue(string value) => FromValueCore(value);
}
