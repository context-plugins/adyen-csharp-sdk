using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>paybybank_AIS_DD</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type70>))]
public sealed record Type70 : StringEnum<Type70>
{
    private Type70(string value) : base(value)
    {
    }

    public static readonly Type70 PaybybankAisDd = new("paybybank_AIS_DD");

    public static Type70 FromValue(string value) => FromValueCore(value);
}
