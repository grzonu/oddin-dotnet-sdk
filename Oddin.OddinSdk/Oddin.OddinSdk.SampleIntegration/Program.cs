﻿using Microsoft.Extensions.Logging;
using Oddin.Oddin.SDK;
using Oddin.OddinSdk.SampleIntegration;
using Serilog;
using System;

namespace Oddin.Oddin.SampleIntegration
{
    class Program
    {
        static void Main(string[] args)
        {
            var serilogLogger = new LoggerConfiguration()
                .WriteTo
                .Console()
                .CreateLogger();

            var loggerFactory = new LoggerFactory().AddSerilog(serilogLogger);

            var config = new CustomOddsFeedConfiguration(
                accessToken: "1a0c5a30-74ed-416d-b120-8c05f92e382f",
                apiHost: "api-mq.integration.oddin.gg",
                useApiSsl: true,
                httpClientTimeout: 10,
                host: "mq.integration.oddin.gg",
                port: 5672);

            var feed = new Feed(config, loggerFactory);
            foreach (var producer in feed.ProducerManager.Producers)
                Console.WriteLine(producer.Name);
        }
    }
}
