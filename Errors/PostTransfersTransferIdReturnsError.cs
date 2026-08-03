using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostTransfersTransferIdReturnsError : ApiError
{
    private readonly Optional<TransferServiceRestServiceError> _transferServiceRestServiceErrorValue;

    private PostTransfersTransferIdReturnsError(Optional<TransferServiceRestServiceError> transferServiceRestServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _transferServiceRestServiceErrorValue = transferServiceRestServiceErrorValue;
    }

    private static PostTransfersTransferIdReturnsError AsTransferServiceRestServiceError(TransferServiceRestServiceError value) =>
        new(Optional<TransferServiceRestServiceError>.Some(value), default);

    private static PostTransfersTransferIdReturnsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetTransferServiceRestServiceError(out TransferServiceRestServiceError value) =>
        _transferServiceRestServiceErrorValue.TryGetValue(out value);

    internal static Task<PostTransfersTransferIdReturnsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 422 or 500 => FromJson<TransferServiceRestServiceError>(response, ct).As(AsTransferServiceRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostTransfersTransferIdReturnsErrorResponse : IErrorResponse<PostTransfersTransferIdReturnsError>
{
    public static PostTransfersTransferIdReturnsErrorResponse Instance { get; } = new();

    private PostTransfersTransferIdReturnsErrorResponse()
    {
    }

    public Task<PostTransfersTransferIdReturnsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostTransfersTransferIdReturnsError.Create(response, ct);
}
