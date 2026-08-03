using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record TransferServiceRestServiceError
{
    /// <summary>
    /// A human-readable explanation specific to this occurrence of the problem.
    /// </summary>
    [JsonPropertyName("detail")]
    public required string Detail { get; init; }

    /// <summary>
    /// A code that identifies the problem type.
    /// </summary>
    [JsonPropertyName("errorCode")]
    public required string ErrorCode { get; init; }

    /// <summary>
    /// A unique URI that identifies the specific occurrence of the problem.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("instance")]
    public string? Instance { get; init; }

    /// <summary>
    /// Detailed explanation of each validation error, when applicable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invalidFields")]
    public IReadOnlyList<InvalidField>? InvalidFields { get; init; }

    /// <summary>
    /// A unique reference for the request, essentially the same as <c>pspReference</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requestId")]
    public string? RequestId { get; init; }

    /// <summary>
    /// JSON response payload.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("response")]
    public object? Response { get; init; }

    /// <summary>
    /// Detailed explanation of each attempt to route the transfer with the priorities from the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("routingDetails")]
    public IReadOnlyList<RoutingDetails>? RoutingDetails { get; init; }

    /// <summary>
    /// The HTTP status code.
    /// </summary>
    [JsonPropertyName("status")]
    public required int Status { get; init; }

    /// <summary>
    /// A short, human-readable summary of the problem type.
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; init; }

    /// <summary>
    /// A URI that identifies the problem type, pointing to human-readable documentation on this problem type.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }
}
