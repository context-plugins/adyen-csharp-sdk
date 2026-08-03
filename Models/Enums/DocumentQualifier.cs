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
public sealed record DocumentQualifier : StringEnum<DocumentQualifier>
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

    public static DocumentQualifier FromValue(string value) => FromValueCore(value);
}
