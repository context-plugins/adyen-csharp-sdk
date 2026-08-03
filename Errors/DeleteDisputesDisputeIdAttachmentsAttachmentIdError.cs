using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Adyen.Core.ErrorResponse;
using Adyen.Core.Models;
using Adyen.Models;

namespace Adyen.Errors;

public sealed class DeleteDisputesDisputeIdAttachmentsAttachmentIdError : ApiError
{
    private readonly Optional<DisputesAttachments401Error1> _disputesAttachments401Error1Value;

    private readonly Optional<DisputesAttachments403Error1> _disputesAttachments403Error1Value;

    private readonly Optional<DisputesAttachments422Error1> _disputesAttachments422Error1Value;

    private DeleteDisputesDisputeIdAttachmentsAttachmentIdError(Optional<DisputesAttachments401Error1> disputesAttachments401Error1Value,
        Optional<DisputesAttachments403Error1> disputesAttachments403Error1Value,
        Optional<DisputesAttachments422Error1> disputesAttachments422Error1Value,
        Optional<RawError> fallback) : base(fallback)
    {
        _disputesAttachments401Error1Value = disputesAttachments401Error1Value;
        _disputesAttachments403Error1Value = disputesAttachments403Error1Value;
        _disputesAttachments422Error1Value = disputesAttachments422Error1Value;
    }

    private static DeleteDisputesDisputeIdAttachmentsAttachmentIdError AsDisputesAttachments401Error1(DisputesAttachments401Error1 value) =>
        new(Optional<DisputesAttachments401Error1>.Some(value), default, default, default);

    private static DeleteDisputesDisputeIdAttachmentsAttachmentIdError AsDisputesAttachments403Error1(DisputesAttachments403Error1 value) =>
        new(default, Optional<DisputesAttachments403Error1>.Some(value), default, default);

    private static DeleteDisputesDisputeIdAttachmentsAttachmentIdError AsDisputesAttachments422Error1(DisputesAttachments422Error1 value) =>
        new(default, default, Optional<DisputesAttachments422Error1>.Some(value), default);

    private static DeleteDisputesDisputeIdAttachmentsAttachmentIdError AsFallback(RawError value) =>
        new(default, default, default, Optional<RawError>.Some(value));

    public bool TryGetDisputesAttachments401Error1(out DisputesAttachments401Error1 value) =>
        _disputesAttachments401Error1Value.TryGetValue(out value);

    public bool TryGetDisputesAttachments403Error1(out DisputesAttachments403Error1 value) =>
        _disputesAttachments403Error1Value.TryGetValue(out value);

    public bool TryGetDisputesAttachments422Error1(out DisputesAttachments422Error1 value) =>
        _disputesAttachments422Error1Value.TryGetValue(out value);

    internal static Task<DeleteDisputesDisputeIdAttachmentsAttachmentIdError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<DisputesAttachments401Error1>(response, ct).As(AsDisputesAttachments401Error1),
            403 => FromJson<DisputesAttachments403Error1>(response, ct).As(AsDisputesAttachments403Error1),
            422 => FromJson<DisputesAttachments422Error1>(response, ct).As(AsDisputesAttachments422Error1),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteDisputesDisputeIdAttachmentsAttachmentIdErrorResponse : IErrorResponse<DeleteDisputesDisputeIdAttachmentsAttachmentIdError>
{
    public static DeleteDisputesDisputeIdAttachmentsAttachmentIdErrorResponse Instance { get; } = new();

    private DeleteDisputesDisputeIdAttachmentsAttachmentIdErrorResponse()
    {
    }

    public Task<DeleteDisputesDisputeIdAttachmentsAttachmentIdError> Map(HttpResponseMessage response,
        CancellationToken ct) => DeleteDisputesDisputeIdAttachmentsAttachmentIdError.Create(response, ct);
}
