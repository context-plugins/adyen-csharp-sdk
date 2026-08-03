using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Specifies how payment methods should be filtered based on the <c>store</c> parameter:
///   - <b>exclusive</b>: Only payment methods belonging to the specified <c>store</c> are returned.
///   - <b>inclusive</b>: Payment methods from the <c>store</c> and those not associated with any other store are returned.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StoreFiltrationMode2>))]
public sealed record StoreFiltrationMode2 : StringEnum<StoreFiltrationMode2>
{
    private StoreFiltrationMode2(string value) : base(value)
    {
    }

    public static readonly StoreFiltrationMode2 Exclusive = new("exclusive");

    public static readonly StoreFiltrationMode2 Inclusive = new("inclusive");

    public static readonly StoreFiltrationMode2 SkipFilter = new("skipFilter");

    public static StoreFiltrationMode2 FromValue(string value) => FromValueCore(value);
}
