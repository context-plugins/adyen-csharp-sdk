using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record CzLocalAccountIdentification
{
    /// <summary>
    /// The 2- to 16-digit bank account number (Číslo účtu) in the following format:
    /// <list type="bullet">
    ///   <item><description>The optional prefix (předčíslí).</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description>The required second part (základní část) which must be at least two non-zero digits.</description></item>
    /// </list>
    /// <para>
    /// Examples:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><b>19-123457</b> (with prefix)</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>123457</b> (without prefix)</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>000019-0000123457</b> (with prefix, normalized)</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><b>000000-0000123457</b> (without prefix, normalized)</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("accountNumber")]
    [StringLength(17, MinimumLength = 2)]
    public required string AccountNumber { get; init; }

    /// <summary>
    /// The 4-digit bank code (Kód banky), without separators or whitespace.
    /// </summary>
    [JsonPropertyName("bankCode")]
    [StringLength(4, MinimumLength = 4)]
    public required string BankCode { get; init; }

    /// <summary>
    /// <b>czLocal</b>
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "czLocal";
}
