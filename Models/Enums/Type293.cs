using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>bankAccountIdentificationTypeRequirement</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type293>))]
public sealed record Type293 : StringEnum<Type293>
{
    private Type293(string value) : base(value)
    {
    }

    public static readonly Type293 BankAccountIdentificationTypeRequirement = new("bankAccountIdentificationTypeRequirement");

    public static Type293 FromValue(string value) => FromValueCore(value);
}
