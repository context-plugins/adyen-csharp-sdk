using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostListRecurringDetails operation.
/// </summary>
public sealed record PostListRecurringDetailsRequest
{
    public RecurringDetailsRequest? Body { get; init; }
}
