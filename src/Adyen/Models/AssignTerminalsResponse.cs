using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Adyen.Models;

public record AssignTerminalsResponse
{
    /// <summary>
    /// Array that returns a list of the terminals, and for each terminal the result of assigning it to an account or store.
    /// <para>
    /// The results can be:
    /// </para>
    /// <list type="bullet">
    ///   <item><description><c>Done</c>: The terminal has been assigned.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>AssignmentScheduled</c>: The terminal will be assigned asynschronously.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>RemoveConfigScheduled</c>: The terminal was previously assigned and boarded. Wait for the terminal to synchronize with the Adyen platform. For more information, refer to <see href="https://docs.adyen.com/point-of-sale/managing-terminals/assign-terminals#reassign-boarded-terminals">Reassigning boarded terminals</see>.</description></item>
    /// </list>
    /// <list type="bullet">
    ///   <item><description><c>Error</c>: There was an error when assigning the terminal.</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("results")]
    public required IReadOnlyDictionary<string, string> Results { get; init; }
}
