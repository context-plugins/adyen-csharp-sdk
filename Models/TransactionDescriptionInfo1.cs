using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Information regarding the transaction description.
/// &gt; You cannot configure the transaction description in the test environment.
/// </summary>
public record TransactionDescriptionInfo1
{
    /// <summary>
    /// The text to be shown on the shopper's bank statement.
    ///  We recommend sending a maximum of 22 characters, otherwise banks might truncate the string.
    ///  Allowed characters: <b>a-z</b>, <b>A-Z</b>, <b>0-9</b>, spaces, and special characters <b>. , ' _ - ? + * /</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("doingBusinessAsName")]
    [MaxLength(22)]
    public string? DoingBusinessAsName { get; init; }

    /// <summary>
    /// The type of transaction description you want to use:
    /// - <b>fixed</b>: The transaction description set in this request is used for all payments with this payment method.
    /// - <b>append</b>: The transaction description set in this request is used as a base for all payments with this payment method. The <see href="https://docs.adyen.com/api-explorer/Checkout/70/post/sessions#request-shopperStatement">transaction description set in the request to process the payment</see> is appended to this base description. Note that if the combined length exceeds 22 characters, banks may truncate the string.
    /// - <b>dynamic</b>: Only the <see href="https://docs.adyen.com/api-explorer/Checkout/70/post/sessions#request-shopperStatement">transaction description set in the request to process the payment</see> is used for payments with this payment method.
    /// </summary>
    [JsonPropertyName("type")]
    public Type8? Type { get; init; } = Type8.Dynamic;
}
