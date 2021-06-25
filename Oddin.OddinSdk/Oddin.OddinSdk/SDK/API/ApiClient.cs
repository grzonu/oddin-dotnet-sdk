﻿using Microsoft.Extensions.Logging;
using Oddin.OddinSdk.Common;
using Oddin.OddinSdk.SDK.API.Abstractions;
using Oddin.OddinSdk.SDK.API.Entities;
using Oddin.OddinSdk.SDK.API.Entities.Abstractions;
using Oddin.OddinSdk.SDK.API.Models;
using Oddin.OddinSdk.SDK.Managers;
using Oddin.OddinSdk.SDK.FeedConfiguration;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Oddin.OddinSdk.SDK.API
{
    internal class ApiClient : IApiClient
    {
        private readonly RestClient _restClient;

        public ApiClient(IOddsFeedConfiguration config, ILoggerFactory loggerFactory)
        {
            _restClient = new RestClient(config, loggerFactory);
        }

        public List<IProducer> GetProducers()
        {
            var response = _restClient.SendRequest<ProducersModel>("v1/descriptions/producers", HttpMethod.Get);

            // TODO: generalize DTO to entity translation
            var result = new List<IProducer>();
            foreach (var producer in response.producer)
                result.Add(new Producer(
                    producer.id,
                    producer.name,
                    producer.description,
                    producer.active,
                    producer.scope,
                    producer.stateful_recovery_window_in_minutes));

            return result;
        }

        public IBookmakerDetails GetBookmakerDetails()
        {
            var response = SendRequest<BookmakerDetailsModel>("v1/users/whoami", HttpMethod.Get);
            
            if (response.Successful == false)
            {
                // TODO
            }

            return new BookmakerDetails(response.Data);
        }
    }
}
