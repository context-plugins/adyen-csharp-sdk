using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Specifies how payment methods should be filtered based on the 'store' parameter:
///   - 'exclusive': Only payment methods belonging to the specified 'store' are returned.
///   - 'inclusive': Payment methods from the 'store' and those not associated with any other store are returned.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StoreFiltrationMode>))]
public sealed record StoreFiltrationMode : StringEnum<StoreFiltrationMode>
{
    private StoreFiltrationMode(string value) : base(value)
    {
    }

    public static readonly StoreFiltrationMode Exclusive = new("exclusive");

    public static readonly StoreFiltrationMode Inclusive = new("inclusive");

    public static readonly StoreFiltrationMode SkipFilter = new("skipFilter");

    public static StoreFiltrationMode FromValue(string value) => FromValueCore(value);
}
