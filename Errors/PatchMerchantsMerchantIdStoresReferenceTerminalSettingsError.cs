using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PatchMerchantsMerchantIdStoresReferenceTerminalSettingsError : ApiError
{
    private readonly Optional<RestServiceError> _restServiceErrorValue;

    private PatchMerchantsMerchantIdStoresReferenceTerminalSettingsError(Optional<RestServiceError> restServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _restServiceErrorValue = restServiceErrorValue;
    }

    private static PatchMerchantsMerchantIdStoresReferenceTerminalSettingsError AsRestServiceError(RestServiceError value) =>
        new(Optional<RestServiceError>.Some(value), default);

    private static PatchMerchantsMerchantIdStoresReferenceTerminalSettingsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetRestServiceError(out RestServiceError value) =>
        _restServiceErrorValue.TryGetValue(out value);

    internal static Task<PatchMerchantsMerchantIdStoresReferenceTerminalSettingsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<RestServiceError>(response, ct).As(AsRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PatchMerchantsMerchantIdStoresReferenceTerminalSettingsErrorResponse : IErrorResponse<PatchMerchantsMerchantIdStoresReferenceTerminalSettingsError>
{
    public static PatchMerchantsMerchantIdStoresReferenceTerminalSettingsErrorResponse Instance { get; } = new();

    private PatchMerchantsMerchantIdStoresReferenceTerminalSettingsErrorResponse()
    {
    }

    public Task<PatchMerchantsMerchantIdStoresReferenceTerminalSettingsError> Map(HttpResponseMessage response,
        CancellationToken ct) =>
        PatchMerchantsMerchantIdStoresReferenceTerminalSettingsError.Create(response, ct);
}
