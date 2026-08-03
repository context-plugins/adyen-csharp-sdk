using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of tracking event.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>estimation</b>: the estimated date and time of when the funds will be credited has been determined.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type84>))]
public sealed record Type84 : StringEnum<Type84>
{
    private Type84(string value) : base(value)
    {
    }

    public static readonly Type84 Estimation = new("estimation");

    public static Type84 FromValue(string value) => FromValueCore(value);
}
