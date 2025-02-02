// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtKeyvault.Models
{
    /// <summary> The server error. </summary>
    internal partial class Error
    {
        /// <summary> Initializes a new instance of Error. </summary>
        internal Error()
        {
        }

        /// <summary> Initializes a new instance of Error. </summary>
        /// <param name="code"> The error code. </param>
        /// <param name="message"> The error message. </param>
        /// <param name="innerError"> The inner error, contains a more specific error code. </param>
        internal Error(string code, string message, Error innerError)
        {
            Code = code;
            Message = message;
            InnerError = innerError;
        }

        /// <summary> The error code. </summary>
        public string Code { get; }
        /// <summary> The error message. </summary>
        public string Message { get; }
        /// <summary> The inner error, contains a more specific error code. </summary>
        public Error InnerError { get; }
    }
}
