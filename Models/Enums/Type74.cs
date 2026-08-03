using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the transfer event. Possible values: <b>accounting</b>, <b>tracking</b>.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type74>))]
public sealed record Type74 : StringEnum<Type74>
{
    private Type74(string value) : base(value)
    {
    }

    public static readonly Type74 Accounting = new("accounting");

    public static readonly Type74 Tracing = new("tracing");

    public static readonly Type74 Tracking = new("tracking");

    public static Type74 FromValue(string value) => FromValueCore(value);
}
