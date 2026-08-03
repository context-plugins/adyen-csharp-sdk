using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SetupBeneficiaryRequest
{
    /// <summary>
    /// The destination account code.
    /// </summary>
    [JsonPropertyName("destinationAccountCode")]
    public required string DestinationAccountCode { get; init; }

    /// <summary>
    /// A value that can be supplied at the discretion of the executing user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("merchantReference")]
    public string? MerchantReference { get; init; }

    /// <summary>
    /// The benefactor account.
    /// </summary>
    [JsonPropertyName("sourceAccountCode")]
    public required string SourceAccountCode { get; init; }
}
