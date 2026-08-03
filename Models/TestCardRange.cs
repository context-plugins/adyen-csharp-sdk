using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record TestCardRange
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public AvsAddress? Address { get; init; }

    /// <summary>
    /// The name of the card holder, as it appears on the card, for the test card range.
    /// </summary>
    [JsonPropertyName("cardHolderName")]
    public required string CardHolderName { get; init; }

    /// <summary>
    /// The test card range security code.
    /// <para>
    /// Example: 123
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cvc")]
    public string? Cvc { get; init; }

    [JsonPropertyName("expiryMonth")]
    public required ExpiryMonth ExpiryMonth { get; init; }

    /// <summary>
    /// Expiry year for the test card range.
    /// <para>
    /// Example: 2020
    /// </para>
    /// </summary>
    [JsonPropertyName("expiryYear")]
    public required int ExpiryYear { get; init; }

    /// <summary>
    /// The last test card number in the test card range (inclusive):
    /// <para>
    /// * Min 6, max 19 digits
    /// * BIN compliant
    /// Example: 5432 1234 1234 4321
    /// </para>
    /// </summary>
    [JsonPropertyName("rangeEnd")]
    public required string RangeEnd { get; init; }

    /// <summary>
    /// The first test card number in the test card range (inclusive):
    /// <para>
    /// * Min 6, max 19 digits
    /// * BIN compliant
    /// Example: 5432 1234 1234 1234
    /// </para>
    /// </summary>
    [JsonPropertyName("rangeStart")]
    public required string RangeStart { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDDirectoryServerResponse")]
    public ThreeDdirectoryServerResponse? ThreeDdirectoryServerResponse { get; init; }

    /// <summary>
    /// The password used for 3D Secure authentication.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDPassword")]
    public string? ThreeDpassword { get; init; }

    /// <summary>
    /// The username used for 3D Secure authentication.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDUsername")]
    public string? ThreeDusername { get; init; }
}
