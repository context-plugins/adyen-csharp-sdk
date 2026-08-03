using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetThemesIdError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private GetThemesIdError(Optional<ServiceError> serviceErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static GetThemesIdError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static GetThemesIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    internal static Task<GetThemesIdError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetThemesIdErrorResponse : IErrorResponse<GetThemesIdError>
{
    public static GetThemesIdErrorResponse Instance { get; } = new();

    private GetThemesIdErrorResponse()
    {
    }

    public Task<GetThemesIdError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetThemesIdError.Create(response, ct);
}
