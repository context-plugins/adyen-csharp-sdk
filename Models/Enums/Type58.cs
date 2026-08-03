using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>zip</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type58>))]
public sealed record Type58 : StringEnum<Type58>
{
    private Type58(string value) : base(value)
    {
    }

    public static readonly Type58 Zip = new("zip");

    public static readonly Type58 ZipPos = new("zip_pos");

    public static Type58 FromValue(string value) => FromValueCore(value);
}
