<!-- Generated file — do not edit; regenerated with the SDK. -->

# BalanceAccounts — operations

Accessor: `client.BalanceAccounts` · Source: `src/Adyen/Api/BalanceAccounts.cs` · 5 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetBalanceAccountsId

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetBalanceAccountsId(GetBalanceAccountsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `BalanceAccount`
- **Error**: `ApiException<GetBalanceAccountsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBalanceAccountsIdRequest` | `src/Adyen/Requests/BalanceAccounts/GetBalanceAccountsIdRequest.cs` |
| `BalanceAccount` | `src/Adyen/Models/BalanceAccount.cs` |
| `GetBalanceAccountsIdError` | `src/Adyen/Errors/GetBalanceAccountsIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetBalanceAccountsIdPaymentInstruments

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetBalanceAccountsIdPaymentInstruments(GetBalanceAccountsIdPaymentInstrumentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `offset` ← `Offset`, `limit` ← `Limit`, `status` ← `Status`
- **Returns**: `PaginatedPaymentInstrumentsResponse`
- **Error**: `ApiException<GetBalanceAccountsIdPaymentInstrumentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBalanceAccountsIdPaymentInstrumentsRequest` | `src/Adyen/Requests/BalanceAccounts/GetBalanceAccountsIdPaymentInstrumentsRequest.cs` |
| `PaginatedPaymentInstrumentsResponse` | `src/Adyen/Models/PaginatedPaymentInstrumentsResponse.cs` |
| `GetBalanceAccountsIdPaymentInstrumentsError` | `src/Adyen/Errors/GetBalanceAccountsIdPaymentInstrumentsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetBalanceAccountsIdTransactionRules

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetBalanceAccountsIdTransactionRules(GetBalanceAccountsIdTransactionRulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `TransactionRulesResponse`
- **Error**: `ApiException<GetBalanceAccountsIdTransactionRulesError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBalanceAccountsIdTransactionRulesRequest` | `src/Adyen/Requests/BalanceAccounts/GetBalanceAccountsIdTransactionRulesRequest.cs` |
| `TransactionRulesResponse` | `src/Adyen/Models/TransactionRulesResponse.cs` |
| `GetBalanceAccountsIdTransactionRulesError` | `src/Adyen/Errors/GetBalanceAccountsIdTransactionRulesError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchBalanceAccountsId

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchBalanceAccountsId(PatchBalanceAccountsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `BalanceAccount`
- **Error**: `ApiException<PatchBalanceAccountsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchBalanceAccountsIdRequest` | `src/Adyen/Requests/BalanceAccounts/PatchBalanceAccountsIdRequest.cs` |
| `BalanceAccountUpdateRequest` | `src/Adyen/Models/BalanceAccountUpdateRequest.cs` |
| `BalanceAccount` | `src/Adyen/Models/BalanceAccount.cs` |
| `PatchBalanceAccountsIdError` | `src/Adyen/Errors/PatchBalanceAccountsIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostBalanceAccounts

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostBalanceAccounts(PostBalanceAccountsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `BalanceAccount`
- **Error**: `ApiException<PostBalanceAccountsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostBalanceAccountsRequest` | `src/Adyen/Requests/BalanceAccounts/PostBalanceAccountsRequest.cs` |
| `BalanceAccountInfo` | `src/Adyen/Models/BalanceAccountInfo.cs` |
| `BalanceAccount` | `src/Adyen/Models/BalanceAccount.cs` |
| `PostBalanceAccountsError` | `src/Adyen/Errors/PostBalanceAccountsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

