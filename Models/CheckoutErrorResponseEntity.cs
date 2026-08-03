using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CheckoutErrorResponseEntity
{
    [JsonPropertyName("errorCode")]
    public required string ErrorCode { get; init; }

    [JsonPropertyName("errorType")]
    public required string ErrorType { get; init; }

    [JsonPropertyName("message")]
    public required string Message { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pspReference")]
    public string? PspReference { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public int? Status { get; init; }
}
