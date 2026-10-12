<!-- Generated file — do not edit; regenerated with the SDK. -->

# BalancesOverview — operations

Accessor: `client.BalancesOverview` · Source: `src/Adyen/Api/BalancesOverview.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetBalanceOverviewCompaniesCompanyAccountCodeBalances

- **Server group**: `Default11`
- **Signature**: `GetBalanceOverviewCompaniesCompanyAccountCodeBalances(GetBalanceOverviewCompaniesCompanyAccountCodeBalancesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CompanyAccountCode`, `Currency`
- **Query params (wire ← C#)**: `currency` ← `Currency`
- **Returns**: `CompanyBalances`
- **Error**: `ApiException<GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBalanceOverviewCompaniesCompanyAccountCodeBalancesRequest` | `src/Adyen/Requests/BalancesOverview/GetBalanceOverviewCompaniesCompanyAccountCodeBalancesRequest.cs` |
| `CompanyBalances` | `src/Adyen/Models/CompanyBalances.cs` |
| `GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError` | `src/Adyen/Errors/GetBalanceOverviewCompaniesCompanyAccountCodeBalancesError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

### GetBalanceOverviewMerchantsMerchantAccountCodeBalances

- **Server group**: `Default11`
- **Signature**: `GetBalanceOverviewMerchantsMerchantAccountCodeBalances(GetBalanceOverviewMerchantsMerchantAccountCodeBalancesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `MerchantAccountCode`, `Currency`
- **Query params (wire ← C#)**: `currency` ← `Currency`
- **Returns**: `MerchantBalance`
- **Error**: `ApiException<GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultErrorResponseEntity(out DefaultErrorResponseEntity)` [401, 403, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBalanceOverviewMerchantsMerchantAccountCodeBalancesRequest` | `src/Adyen/Requests/BalancesOverview/GetBalanceOverviewMerchantsMerchantAccountCodeBalancesRequest.cs` |
| `MerchantBalance` | `src/Adyen/Models/MerchantBalance.cs` |
| `GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError` | `src/Adyen/Errors/GetBalanceOverviewMerchantsMerchantAccountCodeBalancesError.cs` |
| `DefaultErrorResponseEntity` | `src/Adyen/Models/DefaultErrorResponseEntity.cs` |

