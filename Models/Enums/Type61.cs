using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of terminal action: Update Release.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type61>))]
public sealed record Type61 : StringEnum<Type61>
{
    private Type61(string value) : base(value)
    {
    }

    public static readonly Type61 ReleaseUpdate = new("ReleaseUpdate");

    public static Type61 FromValue(string value) => FromValueCore(value);
}
