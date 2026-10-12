using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostIssue operation.
/// </summary>
public sealed record PostIssueRequest
{
    public StoredValueIssueRequest? Body { get; init; }
}
