using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CardholderReceipt
{
    /// <summary>
    /// The structure of the header to show on the shopper receipt. You can define the order of one or two header lines and blank lines. For example, <b>header1,header2,filler</b>. The text of the header lines is defined in the Customer Area under <b>In-person payments</b> &gt; <b>Terminal settings</b> &gt; <b>Receipts</b> in the <b>Receipt lines</b> block.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("headerForAuthorizedReceipt")]
    public string? HeaderForAuthorizedReceipt { get; init; }
}
