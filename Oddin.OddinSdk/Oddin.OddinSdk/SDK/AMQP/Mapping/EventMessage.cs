﻿using Oddin.OddinSdk.SDK.AMQP.Abstractions;
using Oddin.OddinSdk.SDK.API.Entities.Abstractions;

namespace Oddin.OddinSdk.SDK.AMQP.Mapping
{
    internal abstract class EventMessage<T> : Message, IEventMessage<T> where T : ISportEvent
    {
        public T Event { get; }

        public long? RequestId { get; }

        public byte[] RawMessage { get; }

        protected EventMessage(IProducer producer, IMessageTimestamp messageTimestamp, T sportEvent, long? requestId, byte[] rawMessage)
            : base(producer, messageTimestamp)
        {
            Event = sportEvent;
            RequestId = requestId;
            RawMessage = rawMessage;
        }
    }
}