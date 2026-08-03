using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>ibanAccountIdentificationRequirement</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type303>))]
public sealed record Type303 : StringEnum<Type303>
{
    private Type303(string value) : base(value)
    {
    }

    public static readonly Type303 IbanAccountIdentificationRequirement = new("ibanAccountIdentificationRequirement");

    public static Type303 FromValue(string value) => FromValueCore(value);
}
