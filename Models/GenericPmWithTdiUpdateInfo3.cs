using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>diners</b>.
/// For merchants operating in Japan, Diners payments are processed through the JCB network. This means that you must include <see href="https://docs.adyen.com/api-explorer/Management/latest/post/merchants/(merchantId">JCB-specific fields</see>/paymentMethodSettings/(paymentMethodId)#request-jcb) in this object.
/// </summary>
public record GenericPmWithTdiUpdateInfo3
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
