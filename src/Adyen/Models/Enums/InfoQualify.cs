using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>Status</b>
/// * <b>Error</b>
/// * <b>Display</b>
/// * <b>Sound</b>
/// * <b>Input</b>
/// * <b>POIReplication</b>
/// * <b>CustomerAssistance</b>
/// * <b>Receipt</b>
/// * <b>Document</b>
/// * <b>Voucher</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InfoQualify>))]
public sealed record InfoQualify : OpenStringEnum<InfoQualify>
{
    private InfoQualify(string value) : base(value)
    {
    }

    public static readonly InfoQualify Status = new("Status");

    public static readonly InfoQualify Error = new("Error");

    public static readonly InfoQualify Display = new("Display");

    public static readonly InfoQualify Sound = new("Sound");

    public static readonly InfoQualify Input = new("Input");

    public static readonly InfoQualify PoiReplication = new("POIReplication");

    public static readonly InfoQualify CustomerAssistance = new("CustomerAssistance");

    public static readonly InfoQualify Receipt = new("Receipt");

    public static readonly InfoQualify Document = new("Document");

    public static readonly InfoQualify Voucher = new("Voucher");

    public TResult Match<TResult>(Func<TResult> onStatus,
        Func<TResult> onError,
        Func<TResult> onDisplay,
        Func<TResult> onSound,
        Func<TResult> onInput,
        Func<TResult> onPoiReplication,
        Func<TResult> onCustomerAssistance,
        Func<TResult> onReceipt,
        Func<TResult> onDocument,
        Func<TResult> onVoucher,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Status => onStatus(),
            _ when this == Error => onError(),
            _ when this == Display => onDisplay(),
            _ when this == Sound => onSound(),
            _ when this == Input => onInput(),
            _ when this == PoiReplication => onPoiReplication(),
            _ when this == CustomerAssistance => onCustomerAssistance(),
            _ when this == Receipt => onReceipt(),
            _ when this == Document => onDocument(),
            _ when this == Voucher => onVoucher(),
            _ => otherwise(Value)
        };

    public void Match(Action onStatus,
        Action onError,
        Action onDisplay,
        Action onSound,
        Action onInput,
        Action onPoiReplication,
        Action onCustomerAssistance,
        Action onReceipt,
        Action onDocument,
        Action onVoucher,
        Action<string> otherwise)
    {
        if (this == Status) onStatus();
        else if (this == Error) onError();
        else if (this == Display) onDisplay();
        else if (this == Sound) onSound();
        else if (this == Input) onInput();
        else if (this == PoiReplication) onPoiReplication();
        else if (this == CustomerAssistance) onCustomerAssistance();
        else if (this == Receipt) onReceipt();
        else if (this == Document) onDocument();
        else if (this == Voucher) onVoucher();
        else otherwise(Value);
    }
}
