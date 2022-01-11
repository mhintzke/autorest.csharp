// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using ResourceRename.Models;

namespace ResourceRename
{
    /// <summary> A class representing collection of SshPublicKeyInfo and their operations over its parent. </summary>
    public partial class SshPublicKeyInfoCollection : ArmCollection, IEnumerable<SshPublicKeyInfo>, IAsyncEnumerable<SshPublicKeyInfo>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly SshPublicKeysRestOperations _sshPublicKeysRestClient;

        /// <summary> Initializes a new instance of the <see cref="SshPublicKeyInfoCollection"/> class for mocking. </summary>
        protected SshPublicKeyInfoCollection()
        {
        }

        /// <summary> Initializes a new instance of SshPublicKeyInfoCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SshPublicKeyInfoCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _sshPublicKeysRestClient = new SshPublicKeysRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format("Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/sshPublicKeys/{sshPublicKeyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: SshPublicKeys_Create
        /// <summary> Creates a new SSH public key resource. </summary>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="properties"> Contains information about SSH certificate public key and the path on the Linux VM where the public key is placed. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sshPublicKeyName"/> is null. </exception>
        public virtual SshPublicKeyCreateOperation CreateOrUpdate(string sshPublicKeyName, SshPublicKeyProperties properties = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (sshPublicKeyName == null)
            {
                throw new ArgumentNullException(nameof(sshPublicKeyName));
            }

            using var scope = _clientDiagnostics.CreateScope("SshPublicKeyInfoCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sshPublicKeysRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, sshPublicKeyName, properties, cancellationToken);
                var operation = new SshPublicKeyCreateOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/sshPublicKeys/{sshPublicKeyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: SshPublicKeys_Create
        /// <summary> Creates a new SSH public key resource. </summary>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="properties"> Contains information about SSH certificate public key and the path on the Linux VM where the public key is placed. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sshPublicKeyName"/> is null. </exception>
        public async virtual Task<SshPublicKeyCreateOperation> CreateOrUpdateAsync(string sshPublicKeyName, SshPublicKeyProperties properties = null, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (sshPublicKeyName == null)
            {
                throw new ArgumentNullException(nameof(sshPublicKeyName));
            }

            using var scope = _clientDiagnostics.CreateScope("SshPublicKeyInfoCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sshPublicKeysRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, sshPublicKeyName, properties, cancellationToken).ConfigureAwait(false);
                var operation = new SshPublicKeyCreateOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/sshPublicKeys/{sshPublicKeyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: SshPublicKeys_Get
        /// <summary> Retrieves information about an SSH public key. </summary>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sshPublicKeyName"/> is null. </exception>
        public virtual Response<SshPublicKeyInfo> Get(string sshPublicKeyName, CancellationToken cancellationToken = default)
        {
            if (sshPublicKeyName == null)
            {
                throw new ArgumentNullException(nameof(sshPublicKeyName));
            }

            using var scope = _clientDiagnostics.CreateScope("SshPublicKeyInfoCollection.Get");
            scope.Start();
            try
            {
                var response = _sshPublicKeysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, sshPublicKeyName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SshPublicKeyInfo(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/sshPublicKeys/{sshPublicKeyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: SshPublicKeys_Get
        /// <summary> Retrieves information about an SSH public key. </summary>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sshPublicKeyName"/> is null. </exception>
        public async virtual Task<Response<SshPublicKeyInfo>> GetAsync(string sshPublicKeyName, CancellationToken cancellationToken = default)
        {
            if (sshPublicKeyName == null)
            {
                throw new ArgumentNullException(nameof(sshPublicKeyName));
            }

            using var scope = _clientDiagnostics.CreateScope("SshPublicKeyInfoCollection.Get");
            scope.Start();
            try
            {
                var response = await _sshPublicKeysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, sshPublicKeyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SshPublicKeyInfo(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sshPublicKeyName"/> is null. </exception>
        public virtual Response<SshPublicKeyInfo> GetIfExists(string sshPublicKeyName, CancellationToken cancellationToken = default)
        {
            if (sshPublicKeyName == null)
            {
                throw new ArgumentNullException(nameof(sshPublicKeyName));
            }

            using var scope = _clientDiagnostics.CreateScope("SshPublicKeyInfoCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sshPublicKeysRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, sshPublicKeyName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SshPublicKeyInfo>(null, response.GetRawResponse())
                    : Response.FromValue(new SshPublicKeyInfo(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sshPublicKeyName"/> is null. </exception>
        public async virtual Task<Response<SshPublicKeyInfo>> GetIfExistsAsync(string sshPublicKeyName, CancellationToken cancellationToken = default)
        {
            if (sshPublicKeyName == null)
            {
                throw new ArgumentNullException(nameof(sshPublicKeyName));
            }

            using var scope = _clientDiagnostics.CreateScope("SshPublicKeyInfoCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _sshPublicKeysRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, sshPublicKeyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SshPublicKeyInfo>(null, response.GetRawResponse())
                    : Response.FromValue(new SshPublicKeyInfo(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sshPublicKeyName"/> is null. </exception>
        public virtual Response<bool> Exists(string sshPublicKeyName, CancellationToken cancellationToken = default)
        {
            if (sshPublicKeyName == null)
            {
                throw new ArgumentNullException(nameof(sshPublicKeyName));
            }

            using var scope = _clientDiagnostics.CreateScope("SshPublicKeyInfoCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(sshPublicKeyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="sshPublicKeyName"> The name of the SSH public key. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sshPublicKeyName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string sshPublicKeyName, CancellationToken cancellationToken = default)
        {
            if (sshPublicKeyName == null)
            {
                throw new ArgumentNullException(nameof(sshPublicKeyName));
            }

            using var scope = _clientDiagnostics.CreateScope("SshPublicKeyInfoCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(sshPublicKeyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/sshPublicKeys
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: SshPublicKeys_ListByResourceGroup
        /// <summary> Lists all of the SSH public keys in the specified resource group. Use the nextLink property in the response to get the next page of SSH public keys. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SshPublicKeyInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SshPublicKeyInfo> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SshPublicKeyInfo> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SshPublicKeyInfoCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sshPublicKeysRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SshPublicKeyInfo(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SshPublicKeyInfo> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SshPublicKeyInfoCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sshPublicKeysRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SshPublicKeyInfo(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/sshPublicKeys
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: SshPublicKeys_ListByResourceGroup
        /// <summary> Lists all of the SSH public keys in the specified resource group. Use the nextLink property in the response to get the next page of SSH public keys. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SshPublicKeyInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SshPublicKeyInfo> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SshPublicKeyInfo>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SshPublicKeyInfoCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sshPublicKeysRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SshPublicKeyInfo(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SshPublicKeyInfo>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SshPublicKeyInfoCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sshPublicKeysRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SshPublicKeyInfo(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="SshPublicKeyInfo" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SshPublicKeyInfoCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SshPublicKeyInfo.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="SshPublicKeyInfo" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SshPublicKeyInfoCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SshPublicKeyInfo.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SshPublicKeyInfo> IEnumerable<SshPublicKeyInfo>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SshPublicKeyInfo> IAsyncEnumerable<SshPublicKeyInfo>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SshPublicKeyInfo, SshPublicKeyInfoData> Construct() { }
    }
}
