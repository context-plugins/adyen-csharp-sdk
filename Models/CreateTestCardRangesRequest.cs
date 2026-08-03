using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CreateTestCardRangesRequest
{
    /// <summary>
    /// The code of the account, for which the test card ranges should be created.
    /// </summary>
    [JsonPropertyName("accountCode")]
    public required string AccountCode { get; init; }

    /// <summary>
    /// The type of the account, for which the test card ranges should be created.
    /// <para>
    /// Permitted values:
    /// * Company
    /// * MerchantAccount
    /// &gt; These values are case-sensitive.
    /// </para>
    /// </summary>
    [JsonPropertyName("accountTypeCode")]
    public required string AccountTypeCode { get; init; }

    /// <summary>
    /// A list of test card ranges to create.
    /// </summary>
    [JsonPropertyName("testCardRanges")]
    public required IReadOnlyList<TestCardRange> TestCardRanges { get; init; }
}
