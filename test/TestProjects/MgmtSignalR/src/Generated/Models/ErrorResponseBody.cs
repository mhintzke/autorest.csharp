// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace MgmtSignalR.Models
{
    /// <summary> Describes a particular API error with an error code and a message. </summary>
    internal partial class ErrorResponseBody
    {
        /// <summary> Initializes a new instance of ErrorResponseBody. </summary>
        /// <param name="code">
        /// An error code that describes the error condition more precisely than an HTTP status code. 
        /// Can be used to programmatically handle specific error cases.
        /// </param>
        /// <param name="message"> A message that describes the error in detail and provides debugging information. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="code"/> or <paramref name="message"/> is null. </exception>
        internal ErrorResponseBody(string code, string message)
        {
            if (code == null)
            {
                throw new ArgumentNullException(nameof(code));
            }
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            Code = code;
            Message = message;
            Details = new ChangeTrackingList<ErrorResponseBody>();
        }

        /// <summary> Initializes a new instance of ErrorResponseBody. </summary>
        /// <param name="code">
        /// An error code that describes the error condition more precisely than an HTTP status code. 
        /// Can be used to programmatically handle specific error cases.
        /// </param>
        /// <param name="message"> A message that describes the error in detail and provides debugging information. </param>
        /// <param name="target"> The target of the particular error (for example, the name of the property in error). </param>
        /// <param name="details"> Contains nested errors that are related to this error. </param>
        internal ErrorResponseBody(string code, string message, string target, IReadOnlyList<ErrorResponseBody> details)
        {
            Code = code;
            Message = message;
            Target = target;
            Details = details;
        }

        /// <summary>
        /// An error code that describes the error condition more precisely than an HTTP status code. 
        /// Can be used to programmatically handle specific error cases.
        /// </summary>
        public string Code { get; }
        /// <summary> A message that describes the error in detail and provides debugging information. </summary>
        public string Message { get; }
        /// <summary> The target of the particular error (for example, the name of the property in error). </summary>
        public string Target { get; }
        /// <summary> Contains nested errors that are related to this error. </summary>
        public IReadOnlyList<ErrorResponseBody> Details { get; }
    }
}
