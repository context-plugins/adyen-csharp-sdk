using Adyen.Models;

namespace Adyen.Requests.General;

/// <summary>
/// The inputs of the PostScheduleAccountUpdater operation.
/// </summary>
public sealed record PostScheduleAccountUpdaterRequest
{
    public ScheduleAccountUpdaterRequest? Body { get; init; }
}
