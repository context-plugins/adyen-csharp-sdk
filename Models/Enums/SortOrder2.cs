using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Determines the sort order of the returned transactions. The sort order is based on the creation date of the transaction.
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
[JsonConverter(typeof(StringEnumConverter<SortOrder2>))]
public sealed record SortOrder2 : StringEnum<SortOrder2>
{
    private SortOrder2(string value) : base(value)
    {
    }

    public static readonly SortOrder2 Asc = new("asc");

    public static readonly SortOrder2 Desc = new("desc");

    public static SortOrder2 FromValue(string value) => FromValueCore(value);
}
