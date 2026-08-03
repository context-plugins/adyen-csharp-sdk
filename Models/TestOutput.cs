using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TestOutput
{
    /// <summary>
    /// Unique identifier of the merchant account that the notification is about.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantId")]
    public string? MerchantId { get; init; }

    /// <summary>
    /// A short, human-readable explanation of the test result.
    /// <para>
    /// Your server must respond with <b>HTTP 2xx* for the test webhook to be successful (<c>data.status</c>: </b>success**). Find out more about <see href="https://docs.adyen.com/development-resources/webhooks/#accept-webhooks">accepting notifications</see>
    /// </para>
    /// <para>
    /// You can use the value of this field together with the <see href="https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/merchants/{merchantId}/webhooks/{id}/test__resParam_data-responseCode"><c>responseCode</c></see> value to troubleshoot unsuccessful test webhooks.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("output")]
    public string? Output { get; init; }

    /// <summary>
    /// The <see href="https://docs.adyen.com/development-resources/webhooks/understand-notifications#notification-structure">body of the notification webhook</see> that was sent to your server.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestSent")]
    public string? RequestSent { get; init; }

    /// <summary>
    /// The HTTP response code for your server's response to the test webhook.
    /// <para>
    /// You can use the value of this field together with the the <see href="https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/merchants/{merchantId}/webhooks/{id}/test__resParam_data-output"><c>output</c></see> field value to troubleshoot failed test webhooks.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("responseCode")]
    public string? ResponseCode { get; init; }

    /// <summary>
    /// The time between sending the test webhook and receiving the response from your server. You can use it as an indication of how long your server takes to process a webhook notification. Measured in milliseconds, for example <b>304 ms</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("responseTime")]
    public string? ResponseTime { get; init; }

    /// <summary>
    /// The status of the test request. Possible values are:
    /// * <b>success</b>, <c>data.responseCode</c>: <b>2xx</b>.
    /// * <b>failed</b>, in all other cases.
    /// <para>
    /// You can use the value of the <see href="https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/merchants/{merchantId}/webhooks/{id}/test__resParam_data-output"><c>output</c></see> field together with the <see href="https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/merchants/{merchantId}/webhooks/{id}/test__resParam_data-responseCode"><c>responseCode</c></see> value to troubleshoot failed test webhooks.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }
}
