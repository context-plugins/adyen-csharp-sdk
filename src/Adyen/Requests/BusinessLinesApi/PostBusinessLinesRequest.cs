using Adyen.Models;

namespace Adyen.Requests.BusinessLinesApi;

/// <summary>
/// The inputs of the PostBusinessLines operation.
/// </summary>
public sealed record PostBusinessLinesRequest
{
    public BusinessLineInfo? Body { get; init; }
}
