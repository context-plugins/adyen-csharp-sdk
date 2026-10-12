using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<CustomerOrderReq>))]
public sealed record CustomerOrderReq : OpenStringEnum<CustomerOrderReq>
{
    private CustomerOrderReq(string value) : base(value)
    {
    }

    public static readonly CustomerOrderReq Open = new("Open");

    public static readonly CustomerOrderReq Closed = new("Closed");

    public static readonly CustomerOrderReq Both = new("Both");

    public TResult Match<TResult>(Func<TResult> onOpen,
        Func<TResult> onClosed,
        Func<TResult> onBoth,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Open => onOpen(),
            _ when this == Closed => onClosed(),
            _ when this == Both => onBoth(),
            _ => otherwise(Value)
        };

    public void Match(Action onOpen, Action onClosed, Action onBoth, Action<string> otherwise)
    {
        if (this == Open) onOpen();
        else if (this == Closed) onClosed();
        else if (this == Both) onBoth();
        else otherwise(Value);
    }
}
