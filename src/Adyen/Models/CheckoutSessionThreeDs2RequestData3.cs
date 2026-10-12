using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The cardholder phone number need to be part of the authentication message for payment data. It is a requirement for Visa Secure Authentication Data Field Mandate effective August 2024.
/// </summary>
public record CheckoutSessionThreeDs2RequestData3
{
    /// <summary>
    /// The home phone number provided by the cardholder. The phone number must consist of a country code, followed by the number. If the value you provide does not follow the guidelines, we do not submit it for authentication.
    /// &gt; Required for Visa and JCB transactions that require 3D Secure 2 authentication, if you did not include the <c>shopperEmail</c>, and did not send the shopper's phone number in <c>telephoneNumber</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("homePhone")]
    public Phone3? HomePhone { get; init; }

    /// <summary>
    /// The mobile phone number provided by the cardholder. The phone number must consist of a country code, followed by the number. If the value you provide does not follow the guidelines, we do not submit it for authentication.
    /// &gt; Required for Visa and JCB transactions that require 3D Secure 2 authentication, if you did not include the <c>shopperEmail</c>, and did not send the shopper's phone number in <c>telephoneNumber</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mobilePhone")]
    public Phone1? MobilePhone { get; init; }

    /// <summary>
    /// Indicates whether a challenge is requested for this transaction. Possible values:
    /// * <b>01</b> — No preference
    /// * <b>02</b> — No challenge requested
    /// * <b>03</b> — Challenge requested (3DS Requestor preference)
    /// * <b>04</b> — Challenge requested (Mandate)
    /// * <b>05</b> — No challenge (transactional risk analysis is already performed)
    /// * <b>06</b> — Data Only
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSRequestorChallengeInd")]
    public ThreeDsRequestorChallengeInd? ThreeDsRequestorChallengeInd { get; init; }

    /// <summary>
    /// The work phone number provided by the cardholder. The phone number must consist of a country code, followed by the number. If the value you provide does not follow the guidelines, we do not submit it for authentication.
    /// &gt; Required for Visa and JCB transactions that require 3D Secure 2 authentication, if you did not include the <c>shopperEmail</c>, and did not send the shopper's phone number in <c>telephoneNumber</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("workPhone")]
    public Phone2? WorkPhone { get; init; }
}
