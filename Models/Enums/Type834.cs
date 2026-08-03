using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the tracking event.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>confirmation</b>: the transfer passed Adyen's internal review.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type834>))]
public sealed record Type834 : StringEnum<Type834>
{
    private Type834(string value) : base(value)
    {
    }

    public static readonly Type834 Confirmation = new("confirmation");

    public static Type834 FromValue(string value) => FromValueCore(value);
}
