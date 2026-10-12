<!-- Generated file — do not edit; regenerated with the SDK. -->

# Documents — operations

Accessor: `client.Documents` · Source: `src/Adyen/Api/Documents.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteDocumentsId

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DeleteDocumentsId(DeleteDocumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteDocumentsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteDocumentsIdRequest` | `src/Adyen/Requests/Documents/DeleteDocumentsIdRequest.cs` |
| `DeleteDocumentsIdError` | `src/Adyen/Errors/DeleteDocumentsIdError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### GetDocumentsId

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetDocumentsId(GetDocumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `skipContent` ← `SkipContent`
- **Returns**: `Document`
- **Error**: `ApiException<GetDocumentsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetDocumentsIdRequest` | `src/Adyen/Requests/Documents/GetDocumentsIdRequest.cs` |
| `Document` | `src/Adyen/Models/Document.cs` |
| `GetDocumentsIdError` | `src/Adyen/Errors/GetDocumentsIdError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PatchDocumentsId

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchDocumentsId(PatchDocumentsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `Document`
- **Error**: `ApiException<PatchDocumentsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchDocumentsIdRequest` | `src/Adyen/Requests/Documents/PatchDocumentsIdRequest.cs` |
| `Document` | `src/Adyen/Models/Document.cs` |
| `PatchDocumentsIdError` | `src/Adyen/Errors/PatchDocumentsIdError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostDocuments

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostDocuments(PostDocumentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `Document`
- **Error**: `ApiException<PostDocumentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostDocumentsRequest` | `src/Adyen/Requests/Documents/PostDocumentsRequest.cs` |
| `Document` | `src/Adyen/Models/Document.cs` |
| `PostDocumentsError` | `src/Adyen/Errors/PostDocumentsError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

