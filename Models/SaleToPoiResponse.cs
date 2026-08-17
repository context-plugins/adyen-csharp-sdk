using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The SaleToPOIResponse message pair is a container for the response message content. It contains a MessageHeader and a message body.
/// </summary>
public record SaleToPoiResponse
{
    /// <summary>
    /// Message header of the Sale to POI protocol message.
    /// It conveys Information related to the Sale to POI protocol management.
    /// </summary>
    [JsonPropertyName("MessageHeader")]
    public required MessageHeader MessageHeader { get; init; }

    /// <summary>
    /// Content of the Balance Inquiry Response message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("BalanceInquiryResponse")]
    public BalanceInquiryResponse2? BalanceInquiryResponse { get; init; }

    /// <summary>
    /// Content of the Card Acquisition Response message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardAcquisitionResponse")]
    public CardAcquisitionResponse2? CardAcquisitionResponse { get; init; }

    /// <summary>
    /// Content of the Admin Response message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AdminResponse")]
    public AdminResponse2? AdminResponse { get; init; }

    /// <summary>
    /// Content of the Diagnosis Response message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DiagnosisResponse")]
    public DiagnosisResponse2? DiagnosisResponse { get; init; }

    /// <summary>
    /// Content of the Display Response message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DisplayResponse")]
    public DisplayResponse2? DisplayResponse { get; init; }

    /// <summary>
    /// Content of the Enable Service Response message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("EnableServiceResponse")]
    public EnableServiceResponse2? EnableServiceResponse { get; init; }

    /// <summary>
    /// Content of the Get Totals Response message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("GetTotalsResponse")]
    public GetTotalsResponse2? GetTotalsResponse { get; init; }

    /// <summary>
    /// Content of the Input Response message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("InputResponse")]
    public InputResponse2? InputResponse { get; init; }

    /// <summary>
    /// Content of the Login Response message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoginResponse")]
    public LoginResponse2? LoginResponse { get; init; }

    /// <summary>
    /// Content of the Logout Response message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LogoutResponse")]
    public LogoutResponse2? LogoutResponse { get; init; }

    /// <summary>
    /// Content of the Loyalty Response message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyResponse")]
    public LoyaltyResponse2? LoyaltyResponse { get; init; }

    /// <summary>
    /// Content of the Payment Response message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentResponse")]
    public PaymentResponse21? PaymentResponse { get; init; }

    /// <summary>
    /// Content of the Print Response message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PrintResponse")]
    public PrintResponse2? PrintResponse { get; init; }

    /// <summary>
    /// Content of the Card Reader APDU Response message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardReaderAPDUResponse")]
    public CardReaderApduResponse2? CardReaderApduResponse { get; init; }

    /// <summary>
    /// Content of the Reconciliation Response message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ReconciliationResponse")]
    public ReconciliationResponse2? ReconciliationResponse { get; init; }

    /// <summary>
    /// Content of the Reversal Response message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ReversalResponse")]
    public ReversalResponse2? ReversalResponse { get; init; }

    /// <summary>
    /// Content of the Stored Value Response message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("StoredValueResponse")]
    public StoredValueResponse2? StoredValueResponse { get; init; }

    /// <summary>
    /// Content of the TransactionStatus Response message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TransactionStatusResponse")]
    public TransactionStatusResponse2? TransactionStatusResponse { get; init; }
}
