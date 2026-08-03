using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>fastlane</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type68>))]
public sealed record Type68 : StringEnum<Type68>
{
    private Type68(string value) : base(value)
    {
    }

    public static readonly Type68 Fastlane = new("fastlane");

    public static Type68 FromValue(string value) => FromValueCore(value);
}
