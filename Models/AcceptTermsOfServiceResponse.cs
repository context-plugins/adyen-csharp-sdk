using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record AcceptTermsOfServiceResponse
{
    /// <summary>
    /// The unique identifier of the user that accepted the Terms of Service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("acceptedBy")]
    public string? AcceptedBy { get; init; }

    /// <summary>
    /// The unique identifier of the Terms of Service acceptance.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The IP address of the user that accepted the Terms of Service.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; init; }

    /// <summary>
    /// The language used for the Terms of Service document, specified by the two-letter <see href="https://en.wikipedia.org/wiki/List_of_ISO_639-1_codes">ISO 639-1</see> language code. Possible value: <b>en</b> for English or <b>fr</b> for French.
    /// <para>
    /// Note that French is only available for some integration types in certain countries/regions. Reach out to your Adyen contact for more information.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("language")]
    public string? Language { get; init; }

    /// <summary>
    /// The unique identifier of the Terms of Service document.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("termsOfServiceDocumentId")]
    public string? TermsOfServiceDocumentId { get; init; }

    /// <summary>
    /// The type of Terms of Service.
    /// <para>
    /// Possible values:
    /// *  <b>adyenForPlatformsManage</b>
    /// *  <b>adyenIssuing</b>
    /// *  <b>adyenForPlatformsAdvanced</b>
    /// *  <b>adyenCapital</b>
    /// *  <b>adyenAccount</b>
    /// *  <b>adyenCard</b>
    /// *  <b>adyenFranchisee</b>
    /// *  <b>adyenPccr</b>
    /// *  <b>adyenChargeCard</b>
    /// *  <b>kycOnInvite</b>
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type64? Type { get; init; }
}
