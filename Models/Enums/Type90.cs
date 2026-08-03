using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of tracking event.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>internalReview</b>: the transfer was flagged because it does not comply with Adyen's risk policy.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type90>))]
public sealed record Type90 : StringEnum<Type90>
{
    private Type90(string value) : base(value)
    {
    }

    public static readonly Type90 InternalReview = new("internalReview");

    public static Type90 FromValue(string value) => FromValueCore(value);
}
