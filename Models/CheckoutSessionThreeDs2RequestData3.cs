using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// The cardholder phone number need to be part of the authentication message for payment data. It is a requirement for Visa Secure Authentication Data Field Mandate effective August 2024.
/// </summary>
public record CheckoutSessionThreeDs2RequestData3
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("homePhone")]
    public HomePhone? HomePhone { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("mobilePhone")]
    public MobilePhone? MobilePhone { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("threeDSRequestorChallengeInd")]
    public ThreeDsrequestorChallengeInd? ThreeDsrequestorChallengeInd { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("workPhone")]
    public WorkPhone? WorkPhone { get; init; }
}
