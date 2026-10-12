using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TestCompanyWebhookRequest
{
    /// <summary>
    /// List of <c>merchantId</c> values for which test webhooks will be sent. The list can have a maximum of 20 <c>merchantId</c> values.
    /// <para>
    /// If not specified, we send sample notifications to all the merchant accounts that the webhook is configured for. If this is more than 20 merchant accounts, use this list to specify a subset of the merchant accounts for which to send test notifications.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantIds")]
    public IReadOnlyList<string>? MerchantIds { get; init; }

    /// <summary>
    /// Custom test notification object. Required when the <see href="https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/companies/{companyId}/webhooks/{webhookId}/test__reqParam_types"><c>types</c></see> list contains <b>CUSTOM</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("notification")]
    public CustomNotification1? Notification { get; init; }

    /// <summary>
    /// List of event codes for which to send test notifications. Only the webhook types below are supported.
    /// <para>
    /// Possible values if webhook <c>type</c>: <b>standard</b>:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>AUTHORISATION</b></description></item>
    ///   <item><description><b>CHARGEBACK_REVERSED</b></description></item>
    ///   <item><description><b>ORDER_CLOSED</b></description></item>
    ///   <item><description><b>ORDER_OPENED</b></description></item>
    ///   <item><description><b>PAIDOUT_REVERSED</b></description></item>
    ///   <item><description><b>PAYOUT_THIRDPARTY</b></description></item>
    ///   <item><description><b>REFUNDED_REVERSED</b></description></item>
    ///   <item><description><b>REFUND_WITH_DATA</b></description></item>
    ///   <item><description><b>REPORT_AVAILABLE</b></description></item>
    ///   <item><description><b>CUSTOM</b> - set your custom notification fields in the <see href="https://docs.adyen.com/api-explorer/#/ManagementService/v1/post/companies/{companyId}/webhooks/{webhookId}/test__reqParam_notification"><c>notification</c></see> object.</description></item>
    /// </list>
    /// <para>
    /// Possible values if webhook <c>type</c>: <b>banktransfer-notification</b>:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>PENDING</b></description></item>
    /// </list>
    /// <para>
    /// Possible values if webhook <c>type</c>: <b>report-notification</b>:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>REPORT_AVAILABLE</b></description></item>
    /// </list>
    /// <para>
    /// Possible values if webhook <c>type</c>: <b>ideal-notification</b>:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>AUTHORISATION</b></description></item>
    /// </list>
    /// <para>
    /// Possible values if webhook <c>type</c>: <b>pending-notification</b>:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>PENDING</b></description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("types")]
    public IReadOnlyList<string>? Types { get; init; }
}
