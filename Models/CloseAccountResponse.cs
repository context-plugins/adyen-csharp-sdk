using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CloseAccountResponse
{
    /// <summary>
    /// The account code of the account that is closed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountCode")]
    public string? AccountCode { get; init; }

    /// <summary>
    /// Contains field validation errors that would prevent requests from being processed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("invalidFields")]
    public IReadOnlyList<ErrorFieldType>? InvalidFields { get; init; }

    /// <summary>
    /// The reference of a request. Can be used to uniquely identify the request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pspReference")]
    public string? PspReference { get; init; }

    /// <summary>
    /// The result code.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resultCode")]
    public string? ResultCode { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status2? Status { get; init; }
}
