// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Reservations.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Reservations
{
    /// <summary>
    /// A class representing a collection of <see cref="ReservationOrderResponseResource" /> and their operations.
    /// Each <see cref="ReservationOrderResponseResource" /> in the collection will belong to the same instance of <see cref="TenantResource" />.
    /// To get a <see cref="ReservationOrderResponseCollection" /> instance call the GetReservationOrderResponses method from an instance of <see cref="TenantResource" />.
    /// </summary>
    public partial class ReservationOrderResponseCollection : ArmCollection, IEnumerable<ReservationOrderResponseResource>, IAsyncEnumerable<ReservationOrderResponseResource>
    {
        private readonly ClientDiagnostics _reservationOrderResponseReservationOrderClientDiagnostics;
        private readonly ReservationOrderRestOperations _reservationOrderResponseReservationOrderRestClient;

        /// <summary> Initializes a new instance of the <see cref="ReservationOrderResponseCollection"/> class for mocking. </summary>
        protected ReservationOrderResponseCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ReservationOrderResponseCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ReservationOrderResponseCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _reservationOrderResponseReservationOrderClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Reservations", ReservationOrderResponseResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ReservationOrderResponseResource.ResourceType, out string reservationOrderResponseReservationOrderApiVersion);
            _reservationOrderResponseReservationOrderRestClient = new ReservationOrderRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, reservationOrderResponseReservationOrderApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Purchase `ReservationOrder` and create resource under the specified URI.
        /// Request Path: /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}
        /// Operation Id: ReservationOrder_Purchase
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="content"> Information needed for calculate or purchase reservation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderId"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<ReservationOrderResponseResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string reservationOrderId, PurchaseRequestContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _reservationOrderResponseReservationOrderClientDiagnostics.CreateScope("ReservationOrderResponseCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _reservationOrderResponseReservationOrderRestClient.PurchaseAsync(reservationOrderId, content, cancellationToken).ConfigureAwait(false);
                var operation = new ReservationsArmOperation<ReservationOrderResponseResource>(new ReservationOrderResponseOperationSource(Client), _reservationOrderResponseReservationOrderClientDiagnostics, Pipeline, _reservationOrderResponseReservationOrderRestClient.CreatePurchaseRequest(reservationOrderId, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Purchase `ReservationOrder` and create resource under the specified URI.
        /// Request Path: /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}
        /// Operation Id: ReservationOrder_Purchase
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="content"> Information needed for calculate or purchase reservation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderId"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<ReservationOrderResponseResource> CreateOrUpdate(WaitUntil waitUntil, string reservationOrderId, PurchaseRequestContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _reservationOrderResponseReservationOrderClientDiagnostics.CreateScope("ReservationOrderResponseCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _reservationOrderResponseReservationOrderRestClient.Purchase(reservationOrderId, content, cancellationToken);
                var operation = new ReservationsArmOperation<ReservationOrderResponseResource>(new ReservationOrderResponseOperationSource(Client), _reservationOrderResponseReservationOrderClientDiagnostics, Pipeline, _reservationOrderResponseReservationOrderRestClient.CreatePurchaseRequest(reservationOrderId, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the details of the `ReservationOrder`.
        /// Request Path: /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}
        /// Operation Id: ReservationOrder_Get
        /// </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="expand"> May be used to expand the planInformation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderId"/> is null. </exception>
        public virtual async Task<Response<ReservationOrderResponseResource>> GetAsync(string reservationOrderId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));

            using var scope = _reservationOrderResponseReservationOrderClientDiagnostics.CreateScope("ReservationOrderResponseCollection.Get");
            scope.Start();
            try
            {
                var response = await _reservationOrderResponseReservationOrderRestClient.GetAsync(reservationOrderId, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ReservationOrderResponseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the details of the `ReservationOrder`.
        /// Request Path: /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}
        /// Operation Id: ReservationOrder_Get
        /// </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="expand"> May be used to expand the planInformation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderId"/> is null. </exception>
        public virtual Response<ReservationOrderResponseResource> Get(string reservationOrderId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));

            using var scope = _reservationOrderResponseReservationOrderClientDiagnostics.CreateScope("ReservationOrderResponseCollection.Get");
            scope.Start();
            try
            {
                var response = _reservationOrderResponseReservationOrderRestClient.Get(reservationOrderId, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ReservationOrderResponseResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of all the `ReservationOrder`s that the user has access to in the current tenant.
        /// Request Path: /providers/Microsoft.Capacity/reservationOrders
        /// Operation Id: ReservationOrder_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ReservationOrderResponseResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ReservationOrderResponseResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ReservationOrderResponseResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _reservationOrderResponseReservationOrderClientDiagnostics.CreateScope("ReservationOrderResponseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _reservationOrderResponseReservationOrderRestClient.ListAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ReservationOrderResponseResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ReservationOrderResponseResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _reservationOrderResponseReservationOrderClientDiagnostics.CreateScope("ReservationOrderResponseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _reservationOrderResponseReservationOrderRestClient.ListNextPageAsync(nextLink, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ReservationOrderResponseResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// List of all the `ReservationOrder`s that the user has access to in the current tenant.
        /// Request Path: /providers/Microsoft.Capacity/reservationOrders
        /// Operation Id: ReservationOrder_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ReservationOrderResponseResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ReservationOrderResponseResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ReservationOrderResponseResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _reservationOrderResponseReservationOrderClientDiagnostics.CreateScope("ReservationOrderResponseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _reservationOrderResponseReservationOrderRestClient.List(cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ReservationOrderResponseResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ReservationOrderResponseResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _reservationOrderResponseReservationOrderClientDiagnostics.CreateScope("ReservationOrderResponseCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _reservationOrderResponseReservationOrderRestClient.ListNextPage(nextLink, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ReservationOrderResponseResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}
        /// Operation Id: ReservationOrder_Get
        /// </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="expand"> May be used to expand the planInformation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string reservationOrderId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));

            using var scope = _reservationOrderResponseReservationOrderClientDiagnostics.CreateScope("ReservationOrderResponseCollection.Exists");
            scope.Start();
            try
            {
                var response = await _reservationOrderResponseReservationOrderRestClient.GetAsync(reservationOrderId, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}
        /// Operation Id: ReservationOrder_Get
        /// </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="expand"> May be used to expand the planInformation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="reservationOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="reservationOrderId"/> is null. </exception>
        public virtual Response<bool> Exists(string reservationOrderId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));

            using var scope = _reservationOrderResponseReservationOrderClientDiagnostics.CreateScope("ReservationOrderResponseCollection.Exists");
            scope.Start();
            try
            {
                var response = _reservationOrderResponseReservationOrderRestClient.Get(reservationOrderId, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ReservationOrderResponseResource> IEnumerable<ReservationOrderResponseResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ReservationOrderResponseResource> IAsyncEnumerable<ReservationOrderResponseResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
