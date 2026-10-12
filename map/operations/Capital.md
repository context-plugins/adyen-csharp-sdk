<!-- Generated file — do not edit; regenerated with the SDK. -->

# Capital — operations

Accessor: `client.Capital` · Source: `src/Adyen/Api/Capital.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetGrants

- **Server group**: `Default14`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetGrants(GetGrantsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `counterpartyAccountHolderId` ← `CounterpartyAccountHolderId`
- **Returns**: `CapitalGrants`
- **Error**: `ApiException<GetGrantsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetGrantsRequest` | `src/Adyen/Requests/Capital/GetGrantsRequest.cs` |
| `CapitalGrants` | `src/Adyen/Models/CapitalGrants.cs` |
| `GetGrantsError` | `src/Adyen/Errors/GetGrantsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetGrantsId

- **Server group**: `Default14`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetGrantsId(GetGrantsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `CapitalGrant`
- **Error**: `ApiException<GetGrantsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetGrantsIdRequest` | `src/Adyen/Requests/Capital/GetGrantsIdRequest.cs` |
| `CapitalGrant` | `src/Adyen/Models/CapitalGrant.cs` |
| `GetGrantsIdError` | `src/Adyen/Errors/GetGrantsIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostGrants

- **Server group**: `Default14`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostGrants(PostGrantsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CapitalGrant`
- **Error**: `ApiException<PostGrantsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostGrantsRequest` | `src/Adyen/Requests/Capital/PostGrantsRequest.cs` |
| `CapitalGrantInfo` | `src/Adyen/Models/CapitalGrantInfo.cs` |
| `CapitalGrant` | `src/Adyen/Models/CapitalGrant.cs` |
| `PostGrantsError` | `src/Adyen/Errors/PostGrantsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

