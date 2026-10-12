using System.Text.Json.Serialization;
using Adyen.Models.Enums;

namespace Adyen.Models;

public record UpdateAccountHolderStateRequest
{
    /// <summary>
    /// The code of the Account Holder on which to update the state.
    /// </summary>
    [JsonPropertyName("accountHolderCode")]
    public required string AccountHolderCode { get; init; }

    /// <summary>
    /// If true, disable the requested state.  If false, enable the requested state.
    /// </summary>
    [JsonPropertyName("disable")]
    public required bool Disable { get; init; }

    /// <summary>
    /// The reason that the state is being updated.
    /// &gt;Required if the state is being disabled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public string? Reason { get; init; }

    /// <summary>
    /// The state to be updated.
    /// &gt;Permitted values are: <c>Processing</c>, <c>Payout</c>
    /// </summary>
    [JsonPropertyName("stateType")]
    public required StateType StateType { get; init; }
}
