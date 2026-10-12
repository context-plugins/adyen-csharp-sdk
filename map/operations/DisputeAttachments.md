<!-- Generated file — do not edit; regenerated with the SDK. -->

# DisputeAttachments — operations

Accessor: `client.DisputeAttachments` · Source: `src/Adyen/Api/DisputeAttachments.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteDisputesDisputeIdAttachmentsAttachmentId

- **Server group**: `Default23`
- **Signature**: `DeleteDisputesDisputeIdAttachmentsAttachmentId(DeleteDisputesDisputeIdAttachmentsAttachmentIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `DisputeId`, `AttachmentId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteDisputesDisputeIdAttachmentsAttachmentIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteDisputesDisputeIdAttachmentsAttachmentIdRequest` | `src/Adyen/Requests/DisputeAttachments/DeleteDisputesDisputeIdAttachmentsAttachmentIdRequest.cs` |
| `DeleteDisputesDisputeIdAttachmentsAttachmentIdError` | `src/Adyen/Errors/DeleteDisputesDisputeIdAttachmentsAttachmentIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### GetDisputesDisputeIdAttachments

- **Server group**: `Default23`
- **Signature**: `GetDisputesDisputeIdAttachments(GetDisputesDisputeIdAttachmentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `DisputeId`
- **Returns**: `IReadOnlyList<DisputeAttachment>`
- **Error**: `ApiException<GetDisputesDisputeIdAttachmentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDisputesDisputeIdAttachmentsRequest` | `src/Adyen/Requests/DisputeAttachments/GetDisputesDisputeIdAttachmentsRequest.cs` |
| `DisputeAttachment` | `src/Adyen/Models/DisputeAttachment.cs` |
| `GetDisputesDisputeIdAttachmentsError` | `src/Adyen/Errors/GetDisputesDisputeIdAttachmentsError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### GetDisputesDisputeIdAttachmentsAttachmentId

- **Server group**: `Default23`
- **Signature**: `GetDisputesDisputeIdAttachmentsAttachmentId(GetDisputesDisputeIdAttachmentsAttachmentIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `DisputeId`, `AttachmentId`
- **Returns**: `DisputeAttachment`
- **Error**: `ApiException<GetDisputesDisputeIdAttachmentsAttachmentIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDisputesDisputeIdAttachmentsAttachmentIdRequest` | `src/Adyen/Requests/DisputeAttachments/GetDisputesDisputeIdAttachmentsAttachmentIdRequest.cs` |
| `DisputeAttachment` | `src/Adyen/Models/DisputeAttachment.cs` |
| `GetDisputesDisputeIdAttachmentsAttachmentIdError` | `src/Adyen/Errors/GetDisputesDisputeIdAttachmentsAttachmentIdError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostDisputesDisputeIdAttachments

- **Server group**: `Default23`
- **Signature**: `PostDisputesDisputeIdAttachments(PostDisputesDisputeIdAttachmentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `DisputeId`, `Body`
- **Returns**: `AttachDocumentResponse`
- **Error**: `ApiException<PostDisputesDisputeIdAttachmentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostDisputesDisputeIdAttachmentsRequest` | `src/Adyen/Requests/DisputeAttachments/PostDisputesDisputeIdAttachmentsRequest.cs` |
| `DisputeAttachment` | `src/Adyen/Models/DisputeAttachment.cs` |
| `AttachDocumentResponse` | `src/Adyen/Models/AttachDocumentResponse.cs` |
| `PostDisputesDisputeIdAttachmentsError` | `src/Adyen/Errors/PostDisputesDisputeIdAttachmentsError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

