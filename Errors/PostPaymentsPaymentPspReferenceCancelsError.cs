using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class PostPaymentsPaymentPspReferenceCancelsError : ApiError
{
    private readonly Optional<ServiceError1> _serviceError1Value;

    private PostPaymentsPaymentPspReferenceCancelsError(Optional<ServiceError1> serviceError1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _serviceError1Value = serviceError1Value;
    }

    private static PostPaymentsPaymentPspReferenceCancelsError AsServiceError1(ServiceError1 value) =>
        new(Optional<ServiceError1>.Some(value), default);

    private static PostPaymentsPaymentPspReferenceCancelsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetServiceError1(out ServiceError1 value) => _serviceError1Value.TryGetValue(out value);

    internal static Task<PostPaymentsPaymentPspReferenceCancelsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 422 or 500 => FromJson<ServiceError1>(response, ct).As(AsServiceError1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostPaymentsPaymentPspReferenceCancelsErrorResponse : IErrorResponse<PostPaymentsPaymentPspReferenceCancelsError>
{
    public static PostPaymentsPaymentPspReferenceCancelsErrorResponse Instance { get; } = new();

    private PostPaymentsPaymentPspReferenceCancelsErrorResponse()
    {
    }

    public Task<PostPaymentsPaymentPspReferenceCancelsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostPaymentsPaymentPspReferenceCancelsError.Create(response, ct);
}
