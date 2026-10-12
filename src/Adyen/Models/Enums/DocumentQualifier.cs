using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Possible values:
/// * <b>SaleReceipt</b>
/// * <b>CashierReceipt</b>
/// * <b>CustomerReceipt</b>
/// * <b>Document</b>
/// * <b>Voucher</b>
/// * <b>Journal</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DocumentQualifier>))]
public sealed record DocumentQualifier : OpenStringEnum<DocumentQualifier>
{
    private DocumentQualifier(string value) : base(value)
    {
    }

    public static readonly DocumentQualifier SaleReceipt = new("SaleReceipt");

    public static readonly DocumentQualifier CashierReceipt = new("CashierReceipt");

    public static readonly DocumentQualifier CustomerReceipt = new("CustomerReceipt");

    public static readonly DocumentQualifier Document = new("Document");

    public static readonly DocumentQualifier Voucher = new("Voucher");

    public static readonly DocumentQualifier Journal = new("Journal");

    public TResult Match<TResult>(Func<TResult> onSaleReceipt,
        Func<TResult> onCashierReceipt,
        Func<TResult> onCustomerReceipt,
        Func<TResult> onDocument,
        Func<TResult> onVoucher,
        Func<TResult> onJournal,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == SaleReceipt => onSaleReceipt(),
            _ when this == CashierReceipt => onCashierReceipt(),
            _ when this == CustomerReceipt => onCustomerReceipt(),
            _ when this == Document => onDocument(),
            _ when this == Voucher => onVoucher(),
            _ when this == Journal => onJournal(),
            _ => otherwise(Value)
        };

    public void Match(Action onSaleReceipt,
        Action onCashierReceipt,
        Action onCustomerReceipt,
        Action onDocument,
        Action onVoucher,
        Action onJournal,
        Action<string> otherwise)
    {
        if (this == SaleReceipt) onSaleReceipt();
        else if (this == CashierReceipt) onCashierReceipt();
        else if (this == CustomerReceipt) onCustomerReceipt();
        else if (this == Document) onDocument();
        else if (this == Voucher) onVoucher();
        else if (this == Journal) onJournal();
        else otherwise(Value);
    }
}
