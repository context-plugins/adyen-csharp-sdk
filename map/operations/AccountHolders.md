<!-- Generated file — do not edit; regenerated with the SDK. -->

# AccountHolders — operations

Accessor: `client.AccountHolders` · Source: `src/Adyen/Api/AccountHolders.cs` · 16 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAccountHoldersId

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetAccountHoldersId(GetAccountHoldersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AccountHolder`
- **Error**: `ApiException<GetAccountHoldersIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAccountHoldersIdRequest` | `src/Adyen/Requests/AccountHolders/GetAccountHoldersIdRequest.cs` |
| `AccountHolder` | `src/Adyen/Models/AccountHolder.cs` |
| `GetAccountHoldersIdError` | `src/Adyen/Errors/GetAccountHoldersIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetAccountHoldersIdBalanceAccounts

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetAccountHoldersIdBalanceAccounts(GetAccountHoldersIdBalanceAccountsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `offset` ← `Offset`, `limit` ← `Limit`
- **Returns**: `PaginatedBalanceAccountsResponse`
- **Error**: `ApiException<GetAccountHoldersIdBalanceAccountsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAccountHoldersIdBalanceAccountsRequest` | `src/Adyen/Requests/AccountHolders/GetAccountHoldersIdBalanceAccountsRequest.cs` |
| `PaginatedBalanceAccountsResponse` | `src/Adyen/Models/PaginatedBalanceAccountsResponse.cs` |
| `GetAccountHoldersIdBalanceAccountsError` | `src/Adyen/Errors/GetAccountHoldersIdBalanceAccountsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetAccountHoldersIdTaxFormSummary

- **Server group**: `Default13`
- **Signature**: `GetAccountHoldersIdTaxFormSummary(GetAccountHoldersIdTaxFormSummaryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `FormType`
- **Query params (wire ← C#)**: `formType` ← `FormType`
- **Returns**: `TaxFormSummaryResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetAccountHoldersIdTaxFormSummaryRequest` | `src/Adyen/Requests/AccountHolders/GetAccountHoldersIdTaxFormSummaryRequest.cs` |
| `TaxFormSummaryResponse` | `src/Adyen/Models/TaxFormSummaryResponse.cs` |

### GetAccountHoldersIdTaxForms

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetAccountHoldersIdTaxForms(GetAccountHoldersIdTaxFormsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `FormType`, `Year`
- **Query params (wire ← C#)**: `formType` ← `FormType`, `year` ← `Year`, `legalEntityId` ← `LegalEntityId`
- **Returns**: `GetTaxFormResponse1`
- **Error**: `ApiException<GetAccountHoldersIdTaxFormsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAccountHoldersIdTaxFormsRequest` | `src/Adyen/Requests/AccountHolders/GetAccountHoldersIdTaxFormsRequest.cs` |
| `FormType` | `src/Adyen/Models/Enums/FormType.cs` |
| `GetTaxFormResponse1` | `src/Adyen/Models/GetTaxFormResponse1.cs` |
| `GetAccountHoldersIdTaxFormsError` | `src/Adyen/Errors/GetAccountHoldersIdTaxFormsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetAccountHoldersIdTransactionRules

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetAccountHoldersIdTransactionRules(GetAccountHoldersIdTransactionRulesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `TransactionRulesResponse`
- **Error**: `ApiException<GetAccountHoldersIdTransactionRulesError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAccountHoldersIdTransactionRulesRequest` | `src/Adyen/Requests/AccountHolders/GetAccountHoldersIdTransactionRulesRequest.cs` |
| `TransactionRulesResponse` | `src/Adyen/Models/TransactionRulesResponse.cs` |
| `GetAccountHoldersIdTransactionRulesError` | `src/Adyen/Errors/GetAccountHoldersIdTransactionRulesError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PatchAccountHoldersId

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PatchAccountHoldersId(PatchAccountHoldersIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `AccountHolder`
- **Error**: `ApiException<PatchAccountHoldersIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchAccountHoldersIdRequest` | `src/Adyen/Requests/AccountHolders/PatchAccountHoldersIdRequest.cs` |
| `AccountHolderUpdateRequest` | `src/Adyen/Models/AccountHolderUpdateRequest.cs` |
| `AccountHolder` | `src/Adyen/Models/AccountHolder.cs` |
| `PatchAccountHoldersIdError` | `src/Adyen/Errors/PatchAccountHoldersIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostAccountHolders

- **Server group**: `Default13`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostAccountHolders(PostAccountHoldersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `AccountHolder`
- **Error**: `ApiException<PostAccountHoldersError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostAccountHoldersRequest` | `src/Adyen/Requests/AccountHolders/PostAccountHoldersRequest.cs` |
| `AccountHolderInfo` | `src/Adyen/Models/AccountHolderInfo.cs` |
| `AccountHolder` | `src/Adyen/Models/AccountHolder.cs` |
| `PostAccountHoldersError` | `src/Adyen/Errors/PostAccountHoldersError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### PostCloseAccountHolder

- **Server group**: `Default10`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCloseAccountHolder(PostCloseAccountHolderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CloseAccountHolderResponse`
- **Error**: `ApiException<PostCloseAccountHolderError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCloseAccountHolderRequest` | `src/Adyen/Requests/AccountHolders/PostCloseAccountHolderRequest.cs` |
| `CloseAccountHolderRequest` | `src/Adyen/Models/CloseAccountHolderRequest.cs` |
| `CloseAccountHolderResponse` | `src/Adyen/Models/CloseAccountHolderResponse.cs` |
| `PostCloseAccountHolderError` | `src/Adyen/Errors/PostCloseAccountHolderError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostCloseStores

- **Server group**: `Default10`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCloseStores(PostCloseStoresRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GenericResponse`
- **Error**: `ApiException<PostCloseStoresError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCloseStoresRequest` | `src/Adyen/Requests/AccountHolders/PostCloseStoresRequest.cs` |
| `CloseStoresRequest` | `src/Adyen/Models/CloseStoresRequest.cs` |
| `GenericResponse` | `src/Adyen/Models/GenericResponse.cs` |
| `PostCloseStoresError` | `src/Adyen/Errors/PostCloseStoresError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostCreateAccountHolder

- **Server group**: `Default10`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCreateAccountHolder(PostCreateAccountHolderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `CreateAccountHolderResponse`
- **Error**: `ApiException<PostCreateAccountHolderError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCreateAccountHolderRequest` | `src/Adyen/Requests/AccountHolders/PostCreateAccountHolderRequest.cs` |
| `CreateAccountHolderRequest` | `src/Adyen/Models/CreateAccountHolderRequest.cs` |
| `CreateAccountHolderResponse` | `src/Adyen/Models/CreateAccountHolderResponse.cs` |
| `PostCreateAccountHolderError` | `src/Adyen/Errors/PostCreateAccountHolderError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostGetAccountHolder

- **Server group**: `Default10`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostGetAccountHolder(PostGetAccountHolderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GetAccountHolderResponse`
- **Error**: `ApiException<PostGetAccountHolderError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostGetAccountHolderRequest` | `src/Adyen/Requests/AccountHolders/PostGetAccountHolderRequest.cs` |
| `GetAccountHolderRequest` | `src/Adyen/Models/GetAccountHolderRequest.cs` |
| `GetAccountHolderResponse` | `src/Adyen/Models/GetAccountHolderResponse.cs` |
| `PostGetAccountHolderError` | `src/Adyen/Errors/PostGetAccountHolderError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostGetTaxForm

- **Server group**: `Default10`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostGetTaxForm(PostGetTaxFormRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GetTaxFormResponse`
- **Error**: `ApiException<PostGetTaxFormError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostGetTaxFormRequest` | `src/Adyen/Requests/AccountHolders/PostGetTaxFormRequest.cs` |
| `GetTaxFormRequest` | `src/Adyen/Models/GetTaxFormRequest.cs` |
| `GetTaxFormResponse` | `src/Adyen/Models/GetTaxFormResponse.cs` |
| `PostGetTaxFormError` | `src/Adyen/Errors/PostGetTaxFormError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostSuspendAccountHolder

- **Server group**: `Default10`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostSuspendAccountHolder(PostSuspendAccountHolderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `SuspendAccountHolderResponse`
- **Error**: `ApiException<PostSuspendAccountHolderError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostSuspendAccountHolderRequest` | `src/Adyen/Requests/AccountHolders/PostSuspendAccountHolderRequest.cs` |
| `SuspendAccountHolderRequest` | `src/Adyen/Models/SuspendAccountHolderRequest.cs` |
| `SuspendAccountHolderResponse` | `src/Adyen/Models/SuspendAccountHolderResponse.cs` |
| `PostSuspendAccountHolderError` | `src/Adyen/Errors/PostSuspendAccountHolderError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostUnSuspendAccountHolder

- **Server group**: `Default10`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostUnSuspendAccountHolder(PostUnSuspendAccountHolderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `UnSuspendAccountHolderResponse`
- **Error**: `ApiException<PostUnSuspendAccountHolderError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostUnSuspendAccountHolderRequest` | `src/Adyen/Requests/AccountHolders/PostUnSuspendAccountHolderRequest.cs` |
| `UnSuspendAccountHolderRequest` | `src/Adyen/Models/UnSuspendAccountHolderRequest.cs` |
| `UnSuspendAccountHolderResponse` | `src/Adyen/Models/UnSuspendAccountHolderResponse.cs` |
| `PostUnSuspendAccountHolderError` | `src/Adyen/Errors/PostUnSuspendAccountHolderError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostUpdateAccountHolder

- **Server group**: `Default10`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostUpdateAccountHolder(PostUpdateAccountHolderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `UpdateAccountHolderResponse`
- **Error**: `ApiException<PostUpdateAccountHolderError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostUpdateAccountHolderRequest` | `src/Adyen/Requests/AccountHolders/PostUpdateAccountHolderRequest.cs` |
| `UpdateAccountHolderRequest` | `src/Adyen/Models/UpdateAccountHolderRequest.cs` |
| `UpdateAccountHolderResponse` | `src/Adyen/Models/UpdateAccountHolderResponse.cs` |
| `PostUpdateAccountHolderError` | `src/Adyen/Errors/PostUpdateAccountHolderError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostUpdateAccountHolderState

- **Server group**: `Default10`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostUpdateAccountHolderState(PostUpdateAccountHolderStateRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GetAccountHolderStatusResponse`
- **Error**: `ApiException<PostUpdateAccountHolderStateError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostUpdateAccountHolderStateRequest` | `src/Adyen/Requests/AccountHolders/PostUpdateAccountHolderStateRequest.cs` |
| `UpdateAccountHolderStateRequest` | `src/Adyen/Models/UpdateAccountHolderStateRequest.cs` |
| `GetAccountHolderStatusResponse` | `src/Adyen/Models/GetAccountHolderStatusResponse.cs` |
| `PostUpdateAccountHolderStateError` | `src/Adyen/Errors/PostUpdateAccountHolderStateError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

