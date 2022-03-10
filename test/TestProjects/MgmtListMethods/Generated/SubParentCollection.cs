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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace MgmtListMethods
{
    /// <summary> A class representing collection of SubParent and their operations over its parent. </summary>
    public partial class SubParentCollection : ArmCollection, IEnumerable<SubParent>, IAsyncEnumerable<SubParent>
    {
        private readonly ClientDiagnostics _subParentClientDiagnostics;
        private readonly SubParentsRestOperations _subParentRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubParentCollection"/> class for mocking. </summary>
        protected SubParentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubParentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SubParentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subParentClientDiagnostics = new ClientDiagnostics("MgmtListMethods", SubParent.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(SubParent.ResourceType, out string subParentApiVersion);
            _subParentRestClient = new SubParentsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, subParentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Subscription.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Subscription.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParents/{subParentName}
        /// Operation Id: SubParents_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="subParentName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<SubParent>> CreateOrUpdateAsync(bool waitForCompletion, string subParentName, SubParentData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentName, nameof(subParentName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _subParentClientDiagnostics.CreateScope("SubParentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _subParentRestClient.CreateOrUpdateAsync(Id.SubscriptionId, subParentName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtListMethodsArmOperation<SubParent>(Response.FromValue(new SubParent(Client, response), response.GetRawResponse()));
                if (waitForCompletion)
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
        /// Create or update.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParents/{subParentName}
        /// Operation Id: SubParents_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="subParentName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<SubParent> CreateOrUpdate(bool waitForCompletion, string subParentName, SubParentData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentName, nameof(subParentName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _subParentClientDiagnostics.CreateScope("SubParentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _subParentRestClient.CreateOrUpdate(Id.SubscriptionId, subParentName, parameters, cancellationToken);
                var operation = new MgmtListMethodsArmOperation<SubParent>(Response.FromValue(new SubParent(Client, response), response.GetRawResponse()));
                if (waitForCompletion)
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
        /// Retrieves information.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParents/{subParentName}
        /// Operation Id: SubParents_Get
        /// </summary>
        /// <param name="subParentName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentName"/> is null. </exception>
        public virtual async Task<Response<SubParent>> GetAsync(string subParentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentName, nameof(subParentName));

            using var scope = _subParentClientDiagnostics.CreateScope("SubParentCollection.Get");
            scope.Start();
            try
            {
                var response = await _subParentRestClient.GetAsync(Id.SubscriptionId, subParentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubParent(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParents/{subParentName}
        /// Operation Id: SubParents_Get
        /// </summary>
        /// <param name="subParentName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentName"/> is null. </exception>
        public virtual Response<SubParent> Get(string subParentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentName, nameof(subParentName));

            using var scope = _subParentClientDiagnostics.CreateScope("SubParentCollection.Get");
            scope.Start();
            try
            {
                var response = _subParentRestClient.Get(Id.SubscriptionId, subParentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubParent(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParents
        /// Operation Id: SubParents_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubParent" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubParent> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SubParent>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subParentClientDiagnostics.CreateScope("SubParentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subParentRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParent(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SubParent>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subParentClientDiagnostics.CreateScope("SubParentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subParentRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParent(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParents
        /// Operation Id: SubParents_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubParent" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubParent> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SubParent> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subParentClientDiagnostics.CreateScope("SubParentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subParentRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParent(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SubParent> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subParentClientDiagnostics.CreateScope("SubParentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subParentRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParent(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParents/{subParentName}
        /// Operation Id: SubParents_Get
        /// </summary>
        /// <param name="subParentName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string subParentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentName, nameof(subParentName));

            using var scope = _subParentClientDiagnostics.CreateScope("SubParentCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(subParentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParents/{subParentName}
        /// Operation Id: SubParents_Get
        /// </summary>
        /// <param name="subParentName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentName"/> is null. </exception>
        public virtual Response<bool> Exists(string subParentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentName, nameof(subParentName));

            using var scope = _subParentClientDiagnostics.CreateScope("SubParentCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(subParentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParents/{subParentName}
        /// Operation Id: SubParents_Get
        /// </summary>
        /// <param name="subParentName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentName"/> is null. </exception>
        public virtual async Task<Response<SubParent>> GetIfExistsAsync(string subParentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentName, nameof(subParentName));

            using var scope = _subParentClientDiagnostics.CreateScope("SubParentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _subParentRestClient.GetAsync(Id.SubscriptionId, subParentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SubParent>(null, response.GetRawResponse());
                return Response.FromValue(new SubParent(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParents/{subParentName}
        /// Operation Id: SubParents_Get
        /// </summary>
        /// <param name="subParentName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentName"/> is null. </exception>
        public virtual Response<SubParent> GetIfExists(string subParentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subParentName, nameof(subParentName));

            using var scope = _subParentClientDiagnostics.CreateScope("SubParentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _subParentRestClient.Get(Id.SubscriptionId, subParentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SubParent>(null, response.GetRawResponse());
                return Response.FromValue(new SubParent(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SubParent> IEnumerable<SubParent>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubParent> IAsyncEnumerable<SubParent>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
