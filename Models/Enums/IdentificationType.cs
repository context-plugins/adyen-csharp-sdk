using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The type of the identification.
/// <para>
/// Possible values: <b>iban</b>, <b>routingNumber</b>, <b>sortCode</b>, <b>bic</b>.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<IdentificationType>))]
public sealed record IdentificationType : StringEnum<IdentificationType>
{
    private IdentificationType(string value) : base(value)
    {
    }

    public static readonly IdentificationType Bic = new("bic");

    public static readonly IdentificationType Iban = new("iban");

    public static readonly IdentificationType RoutingNumber = new("routingNumber");

    public static readonly IdentificationType SortCode = new("sortCode");

    public static IdentificationType FromValue(string value) => FromValueCore(value);
}
