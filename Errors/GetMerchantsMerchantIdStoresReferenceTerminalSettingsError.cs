using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetMerchantsMerchantIdStoresReferenceTerminalSettingsError : ApiError
{
    private readonly Optional<RestServiceError> _restServiceErrorValue;

    private GetMerchantsMerchantIdStoresReferenceTerminalSettingsError(Optional<RestServiceError> restServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restServiceErrorValue = restServiceErrorValue;
    }

    private static GetMerchantsMerchantIdStoresReferenceTerminalSettingsError AsRestServiceError(RestServiceError value) =>
        new(Optional<RestServiceError>.Some(value), default);

    private static GetMerchantsMerchantIdStoresReferenceTerminalSettingsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestServiceError(out RestServiceError value) =>
        _restServiceErrorValue.TryGetValue(out value);

    internal static Task<GetMerchantsMerchantIdStoresReferenceTerminalSettingsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<RestServiceError>(response, ct).As(AsRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetMerchantsMerchantIdStoresReferenceTerminalSettingsErrorResponse : IErrorResponse<GetMerchantsMerchantIdStoresReferenceTerminalSettingsError>
{
    public static GetMerchantsMerchantIdStoresReferenceTerminalSettingsErrorResponse Instance { get; } = new();

    private GetMerchantsMerchantIdStoresReferenceTerminalSettingsErrorResponse()
    {
    }

    public Task<GetMerchantsMerchantIdStoresReferenceTerminalSettingsError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        GetMerchantsMerchantIdStoresReferenceTerminalSettingsError.Create(response, ct);
}
