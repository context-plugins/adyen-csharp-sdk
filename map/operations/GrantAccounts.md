<!-- Generated file — do not edit; regenerated with the SDK. -->

# GrantAccounts — operations

Accessor: `client.GrantAccounts` · Source: `src/Adyen/Api/GrantAccounts.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetGrantAccountsId

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetGrantAccountsId(GetGrantAccountsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `CapitalGrantAccount`
- **Error**: `ApiException<GetGrantAccountsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetGrantAccountsIdRequest` | `src/Adyen/Requests/GrantAccounts/GetGrantAccountsIdRequest.cs` |
| `CapitalGrantAccount` | `src/Adyen/Models/CapitalGrantAccount.cs` |
| `GetGrantAccountsIdError` | `src/Adyen/Errors/GetGrantAccountsIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetGrantAccountsId1

- **Server group**: `Default15`
- **Signature**: `GetGrantAccountsId1(GetGrantAccountsId1Request request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `GrantAccount`
- **Error**: `ApiException<GetGrantAccountsId1Error>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetGrantAccountsId1Request` | `src/Adyen/Requests/GrantAccounts/GetGrantAccountsId1Request.cs` |
| `GrantAccount` | `src/Adyen/Models/GrantAccount.cs` |
| `GetGrantAccountsId1Error` | `src/Adyen/Errors/GetGrantAccountsId1Error.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

