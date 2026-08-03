using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record ProcessingTypesRestriction
{
    /// <summary>
    /// Defines how the condition must be evaluated.
    /// </summary>
    [JsonPropertyName("operation")]
    public required string Operation { get; init; }

    /// <summary>
    /// List of processing types.
    /// <para>
    /// Possible values: <b>atmWithdraw</b>, <b>balanceInquiry</b>, <b>ecommerce</b>, <b>moto</b>, <b>pos</b>, <b>recurring</b>, <b>token</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public IReadOnlyList<Value4>? Value { get; init; }
}
