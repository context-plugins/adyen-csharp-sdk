<!-- Generated file — do not edit; regenerated with the SDK. -->

# AuthorizedCardUsers — operations

Accessor: `client.AuthorizedCardUsers` · Source: `src/Adyen/Api/AuthorizedCardUsers.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers

- **Server group**: `Default13`
- **Signature**: `DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers(DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PaymentInstrumentId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest` | `src/Adyen/Requests/AuthorizedCardUsers/DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest.cs` |
| `DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError` | `src/Adyen/Errors/DeletePaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers

- **Server group**: `Default13`
- **Signature**: `GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers(GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PaymentInstrumentId`
- **Returns**: `AuthorisedCardUsers`
- **Error**: `ApiException<GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest` | `src/Adyen/Requests/AuthorizedCardUsers/GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest.cs` |
| `AuthorisedCardUsers` | `src/Adyen/Models/AuthorisedCardUsers.cs` |
| `GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError` | `src/Adyen/Errors/GetPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers

- **Server group**: `Default13`
- **Signature**: `PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers(PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PaymentInstrumentId`, `Body`
- **Returns**: `void` (Task)
- **Error**: `ApiException<PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest` | `src/Adyen/Requests/AuthorizedCardUsers/PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest.cs` |
| `AuthorisedCardUsers` | `src/Adyen/Models/AuthorisedCardUsers.cs` |
| `PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError` | `src/Adyen/Errors/PatchPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers

- **Server group**: `Default13`
- **Signature**: `PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsers(PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `PaymentInstrumentId`, `Body`
- **Returns**: `void` (Task)
- **Error**: `ApiException<PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [400, 401, 403, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest` | `src/Adyen/Requests/AuthorizedCardUsers/PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersRequest.cs` |
| `AuthorisedCardUsers` | `src/Adyen/Models/AuthorisedCardUsers.cs` |
| `PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError` | `src/Adyen/Errors/PostPaymentInstrumentsPaymentInstrumentIdAuthorisedCardUsersError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

