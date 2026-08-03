using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Determines the sort order of the returned transfers. The sort order is based on the creation date of the transfers.
/// <para>
/// Possible values:
/// </para>
/// <list type="bullet">
///   <item><description><b>asc</b>: Ascending order, from oldest to most recent.</description></item>
/// </list>
/// <list type="bullet">
///   <item><description><b>desc</b>: Descending order, from most recent to oldest.</description></item>
/// </list>
/// <para>
/// Default value: <b>asc</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<SortOrder1>))]
public sealed record SortOrder1 : StringEnum<SortOrder1>
{
    private SortOrder1(string value) : base(value)
    {
    }

    public static readonly SortOrder1 Asc = new("asc");

    public static readonly SortOrder1 Desc = new("desc");

    public static SortOrder1 FromValue(string value) => FromValueCore(value);
}
