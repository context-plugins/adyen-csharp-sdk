using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<CancellingEntity>))]
public sealed record CancellingEntity : StringEnum<CancellingEntity>
{
    private CancellingEntity(string value) : base(value)
    {
    }

    public static readonly CancellingEntity Merchant = new("merchant");

    public static readonly CancellingEntity Cardholder = new("cardholder");

    public static CancellingEntity FromValue(string value) => FromValueCore(value);
}
