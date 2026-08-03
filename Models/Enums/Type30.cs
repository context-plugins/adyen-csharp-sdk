using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>eft</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type30>))]
public sealed record Type30 : StringEnum<Type30>
{
    private Type30(string value) : base(value)
    {
    }

    public static readonly Type30 EftDirectdebitCa = new("eft_directdebit_CA");

    public static Type30 FromValue(string value) => FromValueCore(value);
}
