using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Adyen.Models;

/// <summary>
/// Contains authentication information required to associate the resource with the SCA device.
/// </summary>
public record AssociationDelegatedAuthenticationData1
{
    /// <summary>
    /// A base64-encoded block with the data required to authenticate the request. You obtain this information by using our authentication SDK.
    /// </summary>
    [JsonPropertyName("sdkOutput")]
    [MaxLength(20000)]
    public required string SdkOutput { get; init; }
}
