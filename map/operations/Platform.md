<!-- Generated file — do not edit; regenerated with the SDK. -->

# Platform — operations

Accessor: `client.Platform` · Source: `src/Adyen/Api/Platform.cs` · 3 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetBalancePlatformsId

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetBalancePlatformsId(GetBalancePlatformsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `BalancePlatform`
- **Error**: `ApiException<GetBalancePlatformsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBalancePlatformsIdRequest` | `src/Adyen/Requests/Platform/GetBalancePlatformsIdRequest.cs` |
| `BalancePlatform` | `src/Adyen/Models/BalancePlatform.cs` |
| `GetBalancePlatformsIdError` | `src/Adyen/Errors/GetBalancePlatformsIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetBalancePlatformsIdAccountHolders

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetBalancePlatformsIdAccountHolders(GetBalancePlatformsIdAccountHoldersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `offset` ← `Offset`, `limit` ← `Limit`
- **Returns**: `PaginatedAccountHoldersResponse`
- **Error**: `ApiException<GetBalancePlatformsIdAccountHoldersError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBalancePlatformsIdAccountHoldersRequest` | `src/Adyen/Requests/Platform/GetBalancePlatformsIdAccountHoldersRequest.cs` |
| `PaginatedAccountHoldersResponse` | `src/Adyen/Models/PaginatedAccountHoldersResponse.cs` |
| `GetBalancePlatformsIdAccountHoldersError` | `src/Adyen/Errors/GetBalancePlatformsIdAccountHoldersError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetBalancePlatformsIdTransactionRules

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetBalancePlatformsIdTransactionRules(GetBalancePlatformsIdTransactionRulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `TransactionRulesResponse`
- **Error**: `ApiException<GetBalancePlatformsIdTransactionRulesError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBalancePlatformsIdTransactionRulesRequest` | `src/Adyen/Requests/Platform/GetBalancePlatformsIdTransactionRulesRequest.cs` |
| `TransactionRulesResponse` | `src/Adyen/Models/TransactionRulesResponse.cs` |
| `GetBalancePlatformsIdTransactionRulesError` | `src/Adyen/Errors/GetBalancePlatformsIdTransactionRulesError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

