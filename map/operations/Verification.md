<!-- Generated file — do not edit; regenerated with the SDK. -->

# Verification — operations

Accessor: `client.Verification` · Source: `src/Adyen/Api/Verification.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### PostCheckAccountHolder

- **Server group**: `Default10`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostCheckAccountHolder(PostCheckAccountHolderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GenericResponse`
- **Error**: `ApiException<PostCheckAccountHolderError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostCheckAccountHolderRequest` | `src/Adyen/Requests/Verification/PostCheckAccountHolderRequest.cs` |
| `PerformVerificationRequest` | `src/Adyen/Models/PerformVerificationRequest.cs` |
| `GenericResponse` | `src/Adyen/Models/GenericResponse.cs` |
| `PostCheckAccountHolderError` | `src/Adyen/Errors/PostCheckAccountHolderError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostDeleteBankAccounts

- **Server group**: `Default10`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostDeleteBankAccounts(PostDeleteBankAccountsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GenericResponse`
- **Error**: `ApiException<PostDeleteBankAccountsError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostDeleteBankAccountsRequest` | `src/Adyen/Requests/Verification/PostDeleteBankAccountsRequest.cs` |
| `DeleteBankAccountRequest` | `src/Adyen/Models/DeleteBankAccountRequest.cs` |
| `GenericResponse` | `src/Adyen/Models/GenericResponse.cs` |
| `PostDeleteBankAccountsError` | `src/Adyen/Errors/PostDeleteBankAccountsError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostDeleteLegalArrangements

- **Server group**: `Default10`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostDeleteLegalArrangements(PostDeleteLegalArrangementsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GenericResponse`
- **Error**: `ApiException<PostDeleteLegalArrangementsError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostDeleteLegalArrangementsRequest` | `src/Adyen/Requests/Verification/PostDeleteLegalArrangementsRequest.cs` |
| `DeleteLegalArrangementRequest` | `src/Adyen/Models/DeleteLegalArrangementRequest.cs` |
| `GenericResponse` | `src/Adyen/Models/GenericResponse.cs` |
| `PostDeleteLegalArrangementsError` | `src/Adyen/Errors/PostDeleteLegalArrangementsError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostDeletePayoutMethods

- **Server group**: `Default10`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostDeletePayoutMethods(PostDeletePayoutMethodsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GenericResponse`
- **Error**: `ApiException<PostDeletePayoutMethodsError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostDeletePayoutMethodsRequest` | `src/Adyen/Requests/Verification/PostDeletePayoutMethodsRequest.cs` |
| `DeletePayoutMethodRequest` | `src/Adyen/Models/DeletePayoutMethodRequest.cs` |
| `GenericResponse` | `src/Adyen/Models/GenericResponse.cs` |
| `PostDeletePayoutMethodsError` | `src/Adyen/Errors/PostDeletePayoutMethodsError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostDeleteShareholders

- **Server group**: `Default10`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostDeleteShareholders(PostDeleteShareholdersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GenericResponse`
- **Error**: `ApiException<PostDeleteShareholdersError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostDeleteShareholdersRequest` | `src/Adyen/Requests/Verification/PostDeleteShareholdersRequest.cs` |
| `DeleteShareholderRequest` | `src/Adyen/Models/DeleteShareholderRequest.cs` |
| `GenericResponse` | `src/Adyen/Models/GenericResponse.cs` |
| `PostDeleteShareholdersError` | `src/Adyen/Errors/PostDeleteShareholdersError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostDeleteSignatories

- **Server group**: `Default10`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostDeleteSignatories(PostDeleteSignatoriesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GenericResponse`
- **Error**: `ApiException<PostDeleteSignatoriesError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostDeleteSignatoriesRequest` | `src/Adyen/Requests/Verification/PostDeleteSignatoriesRequest.cs` |
| `DeleteSignatoriesRequest` | `src/Adyen/Models/DeleteSignatoriesRequest.cs` |
| `GenericResponse` | `src/Adyen/Models/GenericResponse.cs` |
| `PostDeleteSignatoriesError` | `src/Adyen/Errors/PostDeleteSignatoriesError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostGetUploadedDocuments

- **Server group**: `Default10`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostGetUploadedDocuments(PostGetUploadedDocumentsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `GetUploadedDocumentsResponse`
- **Error**: `ApiException<PostGetUploadedDocumentsError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostGetUploadedDocumentsRequest` | `src/Adyen/Requests/Verification/PostGetUploadedDocumentsRequest.cs` |
| `GetUploadedDocumentsRequest` | `src/Adyen/Models/GetUploadedDocumentsRequest.cs` |
| `GetUploadedDocumentsResponse` | `src/Adyen/Models/GetUploadedDocumentsResponse.cs` |
| `PostGetUploadedDocumentsError` | `src/Adyen/Errors/PostGetUploadedDocumentsError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

### PostUploadDocument

- **Server group**: `Default10`
- **Auth**: `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `PostUploadDocument(PostUploadDocumentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `UpdateAccountHolderResponse`
- **Error**: `ApiException<PostUploadDocumentError>` — **Case A (typed)**
- **Error accessors**: `TryGetServiceError1(out ServiceError1)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostUploadDocumentRequest` | `src/Adyen/Requests/Verification/PostUploadDocumentRequest.cs` |
| `UploadDocumentRequest` | `src/Adyen/Models/UploadDocumentRequest.cs` |
| `UpdateAccountHolderResponse` | `src/Adyen/Models/UpdateAccountHolderResponse.cs` |
| `PostUploadDocumentError` | `src/Adyen/Errors/PostUploadDocumentError.cs` |
| `ServiceError1` | `src/Adyen/Models/ServiceError1.cs` |

