using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The SaleToPOIRequest message pair is a container for the request message content. It contains a MessageHeader and a message body.
/// </summary>
public record SaleToPoiRequest
{
    /// <summary>
    /// Message header of the Sale to POI protocol message.
    /// It conveys Information related to the Sale to POI protocol management.
    /// </summary>
    [JsonPropertyName("MessageHeader")]
    public required MessageHeader MessageHeader { get; init; }

    /// <summary>
    /// Content of the Abort Request message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AbortRequest")]
    public AbortRequest2? AbortRequest { get; init; }

    /// <summary>
    /// Content of the Balance Inquiry Request message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("BalanceInquiryRequest")]
    public BalanceInquiryRequest2? BalanceInquiryRequest { get; init; }

    /// <summary>
    /// Content of the Card Acquisition Request message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardAcquisitionRequest")]
    public CardAcquisitionRequest2? CardAcquisitionRequest { get; init; }

    /// <summary>
    /// Content of the Admin Request message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AdminRequest")]
    public AdminRequest2? AdminRequest { get; init; }

    /// <summary>
    /// Content of the Diagnosis Request message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DiagnosisRequest")]
    public DiagnosisRequest2? DiagnosisRequest { get; init; }

    /// <summary>
    /// Content of the Display Request message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DisplayRequest")]
    public DisplayRequest2? DisplayRequest { get; init; }

    /// <summary>
    /// Content of the Enable Service Request message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("EnableServiceRequest")]
    public EnableServiceRequest2? EnableServiceRequest { get; init; }

    /// <summary>
    /// Content of the EventNotification message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("EventNotification")]
    public EventNotification2? EventNotification { get; init; }

    /// <summary>
    /// Content of the Get Totals Request message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("GetTotalsRequest")]
    public GetTotalsRequest2? GetTotalsRequest { get; init; }

    /// <summary>
    /// Content of the Input Request message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("InputRequest")]
    public InputRequest2? InputRequest { get; init; }

    /// <summary>
    /// Content of the Input Update message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("InputUpdate")]
    public InputUpdate2? InputUpdate { get; init; }

    /// <summary>
    /// Content of the Login Request message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoginRequest")]
    public LoginRequest2? LoginRequest { get; init; }

    /// <summary>
    /// Content of the Logout Request message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LogoutRequest")]
    public LogoutRequest2? LogoutRequest { get; init; }

    /// <summary>
    /// Content of the Payment Request message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentRequest")]
    public PaymentRequest21? PaymentRequest { get; init; }

    /// <summary>
    /// Content of the Print Request message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PrintRequest")]
    public PrintRequest2? PrintRequest { get; init; }

    /// <summary>
    /// Content of the Card Reader APDU Request message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardReaderAPDURequest")]
    public CardReaderApduRequest2? CardReaderApduRequest { get; init; }

    /// <summary>
    /// Content of the Reconciliation Request message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ReconciliationRequest")]
    public ReconciliationRequest2? ReconciliationRequest { get; init; }

    /// <summary>
    /// Content of the Reversal Request message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ReversalRequest")]
    public ReversalRequest2? ReversalRequest { get; init; }

    /// <summary>
    /// Content of the Stored Value Request message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("StoredValueRequest")]
    public StoredValueRequest2? StoredValueRequest { get; init; }

    /// <summary>
    /// Content of the TransactionStatus Request message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TransactionStatusRequest")]
    public TransactionStatusRequest2? TransactionStatusRequest { get; init; }
}
