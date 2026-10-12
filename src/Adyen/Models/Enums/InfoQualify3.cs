using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Qualification of the information to sent to an output logical device, to display or print to the Cashier or the Customer.
/// Copy.
/// Possible values:
/// * <b>CustomerAssistance</b>
/// * <b>Display</b>
/// * <b>Document</b>
/// * <b>Error</b>
/// * <b>Input</b>
/// * <b>POIReplication</b>
/// * <b>Receipt</b>
/// * <b>Sound</b>
/// * <b>Status</b>
/// * <b>Voucher</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<InfoQualify3>))]
public sealed record InfoQualify3 : OpenStringEnum<InfoQualify3>
{
    private InfoQualify3(string value) : base(value)
    {
    }

    public static readonly InfoQualify3 Status = new("Status");

    public static readonly InfoQualify3 Error = new("Error");

    public static readonly InfoQualify3 Display = new("Display");

    public static readonly InfoQualify3 Sound = new("Sound");

    public static readonly InfoQualify3 Input = new("Input");

    public static readonly InfoQualify3 PoiReplication = new("POIReplication");

    public static readonly InfoQualify3 CustomerAssistance = new("CustomerAssistance");

    public static readonly InfoQualify3 Receipt = new("Receipt");

    public static readonly InfoQualify3 Document = new("Document");

    public static readonly InfoQualify3 Voucher = new("Voucher");

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
