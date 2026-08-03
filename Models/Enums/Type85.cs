using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of events data.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>interchangeData</b>: information about the interchange fee applied to a transaction.</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type85>))]
public sealed record Type85 : StringEnum<Type85>
{
    private Type85(string value) : base(value)
    {
    }

    public static readonly Type85 InterchangeData = new("interchangeData");

    public static Type85 FromValue(string value) => FromValueCore(value);
}
