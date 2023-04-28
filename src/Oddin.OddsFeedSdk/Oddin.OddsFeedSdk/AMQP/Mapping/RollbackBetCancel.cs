﻿using Oddin.OddsFeedSdk.AMQP.Enums;
using Oddin.OddsFeedSdk.AMQP.Mapping.Abstractions;
using Oddin.OddsFeedSdk.API.Entities.Abstractions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Oddin.OddsFeedSdk.AMQP.Mapping
{
    internal class RollbackBetCancel<T> : MarketMessage<IMarket, T>, IRollbackBetCancel<T> where T : ISportEvent
    {
        public IEnumerable<IMarket> Markets { get; }

        public RollbackBetCancel(
            IMessageTimestamp timestamp,
            IProducer producer,
            T @event,
            long? requestId,
            IEnumerable<IMarket> markets,
            byte[] rawMessage)
            : base(producer, timestamp, @event, requestId, rawMessage, markets)
        {
            Markets =  markets is null ? null : new ReadOnlyCollection<IMarket>(markets.ToList());
        }
    }
}