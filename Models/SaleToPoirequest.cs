using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// The SaleToPOIRequest message pair is a container for the request message content. It contains a MessageHeader and a message body.
/// </summary>
public record SaleToPoirequest
{
    [JsonPropertyName("MessageHeader")]
    public required MessageHeader1 MessageHeader { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AbortRequest")]
    public AbortRequest3? AbortRequest { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("BalanceInquiryRequest")]
    public BalanceInquiryRequest3? BalanceInquiryRequest { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardAcquisitionRequest")]
    public CardAcquisitionRequest3? CardAcquisitionRequest { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AdminRequest")]
    public AdminRequest3? AdminRequest { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DiagnosisRequest")]
    public DiagnosisRequest3? DiagnosisRequest { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DisplayRequest")]
    public DisplayRequest3? DisplayRequest { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("EnableServiceRequest")]
    public EnableServiceRequest3? EnableServiceRequest { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("EventNotification")]
    public EventNotification3? EventNotification { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("GetTotalsRequest")]
    public GetTotalsRequest3? GetTotalsRequest { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("InputRequest")]
    public InputRequest3? InputRequest { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("InputUpdate")]
    public InputUpdate3? InputUpdate { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoginRequest")]
    public LoginRequest3? LoginRequest { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LogoutRequest")]
    public LogoutRequest3? LogoutRequest { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentRequest")]
    public PaymentRequest22? PaymentRequest { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PrintRequest")]
    public PrintRequest3? PrintRequest { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardReaderAPDURequest")]
    public CardReaderApdurequest3? CardReaderApdurequest { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ReconciliationRequest")]
    public ReconciliationRequest3? ReconciliationRequest { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ReversalRequest")]
    public ReversalRequest3? ReversalRequest { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("StoredValueRequest")]
    public StoredValueRequest3? StoredValueRequest { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TransactionStatusRequest")]
    public TransactionStatusRequest3? TransactionStatusRequest { get; init; }
}
