using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostTransfersError : ApiError
{
    private readonly Optional<ServiceError> _serviceErrorValue;

    private readonly Optional<TransferServiceRestServiceError> _transferServiceRestServiceErrorValue;

    private PostTransfersError(Optional<ServiceError> serviceErrorValue,
        Optional<TransferServiceRestServiceError> transferServiceRestServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _serviceErrorValue = serviceErrorValue;
        _transferServiceRestServiceErrorValue = transferServiceRestServiceErrorValue;
    }

    private static PostTransfersError AsServiceError(ServiceError value) =>
        new(Optional<ServiceError>.Some(value), default, default);

    private static PostTransfersError AsTransferServiceRestServiceError(TransferServiceRestServiceError value) =>
        new(default, Optional<TransferServiceRestServiceError>.Some(value), default);

    private static PostTransfersError AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetServiceError(out ServiceError value) => _serviceErrorValue.TryGetValue(out value);

    public bool TryGetTransferServiceRestServiceError(out TransferServiceRestServiceError value) =>
        _transferServiceRestServiceErrorValue.TryGetValue(out value);

    internal static Task<PostTransfersError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<ServiceError>(response, ct).As(AsServiceError),
            403 or 422 or 500 => FromJson<TransferServiceRestServiceError>(response, ct).As(AsTransferServiceRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostTransfersErrorResponse : IErrorResponse<PostTransfersError>
{
    public static PostTransfersErrorResponse Instance { get; } = new();

    private PostTransfersErrorResponse()
    {
    }

    public Task<PostTransfersError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostTransfersError.Create(response, ct);
}
