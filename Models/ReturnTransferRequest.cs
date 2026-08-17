using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record ReturnTransferRequest
{
    /// <summary>
    /// Contains information about the amount to be returned.
    /// </summary>
    [JsonPropertyName("amount")]
    public required Amount17 Amount { get; init; }

    /// <summary>
    /// Your internal reference for the return. If you don't provide this in the request, Adyen generates a unique reference. This reference is used in all communication with you about the instruction status.
    /// <para>
    /// We recommend using a unique value per instruction.
    /// If you need to provide multiple references for a transaction, separate them with hyphens ("-").
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reference")]
    [MaxLength(80)]
    public string? Reference { get; init; }
}
