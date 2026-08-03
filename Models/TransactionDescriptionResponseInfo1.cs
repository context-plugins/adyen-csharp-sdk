using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Information regarding the transaction description.
/// </summary>
public record TransactionDescriptionResponseInfo1
{
    /// <summary>
    /// The text to be shown on the shopper's bank statement.
    ///  We recommend sending a maximum of 22 characters, otherwise banks might truncate the string.
    ///  Allowed characters: <b>a-z</b>, <b>A-Z</b>, <b>0-9</b>, spaces, and special characters <b>. , ' _ - ? + * /</b>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("doingBusinessAsName")]
    [MaxLength(22)]
    public string? DoingBusinessAsName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type33? Type { get; init; }
}
