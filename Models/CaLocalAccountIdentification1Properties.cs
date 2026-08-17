using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record CaLocalAccountIdentification1Properties
{
    /// <summary>
    /// The 5- to 12-digit bank account number, without separators or whitespace.
    /// </summary>
    [JsonPropertyName("accountNumber")]
    [StringLength(12, MinimumLength = 5)]
    public required string AccountNumber { get; init; }

    /// <summary>
    /// The bank account type.
    /// <para>
    /// Possible values: <b>checking</b> or <b>savings</b>. Defaults to <b>checking</b>.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accountType")]
    public AccountType2? AccountType { get; init; }

    /// <summary>
    /// The 3-digit institution number, without separators or whitespace.
    /// </summary>
    [JsonPropertyName("institutionNumber")]
    [StringLength(3, MinimumLength = 3)]
    public required string InstitutionNumber { get; init; }

    /// <summary>
    /// The 5-digit transit number, without separators or whitespace.
    /// </summary>
    [JsonPropertyName("transitNumber")]
    [StringLength(5, MinimumLength = 5)]
    public required string TransitNumber { get; init; }

    /// <summary>
    /// <b>caLocal</b>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; init; } = "caLocal";
}
