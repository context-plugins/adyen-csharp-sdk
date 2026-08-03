using Adyen.Core.Authentication;
using Adyen.Core.Authentication.ApiKey;
using Adyen.Core.Authentication.Basic;

namespace Adyen;

internal sealed class AuthSchemes
{
    public IAuthScheme BasicAuth { get; }
    public IAuthScheme ApiKeyAuth { get; }
    public IAuthScheme ClientKey { get; }

    public AuthSchemes(AdyenClientOptions options)
    {
        BasicAuth = BasicAuthScheme.Create(options.BasicAuth);
        ApiKeyAuth = ApiKeyHeaderScheme.Create("X-API-Key", options.ApiKeyAuth);
        ClientKey = ApiKeyQueryScheme.Create("clientKey", options.ClientKey);
    }
}
