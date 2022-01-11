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
using MgmtMultipleParentResource.Models;

namespace MgmtMultipleParentResource
{
    /// <summary> A class representing collection of Parent and their operations over its parent. </summary>
    public partial class ParentCollection : ArmCollection, IEnumerable<Parent>, IAsyncEnumerable<Parent>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ParentsRestOperations _parentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ParentCollection"/> class for mocking. </summary>
        protected ParentCollection()
        {
        }

        /// <summary> Initializes a new instance of ParentCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ParentCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _parentsRestClient = new ParentsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/parents/{parentName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Parents_CreateOrUpdate
        /// <summary> The operation to create or update the VMSS VM run command. </summary>
        /// <param name="parentName"> The name of the VM scale set. </param>
        /// <param name="body"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parentName"/> or <paramref name="body"/> is null. </exception>
        public virtual ParentCreateOrUpdateOperation CreateOrUpdate(string parentName, ParentData body, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parentName == null)
            {
                throw new ArgumentNullException(nameof(parentName));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("ParentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _parentsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, parentName, body, cancellationToken);
                var operation = new ParentCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _parentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, parentName, body).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/parents/{parentName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Parents_CreateOrUpdate
        /// <summary> The operation to create or update the VMSS VM run command. </summary>
        /// <param name="parentName"> The name of the VM scale set. </param>
        /// <param name="body"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parentName"/> or <paramref name="body"/> is null. </exception>
        public async virtual Task<ParentCreateOrUpdateOperation> CreateOrUpdateAsync(string parentName, ParentData body, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parentName == null)
            {
                throw new ArgumentNullException(nameof(parentName));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("ParentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _parentsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, parentName, body, cancellationToken).ConfigureAwait(false);
                var operation = new ParentCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _parentsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, parentName, body).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/parents/{parentName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Parents_Get
        /// <summary> The operation to get the VMSS VM run command. </summary>
        /// <param name="parentName"> The name of the VM scale set. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parentName"/> is null. </exception>
        public virtual Response<Parent> Get(string parentName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (parentName == null)
            {
                throw new ArgumentNullException(nameof(parentName));
            }

            using var scope = _clientDiagnostics.CreateScope("ParentCollection.Get");
            scope.Start();
            try
            {
                var response = _parentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, parentName, expand, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Parent(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/parents/{parentName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Parents_Get
        /// <summary> The operation to get the VMSS VM run command. </summary>
        /// <param name="parentName"> The name of the VM scale set. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parentName"/> is null. </exception>
        public async virtual Task<Response<Parent>> GetAsync(string parentName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (parentName == null)
            {
                throw new ArgumentNullException(nameof(parentName));
            }

            using var scope = _clientDiagnostics.CreateScope("ParentCollection.Get");
            scope.Start();
            try
            {
                var response = await _parentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, parentName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Parent(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="parentName"> The name of the VM scale set. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parentName"/> is null. </exception>
        public virtual Response<Parent> GetIfExists(string parentName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (parentName == null)
            {
                throw new ArgumentNullException(nameof(parentName));
            }

            using var scope = _clientDiagnostics.CreateScope("ParentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _parentsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, parentName, expand, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<Parent>(null, response.GetRawResponse())
                    : Response.FromValue(new Parent(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="parentName"> The name of the VM scale set. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parentName"/> is null. </exception>
        public async virtual Task<Response<Parent>> GetIfExistsAsync(string parentName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (parentName == null)
            {
                throw new ArgumentNullException(nameof(parentName));
            }

            using var scope = _clientDiagnostics.CreateScope("ParentCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _parentsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, parentName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<Parent>(null, response.GetRawResponse())
                    : Response.FromValue(new Parent(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="parentName"> The name of the VM scale set. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parentName"/> is null. </exception>
        public virtual Response<bool> Exists(string parentName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (parentName == null)
            {
                throw new ArgumentNullException(nameof(parentName));
            }

            using var scope = _clientDiagnostics.CreateScope("ParentCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(parentName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="parentName"> The name of the VM scale set. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parentName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string parentName, string expand = null, CancellationToken cancellationToken = default)
        {
            if (parentName == null)
            {
                throw new ArgumentNullException(nameof(parentName));
            }

            using var scope = _clientDiagnostics.CreateScope("ParentCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(parentName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/parents
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Parents_List
        /// <summary> The operation to get all run commands of an instance in Virtual Machine Scaleset. </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Parent" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Parent> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<Parent> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ParentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _parentsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Parent(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Parent> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ParentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _parentsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Parent(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/parents
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Parents_List
        /// <summary> The operation to get all run commands of an instance in Virtual Machine Scaleset. </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Parent" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Parent> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<Parent>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ParentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _parentsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Parent(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Parent>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ParentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _parentsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Parent(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="Parent" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ParentCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(MgmtMultipleParentResource.Parent.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="Parent" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ParentCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(MgmtMultipleParentResource.Parent.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<Parent> IEnumerable<Parent>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Parent> IAsyncEnumerable<Parent>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, Parent, ParentData> Construct() { }
    }
}
