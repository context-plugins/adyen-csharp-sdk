using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the transfer event. Possible values: <b>accounting</b>, <b>tracking</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type73>))]
public sealed record Type73 : StringEnum<Type73>
{
    private Type73(string value) : base(value)
    {
    }

    public static readonly Type73 Accounting = new("accounting");

    public static readonly Type73 Tracing = new("tracing");

    public static readonly Type73 Tracking = new("tracking");

    public static Type73 FromValue(string value) => FromValueCore(value);
}
