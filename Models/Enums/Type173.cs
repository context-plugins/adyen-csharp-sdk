using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>dkLocal</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type173>))]
public sealed record Type173 : StringEnum<Type173>
{
    private Type173(string value) : base(value)
    {
    }

    public static readonly Type173 DkLocal = new("dkLocal");

    public static Type173 FromValue(string value) => FromValueCore(value);
}
