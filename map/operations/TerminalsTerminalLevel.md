<!-- Generated file — do not edit; regenerated with the SDK. -->

# TerminalsTerminalLevel — operations

Accessor: `client.TerminalsTerminalLevel` · Source: `src/Adyen/Api/TerminalsTerminalLevel.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetTerminals

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetTerminals(GetTerminalsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `searchQuery` ← `SearchQuery`, `otpQuery` ← `OtpQuery`, `countries` ← `Countries`, `merchantIds` ← `MerchantIds`, `storeIds` ← `StoreIds`, `brandModels` ← `BrandModels`, `pageNumber` ← `PageNumber`, `pageSize` ← `PageSize`
- **Returns**: `ListTerminalsResponse`
- **Error**: `ApiException<GetTerminalsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTerminalsRequest` | `src/Adyen/Requests/TerminalsTerminalLevel/GetTerminalsRequest.cs` |
| `ListTerminalsResponse` | `src/Adyen/Models/ListTerminalsResponse.cs` |
| `GetTerminalsError` | `src/Adyen/Errors/GetTerminalsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostTerminalsTerminalIdReassign

- **Server group**: `Default9`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostTerminalsTerminalIdReassign(PostTerminalsTerminalIdReassignRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `TerminalId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<PostTerminalsTerminalIdReassignError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostTerminalsTerminalIdReassignRequest` | `src/Adyen/Requests/TerminalsTerminalLevel/PostTerminalsTerminalIdReassignRequest.cs` |
| `TerminalReassignmentRequest` | `src/Adyen/Models/TerminalReassignmentRequest.cs` |
| `PostTerminalsTerminalIdReassignError` | `src/Adyen/Errors/PostTerminalsTerminalIdReassignError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

