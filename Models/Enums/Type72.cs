using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The direction of sweep, whether pushing out or pulling in funds to the balance account. If not provided, by default, this is set to <b>push</b>.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>push</b>: _push out funds_ to a destination balance account or transfer instrument.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>pull</b>: _pull in funds_ from a source merchant account, transfer instrument, or balance account.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type72>))]
public sealed record Type72 : StringEnum<Type72>
{
    private Type72(string value) : base(value)
    {
    }

    public static readonly Type72 Pull = new("pull");

    public static readonly Type72 Push = new("push");

    public static Type72 FromValue(string value) => FromValueCore(value);
}
