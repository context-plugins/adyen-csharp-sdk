using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AdditionalDataRetry
{
    /// <summary>
    /// The number of times the transaction (not order) has been retried between different payment service providers. For instance, the <c>chainAttemptNumber</c> set to 2 means that this transaction has been recently tried on another provider before being sent to Adyen.
    /// <para>
    /// &gt; If you submit <c>retry.chainAttemptNumber</c>, <c>retry.orderAttemptNumber</c>, and <c>retry.skipRetry</c> values, we also recommend you provide the <c>merchantOrderReference</c> to facilitate linking payment attempts together.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("retry.chainAttemptNumber")]
    public string? RetryChainAttemptNumber { get; init; }

    /// <summary>
    /// The index of the attempt to bill a particular order, which is identified by the <c>merchantOrderReference</c> field. For example, if a recurring transaction fails and is retried one day later, then the order number for these attempts would be 1 and 2, respectively.
    /// <para>
    /// &gt; If you submit <c>retry.chainAttemptNumber</c>, <c>retry.orderAttemptNumber</c>, and <c>retry.skipRetry</c> values, we also recommend you provide the <c>merchantOrderReference</c> to facilitate linking payment attempts together.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("retry.orderAttemptNumber")]
    public string? RetryOrderAttemptNumber { get; init; }

    /// <summary>
    /// The Boolean value indicating whether Adyen should skip or retry this transaction, if possible.
    /// <para>
    /// &gt; If you submit <c>retry.chainAttemptNumber</c>, <c>retry.orderAttemptNumber</c>, and <c>retry.skipRetry</c> values, we also recommend you provide the <c>merchantOrderReference</c> to facilitate linking payment attempts together.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("retry.skipRetry")]
    public string? RetrySkipRetry { get; init; }
}
