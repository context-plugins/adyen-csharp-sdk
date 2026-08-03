using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>numberAndBic</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type244>))]
public sealed record Type244 : StringEnum<Type244>
{
    private Type244(string value) : base(value)
    {
    }

    public static readonly Type244 NumberAndBic = new("numberAndBic");

    public static Type244 FromValue(string value) => FromValueCore(value);
}
