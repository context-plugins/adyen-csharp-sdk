using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record BrandVariantsRestriction
{
    /// <summary>
    /// Defines how the condition must be evaluated.
    /// </summary>
    [JsonPropertyName("operation")]
    public required string Operation { get; init; }

    /// <summary>
    /// List of card brand variants.
    /// <para>
    /// Possible values:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>mc</b>, <b>mccredit</b>, <b>mccommercialcredit_b2b</b>, <b>mcdebit</b>, <b>mcbusinessdebit</b>, <b>mcbusinessworlddebit</b>, <b>mcprepaid</b>, <b>mcmaestro</b></description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>visa</b>, <b>visacredit</b>, <b>visadebit</b>, <b>visaprepaid</b>.</description></item>
    /// </list>
    /// <para>
    /// You can specify a rule for a generic variant. For example, to create a rule for all Mastercard payment instruments, use <b>mc</b>. The rule is applied to all payment instruments under <b>mc</b>, such as <b>mcbusinessdebit</b> and <b>mcdebit</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("value")]
    public IReadOnlyList<string>? Value { get; init; }
}
