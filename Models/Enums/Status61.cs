using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The resulting status of the return.
/// <para>
/// Possible values: <b>Authorised</b>, <b>Declined</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status61>))]
public sealed record Status61 : StringEnum<Status61>
{
    private Status61(string value) : base(value)
    {
    }

    public static readonly Status61 Authorised = new("Authorised");

    public static readonly Status61 Declined = new("Declined");

    public static Status61 FromValue(string value) => FromValueCore(value);
}
