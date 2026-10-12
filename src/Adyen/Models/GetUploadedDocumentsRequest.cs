using System.Text.Json.Serialization;

namespace Adyen.Models;

public record GetUploadedDocumentsRequest
{
    /// <summary>
    /// The code of the Account Holder for which to retrieve the documents.
    /// </summary>
    [JsonPropertyName("accountHolderCode")]
    public required string AccountHolderCode { get; init; }

    /// <summary>
    /// The code of the Bank Account for which to retrieve the documents.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bankAccountUUID")]
    public string? BankAccountUuid { get; init; }

    /// <summary>
    /// The code of the Shareholder for which to retrieve the documents.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shareholderCode")]
    public string? ShareholderCode { get; init; }
}
