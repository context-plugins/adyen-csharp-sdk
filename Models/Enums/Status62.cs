using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The resulting status of the return.
/// <para>
/// Possible values: <b>Authorised</b>, <b>Declined</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status62>))]
public sealed record Status62 : StringEnum<Status62>
{
    private Status62(string value) : base(value)
    {
    }

    public static readonly Status62 Authorised = new("Authorised");

    public static readonly Status62 Declined = new("Declined");

    public static Status62 FromValue(string value) => FromValueCore(value);
}
