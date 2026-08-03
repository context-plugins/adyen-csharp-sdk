using Microsoft.Extensions.Logging;

namespace Adyen.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }
}
