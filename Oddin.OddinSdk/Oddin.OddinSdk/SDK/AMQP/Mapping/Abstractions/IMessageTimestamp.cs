﻿namespace Oddin.OddinSdk.SDK.AMQP.Abstractions
{
    /// <summary>
    /// Defines a contract for all message timestamps
    /// </summary>
    /// <remarks>Created and Sent are generated on rabbit server and Received and Dispatched on a local machine running sdk. If the system clocks are not in-sync it may happen that Received is before Created. Similar logic applies also to other properties.</remarks>
    public interface IMessageTimestamp
    {
        /// <summary>
        /// Gets the value specifying when the message was generated and put in queue on rabbit server (milliseconds since EPOCH UTC)
        /// </summary>
        long Created { get; }

        /// <summary>
        /// Gets the value specifying when the message was sent from the rabbit server (milliseconds since EPOCH UTC)
        /// </summary>
        long Sent { get; }

        /// <summary>
        /// Gets the value specifying when the message was received for processing by the sdk (milliseconds since EPOCH UTC)
        /// </summary>
        long Received { get; }

        /// <summary>
        /// Gets the value specifying when the message was dispatched to the user from the sdk (milliseconds since EPOCH UTC)
        /// </summary>
        long Dispatched { get; }
    }
}