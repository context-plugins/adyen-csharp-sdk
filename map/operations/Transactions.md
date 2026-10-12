<!-- Generated file — do not edit; regenerated with the SDK. -->

# Transactions — operations

Accessor: `client.Transactions` · Source: `src/Adyen/Api/Transactions.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetTransactions

- **Server group**: `Default14`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetTransactions(GetTransactionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CreatedSince`, `CreatedUntil`
- **Query params (wire ← C#)**: `createdSince` ← `CreatedSince`, `createdUntil` ← `CreatedUntil`, `balancePlatform` ← `BalancePlatform`, `paymentInstrumentId` ← `PaymentInstrumentId`, `accountHolderId` ← `AccountHolderId`, `balanceAccountId` ← `BalanceAccountId`, `cursor` ← `Cursor`, `sortOrder` ← `SortOrder`, `limit` ← `Limit`
- **Returns**: `TransactionSearchResponse`
- **Error**: `ApiException<GetTransactionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTransactionsRequest` | `src/Adyen/Requests/Transactions/GetTransactionsRequest.cs` |
| `SortOrder` | `src/Adyen/Models/Enums/SortOrder.cs` |
| `TransactionSearchResponse` | `src/Adyen/Models/TransactionSearchResponse.cs` |
| `GetTransactionsError` | `src/Adyen/Errors/GetTransactionsError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

### GetTransactionsId

- **Server group**: `Default14`
- **Auth**: `options.ClientKey` OR `options.BasicAuth` OR `options.ApiKeyAuth`
- **Signature**: `GetTransactionsId(GetTransactionsIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `Transaction`
- **Error**: `ApiException<GetTransactionsIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetRestServiceError(out RestServiceError)` [401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetTransactionsIdRequest` | `src/Adyen/Requests/Transactions/GetTransactionsIdRequest.cs` |
| `Transaction` | `src/Adyen/Models/Transaction.cs` |
| `GetTransactionsIdError` | `src/Adyen/Errors/GetTransactionsIdError.cs` |
| `RestServiceError` | `src/Adyen/Models/RestServiceError.cs` |

