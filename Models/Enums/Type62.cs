using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Type of terminal action: Update Release.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type62>))]
public sealed record Type62 : StringEnum<Type62>
{
    private Type62(string value) : base(value)
    {
    }

    public static readonly Type62 ReleaseUpdate = new("ReleaseUpdate");

    public static Type62 FromValue(string value) => FromValueCore(value);
}
