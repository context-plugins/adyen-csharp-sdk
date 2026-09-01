using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record TestCardRange
{
    /// <summary>
    /// Contains the billing address of the card holder. The address details need to be AVS-compliant, which means that you need to provide at least street address.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("address")]
    public AvsAddress1? Address { get; init; }

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

    /// <summary>
    /// Expiry month for the test card range.
    /// <para>
    /// Allowed values:
    /// * JANUARY
    /// * FEBRUARY
    /// * MARCH
    /// * APRIL
    /// * MAY
    /// * JUNE
    /// * JULY
    /// * AUGUST
    /// * SEPTEMBER
    /// * OCTOBER
    /// * NOVEMBER
    /// * DECEMBER
    /// </para>
    /// </summary>
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

    /// <summary>
    /// 3D Secure server response. It notifies whether the specified card holder is enrolled in a 3D Secure service. Possible values:
    /// <list type="bullet">
    ///   <item><description>Y (Authentication available)</description></item>
    ///   <item><description>N (Card holder not enrolled/not participating)</description></item>
    ///   <item><description>U (Unable to authenticate)</description></item>
    /// </list>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDDirectoryServerResponse")]
    public ThreeDDirectoryServerResponse? ThreeDDirectoryServerResponse { get; init; }

    /// <summary>
    /// The password used for 3D Secure authentication.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDPassword")]
    public string? ThreeDPassword { get; init; }

    /// <summary>
    /// The username used for 3D Secure authentication.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDUsername")]
    public string? ThreeDUsername { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
