using Adyen.Models;

namespace Adyen.Requests.Modifications;

/// <summary>
/// The inputs of the PostCapture operation.
/// </summary>
public sealed record PostCaptureRequest
{
    public CaptureRequest? Body { get; init; }
}
