using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TransferInstrumentReference
{
    /// <summary>
    /// The masked IBAN or bank account number.
    /// </summary>
    [JsonPropertyName("accountIdentifier")]
    public required string AccountIdentifier { get; init; }

    /// <summary>
    /// The unique identifier of the resource.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Four last digits of the bank account number. If the transfer instrument is created using <see href="https://docs.adyen.com/release-notes/platforms-and-financial-products#releaseNote=2023-05-08-hosted-onboarding">instant bank account verification</see>, and it is a virtual bank account, these digits may be different from the last four digits of the masked account number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("realLastFour")]
    public string? RealLastFour { get; init; }

    /// <summary>
    /// Identifies if the bank account was created through <see href="https://docs.adyen.com/release-notes/platforms-and-financial-products#releaseNote=2023-05-08-hosted-onboarding">instant bank verification</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trustedSource")]
    public bool? TrustedSource { get; init; }
}
