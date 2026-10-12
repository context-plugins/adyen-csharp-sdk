using System;
using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Qualification of the document to print to the Cashier or the Customer.
/// SaleReceipt or CashierReceipt.
/// Possible values:
/// * <b>CashierReceipt</b>
/// * <b>CustomerReceipt</b>
/// * <b>Document</b>
/// * <b>Journal</b>
/// * <b>SaleReceipt</b>
/// * <b>Voucher</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DocumentQualifier1>))]
public sealed record DocumentQualifier1 : OpenStringEnum<DocumentQualifier1>
{
    private DocumentQualifier1(string value) : base(value)
    {
    }

    public static readonly DocumentQualifier1 SaleReceipt = new("SaleReceipt");

    public static readonly DocumentQualifier1 CashierReceipt = new("CashierReceipt");

    public static readonly DocumentQualifier1 CustomerReceipt = new("CustomerReceipt");

    public static readonly DocumentQualifier1 Document = new("Document");

    public static readonly DocumentQualifier1 Voucher = new("Voucher");

    public static readonly DocumentQualifier1 Journal = new("Journal");

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
