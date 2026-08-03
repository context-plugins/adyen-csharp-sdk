using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>delegatedAuthentication</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type543>))]
public sealed record Type543 : StringEnum<Type543>
{
    private Type543(string value) : base(value)
    {
    }

    public static readonly Type543 DelegatedAuthentication = new("delegatedAuthentication");

    public static Type543 FromValue(string value) => FromValueCore(value);
}
