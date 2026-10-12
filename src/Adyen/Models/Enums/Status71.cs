using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// The status of the PIN delivery.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status71>))]
public sealed record Status71 : OpenStringEnum<Status71>
{
    private Status71(string value) : base(value)
    {
    }

    public static readonly Status71 Created = new("created");

    public static readonly Status71 Delivered = new("delivered");

    public static readonly Status71 NotApplicable = new("notApplicable");

    public static readonly Status71 Processing = new("processing");

    public static readonly Status71 Produced = new("produced");

    public static readonly Status71 Rejected = new("rejected");

    public static readonly Status71 Shipped = new("shipped");

    public static readonly Status71 Unknown = new("unknown");

    public TResult Match<TResult>(Func<TResult> onCreated,
        Func<TResult> onDelivered,
        Func<TResult> onNotApplicable,
        Func<TResult> onProcessing,
        Func<TResult> onProduced,
        Func<TResult> onRejected,
        Func<TResult> onShipped,
        Func<TResult> onUnknown,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Created => onCreated(),
            _ when this == Delivered => onDelivered(),
            _ when this == NotApplicable => onNotApplicable(),
            _ when this == Processing => onProcessing(),
            _ when this == Produced => onProduced(),
            _ when this == Rejected => onRejected(),
            _ when this == Shipped => onShipped(),
            _ when this == Unknown => onUnknown(),
            _ => otherwise(Value)
        };

    public void Match(Action onCreated,
        Action onDelivered,
        Action onNotApplicable,
        Action onProcessing,
        Action onProduced,
        Action onRejected,
        Action onShipped,
        Action onUnknown,
        Action<string> otherwise)
    {
        if (this == Created) onCreated();
        else if (this == Delivered) onDelivered();
        else if (this == NotApplicable) onNotApplicable();
        else if (this == Processing) onProcessing();
        else if (this == Produced) onProduced();
        else if (this == Rejected) onRejected();
        else if (this == Shipped) onShipped();
        else if (this == Unknown) onUnknown();
        else otherwise(Value);
    }
}
