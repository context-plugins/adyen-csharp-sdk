using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record FundsCollection
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountIdentification")]
    public BankAccountIdentification1? AccountIdentification { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fundsCollectionType")]
    public FundsCollectionType2? FundsCollectionType { get; init; }
}
