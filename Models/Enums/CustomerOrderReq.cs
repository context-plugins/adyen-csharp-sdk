using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<CustomerOrderReq>))]
public sealed record CustomerOrderReq : StringEnum<CustomerOrderReq>
{
    private CustomerOrderReq(string value) : base(value)
    {
    }

    public static readonly CustomerOrderReq Open = new("Open");

    public static readonly CustomerOrderReq Closed = new("Closed");

    public static readonly CustomerOrderReq Both = new("Both");

    public static CustomerOrderReq FromValue(string value) => FromValueCore(value);
}
