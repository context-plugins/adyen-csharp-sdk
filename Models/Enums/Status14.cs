using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the transaction rule. If you provide a <c>startDate</c> in the request, the rule is automatically created
/// with an <b>active</b> status.
/// <para>
/// Possible values: <b>active</b>, <b>inactive</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status14>))]
public sealed record Status14 : StringEnum<Status14>
{
    private Status14(string value) : base(value)
    {
    }

    public static readonly Status14 Active = new("active");

    public static readonly Status14 Inactive = new("inactive");

    public static Status14 FromValue(string value) => FromValueCore(value);
}
