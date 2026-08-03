using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetTransfersError : ApiError
{
    private readonly Optional<TransferServiceRestServiceError> _transferServiceRestServiceErrorValue;

    private GetTransfersError(Optional<TransferServiceRestServiceError> transferServiceRestServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _transferServiceRestServiceErrorValue = transferServiceRestServiceErrorValue;
    }

    private static GetTransfersError AsTransferServiceRestServiceError(TransferServiceRestServiceError value) =>
        new(Optional<TransferServiceRestServiceError>.Some(value), default);

    private static GetTransfersError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetTransferServiceRestServiceError(out TransferServiceRestServiceError value) =>
        _transferServiceRestServiceErrorValue.TryGetValue(out value);

    internal static Task<GetTransfersError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 422 or 500 => FromJson<TransferServiceRestServiceError>(response, ct).As(AsTransferServiceRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetTransfersErrorResponse : IErrorResponse<GetTransfersError>
{
    public static GetTransfersErrorResponse Instance { get; } = new();

    private GetTransfersErrorResponse()
    {
    }

    public Task<GetTransfersError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetTransfersError.Create(response, ct);
}
