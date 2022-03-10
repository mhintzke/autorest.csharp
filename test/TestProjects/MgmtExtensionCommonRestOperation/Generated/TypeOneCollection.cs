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

namespace MgmtExtensionCommonRestOperation
{
    /// <summary> A class representing collection of TypeOne and their operations over its parent. </summary>
    public partial class TypeOneCollection : ArmCollection, IEnumerable<TypeOne>, IAsyncEnumerable<TypeOne>
    {
        private readonly ClientDiagnostics _typeOneCommonClientDiagnostics;
        private readonly CommonRestOperations _typeOneCommonRestClient;

        /// <summary> Initializes a new instance of the <see cref="TypeOneCollection"/> class for mocking. </summary>
        protected TypeOneCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="TypeOneCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal TypeOneCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _typeOneCommonClientDiagnostics = new ClientDiagnostics("MgmtExtensionCommonRestOperation", TypeOne.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(TypeOne.ResourceType, out string typeOneCommonApiVersion);
            _typeOneCommonRestClient = new CommonRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, typeOneCommonApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Validate information for a certificate order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.TypeOne/typeOnes/{typeOneName}
        /// Operation Id: Common_CreateOrUpdateTypeOne
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="typeOneName"> The name. </param>
        /// <param name="typeOne"> Information to validate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="typeOneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="typeOneName"/> or <paramref name="typeOne"/> is null. </exception>
        public virtual async Task<ArmOperation<TypeOne>> CreateOrUpdateAsync(bool waitForCompletion, string typeOneName, TypeOneData typeOne, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(typeOneName, nameof(typeOneName));
            Argument.AssertNotNull(typeOne, nameof(typeOne));

            using var scope = _typeOneCommonClientDiagnostics.CreateScope("TypeOneCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _typeOneCommonRestClient.CreateOrUpdateTypeOneAsync(Id.SubscriptionId, Id.ResourceGroupName, typeOneName, typeOne, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtExtensionCommonRestOperationArmOperation<TypeOne>(Response.FromValue(new TypeOne(Client, response), response.GetRawResponse()));
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
        /// Description for Validate information for a certificate order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.TypeOne/typeOnes/{typeOneName}
        /// Operation Id: Common_CreateOrUpdateTypeOne
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="typeOneName"> The name. </param>
        /// <param name="typeOne"> Information to validate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="typeOneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="typeOneName"/> or <paramref name="typeOne"/> is null. </exception>
        public virtual ArmOperation<TypeOne> CreateOrUpdate(bool waitForCompletion, string typeOneName, TypeOneData typeOne, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(typeOneName, nameof(typeOneName));
            Argument.AssertNotNull(typeOne, nameof(typeOne));

            using var scope = _typeOneCommonClientDiagnostics.CreateScope("TypeOneCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _typeOneCommonRestClient.CreateOrUpdateTypeOne(Id.SubscriptionId, Id.ResourceGroupName, typeOneName, typeOne, cancellationToken);
                var operation = new MgmtExtensionCommonRestOperationArmOperation<TypeOne>(Response.FromValue(new TypeOne(Client, response), response.GetRawResponse()));
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
        /// Description for Validate information for a certificate order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.TypeOne/typeOnes/{typeOneName}
        /// Operation Id: Common_GetTypeOne
        /// </summary>
        /// <param name="typeOneName"> The name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="typeOneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="typeOneName"/> is null. </exception>
        public virtual async Task<Response<TypeOne>> GetAsync(string typeOneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(typeOneName, nameof(typeOneName));

            using var scope = _typeOneCommonClientDiagnostics.CreateScope("TypeOneCollection.Get");
            scope.Start();
            try
            {
                var response = await _typeOneCommonRestClient.GetTypeOneAsync(Id.SubscriptionId, Id.ResourceGroupName, typeOneName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TypeOne(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Validate information for a certificate order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.TypeOne/typeOnes/{typeOneName}
        /// Operation Id: Common_GetTypeOne
        /// </summary>
        /// <param name="typeOneName"> The name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="typeOneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="typeOneName"/> is null. </exception>
        public virtual Response<TypeOne> Get(string typeOneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(typeOneName, nameof(typeOneName));

            using var scope = _typeOneCommonClientDiagnostics.CreateScope("TypeOneCollection.Get");
            scope.Start();
            try
            {
                var response = _typeOneCommonRestClient.GetTypeOne(Id.SubscriptionId, Id.ResourceGroupName, typeOneName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TypeOne(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Validate information for a certificate order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.TypeOne/typeOnes
        /// Operation Id: Common_ListTypeOnes
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TypeOne" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TypeOne> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<TypeOne>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _typeOneCommonClientDiagnostics.CreateScope("TypeOneCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _typeOneCommonRestClient.ListTypeOnesAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new TypeOne(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Description for Validate information for a certificate order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.TypeOne/typeOnes
        /// Operation Id: Common_ListTypeOnes
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TypeOne" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TypeOne> GetAll(CancellationToken cancellationToken = default)
        {
            Page<TypeOne> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _typeOneCommonClientDiagnostics.CreateScope("TypeOneCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _typeOneCommonRestClient.ListTypeOnes(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new TypeOne(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.TypeOne/typeOnes/{typeOneName}
        /// Operation Id: Common_GetTypeOne
        /// </summary>
        /// <param name="typeOneName"> The name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="typeOneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="typeOneName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string typeOneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(typeOneName, nameof(typeOneName));

            using var scope = _typeOneCommonClientDiagnostics.CreateScope("TypeOneCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(typeOneName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.TypeOne/typeOnes/{typeOneName}
        /// Operation Id: Common_GetTypeOne
        /// </summary>
        /// <param name="typeOneName"> The name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="typeOneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="typeOneName"/> is null. </exception>
        public virtual Response<bool> Exists(string typeOneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(typeOneName, nameof(typeOneName));

            using var scope = _typeOneCommonClientDiagnostics.CreateScope("TypeOneCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(typeOneName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.TypeOne/typeOnes/{typeOneName}
        /// Operation Id: Common_GetTypeOne
        /// </summary>
        /// <param name="typeOneName"> The name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="typeOneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="typeOneName"/> is null. </exception>
        public virtual async Task<Response<TypeOne>> GetIfExistsAsync(string typeOneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(typeOneName, nameof(typeOneName));

            using var scope = _typeOneCommonClientDiagnostics.CreateScope("TypeOneCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _typeOneCommonRestClient.GetTypeOneAsync(Id.SubscriptionId, Id.ResourceGroupName, typeOneName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<TypeOne>(null, response.GetRawResponse());
                return Response.FromValue(new TypeOne(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.TypeOne/typeOnes/{typeOneName}
        /// Operation Id: Common_GetTypeOne
        /// </summary>
        /// <param name="typeOneName"> The name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="typeOneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="typeOneName"/> is null. </exception>
        public virtual Response<TypeOne> GetIfExists(string typeOneName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(typeOneName, nameof(typeOneName));

            using var scope = _typeOneCommonClientDiagnostics.CreateScope("TypeOneCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _typeOneCommonRestClient.GetTypeOne(Id.SubscriptionId, Id.ResourceGroupName, typeOneName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<TypeOne>(null, response.GetRawResponse());
                return Response.FromValue(new TypeOne(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<TypeOne> IEnumerable<TypeOne>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<TypeOne> IAsyncEnumerable<TypeOne>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
