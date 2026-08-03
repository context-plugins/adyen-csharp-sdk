using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Details to provide if <c>type</c> is <b>discover</b>.
/// For merchants operating in Japan, request <see href="https://docs.adyen.com/api-explorer/Management/latest/post/merchants/(merchantId">Diners</see>/paymentMethodSettings/(paymentMethodId)#request-diners) payment method instead. Discover is automatically requested, together with Diners.
/// </summary>
public record GenericPmWithTdiInfo2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transactionDescription")]
    public TransactionDescriptionInfo? TransactionDescription { get; init; }
}
