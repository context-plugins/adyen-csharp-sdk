using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The text shown on the payment terminal, either the name or the cause of the nonprofit organization.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DisplayTextField2>))]
public sealed record DisplayTextField2 : StringEnum<DisplayTextField2>
{
    private DisplayTextField2(string value) : base(value)
    {
    }

    public static readonly DisplayTextField2 CauseName = new("causeName");

    public static readonly DisplayTextField2 NonprofitName = new("nonprofitName");

    public static DisplayTextField2 FromValue(string value) => FromValueCore(value);
}
