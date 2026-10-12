<!-- Generated file — do not edit; regenerated with the SDK. -->

# BusinessLinesApi — operations

Accessor: `client.BusinessLinesApi` · Source: `src/Adyen/Api/BusinessLinesApi.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteBusinessLinesId

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `DeleteBusinessLinesId(DeleteBusinessLinesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteBusinessLinesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteBusinessLinesIdRequest` | `src/Adyen/Requests/BusinessLinesApi/DeleteBusinessLinesIdRequest.cs` |
| `DeleteBusinessLinesIdError` | `src/Adyen/Errors/DeleteBusinessLinesIdError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### GetBusinessLinesId

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetBusinessLinesId(GetBusinessLinesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `BusinessLine`
- **Error**: `ApiException<GetBusinessLinesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBusinessLinesIdRequest` | `src/Adyen/Requests/BusinessLinesApi/GetBusinessLinesIdRequest.cs` |
| `BusinessLine` | `src/Adyen/Models/BusinessLine.cs` |
| `GetBusinessLinesIdError` | `src/Adyen/Errors/GetBusinessLinesIdError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PatchBusinessLinesId

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchBusinessLinesId(PatchBusinessLinesIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `BusinessLine`
- **Error**: `ApiException<PatchBusinessLinesIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchBusinessLinesIdRequest` | `src/Adyen/Requests/BusinessLinesApi/PatchBusinessLinesIdRequest.cs` |
| `BusinessLineInfoUpdate` | `src/Adyen/Models/BusinessLineInfoUpdate.cs` |
| `BusinessLine` | `src/Adyen/Models/BusinessLine.cs` |
| `PatchBusinessLinesIdError` | `src/Adyen/Errors/PatchBusinessLinesIdError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostBusinessLines

- **Server group**: `Default18`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostBusinessLines(PostBusinessLinesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `BusinessLine`
- **Error**: `ApiException<PostBusinessLinesError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostBusinessLinesRequest` | `src/Adyen/Requests/BusinessLinesApi/PostBusinessLinesRequest.cs` |
| `BusinessLineInfo` | `src/Adyen/Models/BusinessLineInfo.cs` |
| `BusinessLine` | `src/Adyen/Models/BusinessLine.cs` |
| `PostBusinessLinesError` | `src/Adyen/Errors/PostBusinessLinesError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

