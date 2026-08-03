using System.Text.Json.Serialization;

namespace Adyen.Models;

public record SaleToPoiresponse2
{
    [JsonPropertyName("MessageHeader")]
    public required MessageHeader1 MessageHeader { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("BalanceInquiryResponse")]
    public BalanceInquiryResponse3? BalanceInquiryResponse { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardAcquisitionResponse")]
    public CardAcquisitionResponse1? CardAcquisitionResponse { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("AdminResponse")]
    public AdminResponse3? AdminResponse { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DiagnosisResponse")]
    public DiagnosisResponse3? DiagnosisResponse { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("DisplayResponse")]
    public DisplayResponse3? DisplayResponse { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("EnableServiceResponse")]
    public EnableServiceResponse3? EnableServiceResponse { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("GetTotalsResponse")]
    public GetTotalsResponse3? GetTotalsResponse { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("InputResponse")]
    public InputResponse3? InputResponse { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoginResponse")]
    public LoginResponse3? LoginResponse { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LogoutResponse")]
    public LogoutResponse3? LogoutResponse { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("LoyaltyResponse")]
    public LoyaltyResponse1? LoyaltyResponse { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PaymentResponse")]
    public PaymentResponse5? PaymentResponse { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("PrintResponse")]
    public PrintResponse3? PrintResponse { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("CardReaderAPDUResponse")]
    public CardReaderApduresponse1? CardReaderApduresponse { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ReconciliationResponse")]
    public ReconciliationResponse3? ReconciliationResponse { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ReversalResponse")]
    public ReversalResponse1? ReversalResponse { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("StoredValueResponse")]
    public StoredValueResponse1? StoredValueResponse { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("TransactionStatusResponse")]
    public TransactionStatusResponse3? TransactionStatusResponse { get; init; }
}
