using Adyen.Core.Authentication.Basic;
using Adyen.Core.Configuration;
using Adyen.Servers;

namespace Adyen;

public class AdyenClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public ServerOptions Server { get; set; } = new();
    public string? ApiKeyAuth { get; set; }
    public BasicAuthCredentials? BasicAuth { get; set; }
    public string? ClientKey { get; set; }
}
