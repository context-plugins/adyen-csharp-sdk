using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PatchBusinessLinesIdError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private PatchBusinessLinesIdError(Optional<ServiceError> serviceErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static PatchBusinessLinesIdError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static PatchBusinessLinesIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    internal static Task<PatchBusinessLinesIdError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PatchBusinessLinesIdErrorResponse : IErrorResponse<PatchBusinessLinesIdError>
{
    public static PatchBusinessLinesIdErrorResponse Instance { get; } = new();

    private PatchBusinessLinesIdErrorResponse()
    {
    }

    public Task<PatchBusinessLinesIdError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PatchBusinessLinesIdError.Create(response, ct);
}
