using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<ContentType3>))]
public sealed record ContentType3 : StringEnum<ContentType3>
{
    private ContentType3(string value) : base(value)
    {
    }

    public static readonly ContentType3 ApplicationJson = new("application/json");

    public static ContentType3 FromValue(string value) => FromValueCore(value);
}
