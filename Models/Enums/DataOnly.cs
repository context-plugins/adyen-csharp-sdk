using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Required to trigger the <see href="https://docs.adyen.com/online-payments/3d-secure/data-only/">data-only flow</see>. When set to <b>true</b>, forces the 3D Secure 2 data-only flow for all transactions where it is possible.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DataOnly>))]
public sealed record DataOnly : StringEnum<DataOnly>
{
    private DataOnly(string value) : base(value)
    {
    }

    public static readonly DataOnly False = new("false");

    public static readonly DataOnly True = new("true");

    public static DataOnly FromValue(string value) => FromValueCore(value);
}
