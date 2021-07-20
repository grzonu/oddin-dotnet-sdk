﻿using Oddin.OddsFeedSdk.AMQP.Mapping.Abstractions;
using Oddin.OddsFeedSdk.API.Abstractions;
using System.Globalization;
using System.Threading.Tasks;

namespace Oddin.OddsFeedSdk.AMQP.Mapping
{
    internal class Outcome : IOutcome
    {
        private readonly IApiClient _apiClient;

        public string Id { get; }

        public Outcome(string id, IApiClient apiClient)
        {
            Id = id;
            _apiClient = apiClient;
        }

        public async Task<string> GetNameAsync(CultureInfo culture)
        {
            var marketDescriptions = await _apiClient.GetMarketDescriptionsAsync(culture);

            foreach (var marketDescription in marketDescriptions)
                foreach (var outcomeDescription in marketDescription.Outcomes)
                    if (outcomeDescription.Id == Id)
                        return outcomeDescription.Name;

            return null;
        }
    }
}