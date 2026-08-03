using System.Text.Json.Serialization;

namespace Adyen.Models;

public record RepeatedResponseMessageBody
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyResponse")]
    public LoyaltyResponse1? LoyaltyResponse { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentResponse")]
    public PaymentResponse5? PaymentResponse { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ReversalResponse")]
    public ReversalResponse1? ReversalResponse { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("StoredValueResponse")]
    public StoredValueResponse1? StoredValueResponse { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardAcquisitionResponse")]
    public CardAcquisitionResponse1? CardAcquisitionResponse { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardReaderAPDUResponse")]
    public CardReaderApduresponse1? CardReaderApduresponse { get; init; }
}
