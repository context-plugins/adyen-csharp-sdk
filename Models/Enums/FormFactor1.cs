using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The form factor of the card.
/// Possible values: <b>virtual</b>, <b>physical</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FormFactor1>))]
public sealed record FormFactor1 : StringEnum<FormFactor1>
{
    private FormFactor1(string value) : base(value)
    {
    }

    public static readonly FormFactor1 Physical = new("physical");

    public static readonly FormFactor1 Unknown = new("unknown");

    public static readonly FormFactor1 Virtual = new("virtual");

    public static FormFactor1 FromValue(string value) => FromValueCore(value);
}
