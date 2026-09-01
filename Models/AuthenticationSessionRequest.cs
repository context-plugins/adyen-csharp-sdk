using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record AuthenticationSessionRequest
{
    /// <summary>
    /// The URL where the component will appear. In your live environment, you must protect the URL with an SSL certificate and ensure that it starts with <c>https://</c>.
    /// </summary>
    [JsonPropertyName("allowOrigin")]
    public required string AllowOrigin { get; init; }

    /// <summary>
    /// An object that contains a description of the allowed resources and roles for the requested session.
    /// </summary>
    [JsonPropertyName("policy")]
    public required Policy2 Policy { get; init; }

    /// <summary>
    /// The type of component.
    /// <para>
    /// For <see href="https://docs.adyen.com/platforms/onboard-users/components">Onboarding components</see>, set this to <b>onboarding</b>.
    /// </para>
    /// <para>
    /// For <see href="https://docs.adyen.com/platforms/build-user-dashboards">Platform Experience components</see>, set this to <b>platform</b>.
    /// </para>
    /// </summary>
    [JsonPropertyName("product")]
    public required ProductType2 Product { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
