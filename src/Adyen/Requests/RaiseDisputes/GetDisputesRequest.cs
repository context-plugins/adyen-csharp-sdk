namespace Adyen.Requests.RaiseDisputes;

/// <summary>
/// The inputs of the GetDisputes operation.
/// </summary>
public sealed record GetDisputesRequest
{
    /// <summary>
    /// The current status of the dispute.
    /// <para>
    /// Possible values: <b>draft</b>, <b>submitted</b>, <b>closed</b>, <b>won</b>, <b>chargeback</b>, <b>secondPresentment</b>.
    /// </para>
    /// </summary>
    public string? Status { get; init; }

    /// <summary>
    /// The unique identifier of the payment instrument.
    /// </summary>
    public string? PaymentInstrument { get; init; }

    /// <summary>
    /// Only include disputes that have been created on or after this point in time. The value must be in <see href="https://en.wikipedia.org/wiki/ISO_8601\">ISO 8601</see>  format. For example, 2021-05-30T15:07:40Z.
    /// </summary>
    public string? CreatedSince { get; init; }

    /// <summary>
    /// Only include disputes that have been created on or before this point in time. The value must be in <see href="https://en.wikipedia.org/wiki/ISO_8601\">ISO 8601</see> format. For example, <b>2021-05-30T15:07:40Z</b>.
    /// </summary>
    public string? CreatedUntil { get; init; }

    /// <summary>
    /// The number of items that you want to skip.
    /// </summary>
    public string? Offset { get; init; }

    /// <summary>
    /// The number of items returned per page, maximum of 500 items. By default, the response returns 100 items per page.
    /// </summary>
    public string? Limit { get; init; }
}
