using System.Text.Json.Serialization;

namespace Adyen.Models;

public record RepeatedResponseMessageBody
{
    /// <summary>
    /// It conveys Information related to the Loyalty transaction processed by the POI System.
    /// Content of the Loyalty Response message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyResponse")]
    public LoyaltyResponse? LoyaltyResponse { get; init; }

    /// <summary>
    /// It conveys Information related to the Payment transaction processed by the POI System.
    /// Content of the Payment Response message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentResponse")]
    public PaymentResponse4? PaymentResponse { get; init; }

    /// <summary>
    /// It conveys Information related to the reversal processed by the POI System.
    /// Content of the Reversal Response message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ReversalResponse")]
    public ReversalResponse? ReversalResponse { get; init; }

    /// <summary>
    /// It conveys Information related to the Stored Value transaction processed by the POI System.
    /// Content of the Stored Value Response message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("StoredValueResponse")]
    public StoredValueResponse? StoredValueResponse { get; init; }

    /// <summary>
    /// It conveys Information related to the payment and loyalty cards read and processed by the POI System and entered by the Customer.
    /// Content of the Card Acquisition Response message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardAcquisitionResponse")]
    public CardAcquisitionResponse? CardAcquisitionResponse { get; init; }

    /// <summary>
    /// Content of the Card Reader APDU Response message.
    /// It contains the result of the requested service, APDU response sent by the chip of the card in response to the APDU request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardReaderAPDUResponse")]
    public CardReaderApduResponse? CardReaderApduResponse { get; init; }
}
