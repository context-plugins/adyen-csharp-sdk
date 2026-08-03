using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Value3>))]
public sealed record Value3 : StringEnum<Value3>
{
    private Value3(string value) : base(value)
    {
    }

    public static readonly Value3 AcquirerId = new("acquirerId");

    public static readonly Value3 Amount = new("amount");

    public static readonly Value3 Currency = new("currency");

    public static readonly Value3 MerchantId = new("merchantId");

    public static readonly Value3 MerchantName = new("merchantName");

    public static Value3 FromValue(string value) => FromValueCore(value);
}
