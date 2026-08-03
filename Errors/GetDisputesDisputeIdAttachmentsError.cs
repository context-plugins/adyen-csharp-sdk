using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class GetDisputesDisputeIdAttachmentsError : ApiError
{
    private readonly Optional<DisputesAttachments401Error1> _disputesAttachments401Error1Value;

    private readonly Optional<DisputesAttachments403Error1> _disputesAttachments403Error1Value;

    private readonly Optional<DisputesAttachments422Error1> _disputesAttachments422Error1Value;

    private GetDisputesDisputeIdAttachmentsError(Optional<DisputesAttachments401Error1> disputesAttachments401Error1Value,
        Optional<DisputesAttachments403Error1> disputesAttachments403Error1Value,
        Optional<DisputesAttachments422Error1> disputesAttachments422Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _disputesAttachments401Error1Value = disputesAttachments401Error1Value;
        _disputesAttachments403Error1Value = disputesAttachments403Error1Value;
        _disputesAttachments422Error1Value = disputesAttachments422Error1Value;
    }

    private static GetDisputesDisputeIdAttachmentsError AsDisputesAttachments401Error1(DisputesAttachments401Error1 value) =>
        new(Optional<DisputesAttachments401Error1>.Some(value), default, default, default);

    private static GetDisputesDisputeIdAttachmentsError AsDisputesAttachments403Error1(DisputesAttachments403Error1 value) =>
        new(default, Optional<DisputesAttachments403Error1>.Some(value), default, default);

    private static GetDisputesDisputeIdAttachmentsError AsDisputesAttachments422Error1(DisputesAttachments422Error1 value) =>
        new(default, default, Optional<DisputesAttachments422Error1>.Some(value), default);

    private static GetDisputesDisputeIdAttachmentsError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetDisputesAttachments401Error1(out DisputesAttachments401Error1 value) =>
        _disputesAttachments401Error1Value.TryGetValue(out value);

    public bool TryGetDisputesAttachments403Error1(out DisputesAttachments403Error1 value) =>
        _disputesAttachments403Error1Value.TryGetValue(out value);

    public bool TryGetDisputesAttachments422Error1(out DisputesAttachments422Error1 value) =>
        _disputesAttachments422Error1Value.TryGetValue(out value);

    internal static Task<GetDisputesDisputeIdAttachmentsError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<DisputesAttachments401Error1>(response, ct).As(AsDisputesAttachments401Error1),
            403 => FromJson<DisputesAttachments403Error1>(response, ct).As(AsDisputesAttachments403Error1),
            422 => FromJson<DisputesAttachments422Error1>(response, ct).As(AsDisputesAttachments422Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetDisputesDisputeIdAttachmentsErrorResponse : IErrorResponse<GetDisputesDisputeIdAttachmentsError>
{
    public static GetDisputesDisputeIdAttachmentsErrorResponse Instance { get; } = new();

    private GetDisputesDisputeIdAttachmentsErrorResponse()
    {
    }

    public Task<GetDisputesDisputeIdAttachmentsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetDisputesDisputeIdAttachmentsError.Create(response, ct);
}
