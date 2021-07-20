﻿using Microsoft.Extensions.Logging;
using Oddin.OddsFeedSdk.Common;
using Oddin.OddsFeedSdk.AMQP.Mapping.Abstractions;
using Oddin.OddsFeedSdk.API.Abstractions;
using Oddin.OddsFeedSdk.Configuration.Abstractions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Oddin.OddsFeedSdk.Exceptions;

namespace Oddin.OddsFeedSdk.AMQP.Mapping
{
    internal class Market : IMarket
    {
        private static readonly ILogger _log = SdkLoggerFactory.GetLogger(typeof(Market));

        private readonly IApiClient _apiClient;
        private readonly ExceptionHandlingStrategy _exceptionHandlingStrategy;

        public int Id { get; }

        public IReadOnlyDictionary<string, string> Specifiers { get; }

        public string ExtendedSpecifiers { get; }

        public Market(int id, IDictionary<string, string> specifiers, string extendedSpecifiers, IApiClient apiClient, ExceptionHandlingStrategy exceptionHandlingStrategy)
        {
            if (specifiers is null)
                throw new ArgumentNullException(nameof(specifiers));

            if (apiClient is null)
                throw new ArgumentNullException(nameof(apiClient));

            Id = id;
            Specifiers = specifiers as IReadOnlyDictionary<string, string>;
            ExtendedSpecifiers = extendedSpecifiers;

            _apiClient = apiClient;
            _exceptionHandlingStrategy = exceptionHandlingStrategy;
        }

        public async Task<string> GetNameAsync(CultureInfo culture)
        {
            try
            {
                var marketDescriptions = await _apiClient.GetMarketDescriptionsAsync(culture);
                return marketDescriptions
                    .Where(m => m.Id == Id)
                    .First()
                    .Name;
            }
            catch (SdkException e)
            {
                e.HandleAccordingToStrategy(GetType().Name, _log, _exceptionHandlingStrategy);
            }
            return null;
        }
    }
}