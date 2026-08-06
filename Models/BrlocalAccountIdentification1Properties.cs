using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record BrlocalAccountIdentification1Properties
{
    /// <summary>
    /// The bank account number, without separators or whitespace.
    /// </summary>
    [JsonPropertyName("accountNumber")]
    [StringLength(10, MinimumLength = 1)]
    public required string AccountNumber { get; init; }

    /// <summary>
    /// The 3-digit bank code, with leading zeros.
    /// </summary>
    [JsonPropertyName("bankCode")]
    [StringLength(3, MinimumLength = 3)]
    public required string BankCode { get; init; }

    /// <summary>
    /// The bank account branch number, without separators or whitespace.
    /// </summary>
    [JsonPropertyName("branchNumber")]
    [StringLength(4, MinimumLength = 1)]
    public required string BranchNumber { get; init; }

    /// <summary>
    /// The 8-digit ISPB, with leading zeros.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ispb")]
    [StringLength(8, MinimumLength = 8)]
    public string? Ispb { get; init; }

    /// <summary>
    /// <b>brLocal</b>
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }
}
