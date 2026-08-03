using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostTransfersCancelError : ApiError
{
    private readonly Optional<TransferServiceRestServiceError> _transferServiceRestServiceErrorValue;

    private PostTransfersCancelError(Optional<TransferServiceRestServiceError> transferServiceRestServiceErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _transferServiceRestServiceErrorValue = transferServiceRestServiceErrorValue;
    }

    private static PostTransfersCancelError AsTransferServiceRestServiceError(TransferServiceRestServiceError value) =>
        new(Optional<TransferServiceRestServiceError>.Some(value), default);

    private static PostTransfersCancelError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetTransferServiceRestServiceError(out TransferServiceRestServiceError value) =>
        _transferServiceRestServiceErrorValue.TryGetValue(out value);

    internal static Task<PostTransfersCancelError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 422 or 500 => FromJson<TransferServiceRestServiceError>(response, ct).As(AsTransferServiceRestServiceError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostTransfersCancelErrorResponse : IErrorResponse<PostTransfersCancelError>
{
    public static PostTransfersCancelErrorResponse Instance { get; } = new();

    private PostTransfersCancelErrorResponse()
    {
    }

    public Task<PostTransfersCancelError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostTransfersCancelError.Create(response, ct);
}
