using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains various codes and details used to uniquely identify the bank account across different regions.
/// </summary>
public record AccountIdentifiers1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ach")]
    public AchaccountIdentifier? Ach { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bacs")]
    public BacsaccountIdentifier? Bacs { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bsb")]
    public BsbaccountIdentifier? Bsb { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("eft")]
    public EftaccountIdentifier? Eft { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("iban")]
    public IbanaccountIdentifier? Iban { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rix")]
    public RixaccountIdentifier? Rix { get; init; }
}
