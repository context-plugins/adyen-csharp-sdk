using System.Collections.Generic;
using System.Text.Json.Serialization;
using Adyen.Core.Models;
using Adyen.Core.Validation.Attributes;

namespace Adyen.Models;

/// <summary>
/// An object that contains a description of the allowed resources and roles for the requested session.
/// </summary>
public record Policy2
{
    /// <summary>
    /// An object containing the type and the unique identifier of the user of the component.
    /// <para>
    /// For <see href="https://docs.adyen.com/platforms/onboard-users/components">Onboarding components</see>, this is the ID of the legal entity that has a contractual relationship with your platform. For sole proprietorships, use the ID of the legal entity of the individual owner.
    /// </para>
    /// <para>
    /// For <see href="https://docs.adyen.com/platforms/build-user-dashboards">Platform Experience components</see>, this is the ID of the account holder that is associated with the balance account shown in the component.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("resources")]
    [UniqueItems]
    public IReadOnlyList<Resource>? Resources { get; init; }

    /// <summary>
    /// The name of the role required to use the component.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("roles")]
    [UniqueItems]
    public IReadOnlyList<string>? Roles { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
