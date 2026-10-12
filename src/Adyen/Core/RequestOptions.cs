using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Adyen.Core.Hooks;

namespace Adyen.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
