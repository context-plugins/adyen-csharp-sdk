using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>additionalBankIdentificationRequirement</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type610>))]
public sealed record Type610 : StringEnum<Type610>
{
    private Type610(string value) : base(value)
    {
    }

    public static readonly Type610 AdditionalBankIdentificationRequirement = new("additionalBankIdentificationRequirement");

    public static Type610 FromValue(string value) => FromValueCore(value);
}
