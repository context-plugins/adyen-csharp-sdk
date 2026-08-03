using System.Text.Json.Serialization;
using Adyen.Core.Enum;

namespace Adyen.Models.Enums;

/// <summary>
/// Qualification of the document to print to the Cashier or the Customer. Allows the manager of the printer, Sale or POI Terminal, to send information to a physical printer or to use the paper type accordingly.
/// Possible values:
/// * <b>CashierReceipt</b>
/// * <b>CustomerReceipt</b>
/// * <b>Document</b>
/// * <b>Journal</b>
/// * <b>SaleReceipt</b>
/// * <b>Voucher</b>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DocumentQualifier2>))]
public sealed record DocumentQualifier2 : StringEnum<DocumentQualifier2>
{
    private DocumentQualifier2(string value) : base(value)
    {
    }

    public static readonly DocumentQualifier2 SaleReceipt = new("SaleReceipt");

    public static readonly DocumentQualifier2 CashierReceipt = new("CashierReceipt");

    public static readonly DocumentQualifier2 CustomerReceipt = new("CustomerReceipt");

    public static readonly DocumentQualifier2 Document = new("Document");

    public static readonly DocumentQualifier2 Voucher = new("Voucher");

    public static readonly DocumentQualifier2 Journal = new("Journal");

    public static DocumentQualifier2 FromValue(string value) => FromValueCore(value);
}
