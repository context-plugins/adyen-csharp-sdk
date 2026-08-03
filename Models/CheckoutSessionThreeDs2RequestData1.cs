using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Request fields for 3D Secure 2. To check if any of the following fields are required for your integration, refer to <see href="https://docs.adyen.com/online-payments">Online payments</see>.
/// </summary>
public record CheckoutSessionThreeDs2RequestData1
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
