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
public sealed record DocumentQualifier1 : StringEnum<DocumentQualifier1>
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

    public static DocumentQualifier1 FromValue(string value) => FromValueCore(value);
}
