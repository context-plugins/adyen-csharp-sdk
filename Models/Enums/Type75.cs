using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>paybybank</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type75>))]
public sealed record Type75 : StringEnum<Type75>
{
    private Type75(string value) : base(value)
    {
    }

    public static readonly Type75 Paybybank = new("paybybank");

    public static Type75 FromValue(string value) => FromValueCore(value);
}
