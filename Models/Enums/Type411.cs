using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// <b>payto</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type411>))]
public sealed record Type411 : StringEnum<Type411>
{
    private Type411(string value) : base(value)
    {
    }

    public static readonly Type411 Payto = new("payto");

    public static Type411 FromValue(string value) => FromValueCore(value);
}
