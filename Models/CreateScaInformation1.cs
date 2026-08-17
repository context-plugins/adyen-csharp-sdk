using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

/// <summary>
/// Information for the Strong Customer Authentication (SCA)
/// </summary>
public record CreateScaInformation1
{
    /// <summary>
    /// The type of exemption for Strong Customer Authentication (SCA). Possible values:
    /// * <b>lowerLimit</b>: the newly created limit is lower than the existing limit.
    /// * <b>notRegulated</b>: the limit is created in a country, region, or industry where it is not mandated by law to use SCA.
    /// * <b>setByPlatform</b>: you set a limit for one of your user's balance accounts, or for your balance platform.
    /// * <b>initialLimit</b>: there are no existing transfer limits set on the balance account or balance platform.
    /// * <b>alreadyPerformed</b>: you are confident about your user's identity and do not need to verify this using SCA.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("exemption")]
    public ScaExemption? Exemption { get; init; }

    /// <summary>
    /// Indicates whether to initiate Strong Customer Authentication (SCA) later, during approval, or immediately after you submit this request. Possible values:
    /// * <b>true</b>: you can initiate SCA later, during approval, for all pending transfer limits.
    /// * <b>false</b> (default): you initiate SCA immediately after submitting the transfer limit request.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scaOnApproval")]
    public bool? ScaOnApproval { get; init; }
}
