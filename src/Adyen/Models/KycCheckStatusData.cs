using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record KycCheckStatusData
{
    /// <summary>
    /// A list of the fields required for execution of the check.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requiredFields")]
    public IReadOnlyList<string>? RequiredFields { get; init; }

    /// <summary>
    /// The status of the check.
    /// <para>
    /// Possible values: <b>AWAITING_DATA</b> , <b>DATA_PROVIDED</b>, <b>FAILED</b>, <b>INVALID_DATA</b>, <b>PASSED</b>, <b>PENDING</b>, <b>RETRY_LIMIT_REACHED</b>.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required Status32 Status { get; init; }

    /// <summary>
    /// A summary of the execution of the check.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("summary")]
    public KycCheckSummary2? Summary { get; init; }

    /// <summary>
    /// The type of check.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>BANK_ACCOUNT_VERIFICATION</b>: Used in v5 and earlier. Replaced by <b>PAYOUT_METHOD_VERIFICATION</b> in v6 and later.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>COMPANY_VERIFICATION</b></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>CARD_VERIFICATION</b></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>IDENTITY_VERIFICATION</b></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>LEGAL_ARRANGEMENT_VERIFICATION</b></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>NONPROFIT_VERIFICATION</b></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>PASSPORT_VERIFICATION</b></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>PAYOUT_METHOD_VERIFICATION</b>: Used in v6 and later.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>PCI_VERIFICATION</b></description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type211 Type { get; init; }
}
