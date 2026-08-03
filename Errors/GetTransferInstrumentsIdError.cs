using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetTransferInstrumentsIdError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private GetTransferInstrumentsIdError(Optional<ServiceError> serviceErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
    }

    private static GetTransferInstrumentsIdError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default);

    private static GetTransferInstrumentsIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    internal static Task<GetTransferInstrumentsIdError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetTransferInstrumentsIdErrorResponse : IErrorResponse<GetTransferInstrumentsIdError>
{
    public static GetTransferInstrumentsIdErrorResponse Instance { get; } = new();

    private GetTransferInstrumentsIdErrorResponse()
    {
    }

    public Task<GetTransferInstrumentsIdError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetTransferInstrumentsIdError.Create(response, ct);
}
