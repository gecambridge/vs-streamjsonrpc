﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace StreamJsonRpc
{
    using System;

    /// <summary>
    /// An exception thrown when a deserialized message has a bad header.
    /// </summary>
    /// <seealso cref="RemoteRpcException" />
#if NET45
    [Serializable]
#endif
    public class BadRpcHeaderException : RemoteRpcException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BadRpcHeaderException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        internal BadRpcHeaderException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BadRpcHeaderException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="innerException">The inner exception.</param>
        internal BadRpcHeaderException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

#if NET45
        /// <summary>
        /// Initializes a new instance of the <see cref="BadRpcHeaderException"/> class.
        /// </summary>
        /// <param name="info">Serialization info.</param>
        /// <param name="context">Streaming context.</param>
        protected BadRpcHeaderException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
#endif
    }
}
