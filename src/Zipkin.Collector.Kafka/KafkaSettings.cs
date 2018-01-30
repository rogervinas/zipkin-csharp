//-----------------------------------------------------------------------
// <copyright file="KafkaSettings.cs" company="Bazinga Technologies Inc.">
//     Copyright (C) 2016 Bazinga Technologies Inc.
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Linq;

namespace Zipkin.Tracer.Kafka
{
    [Serializable]
    public sealed class KafkaSettings
    {
        public static KafkaSettings Default() {
            return new KafkaSettings("zipkin", 20, 1000, new []{ "http://localhost:9092" });
        }

        public static KafkaSettings Create(params Uri[] serverUris) {
            return new KafkaSettings("zipkin", 20, 1000, serverUris.Select(x => x.ToString()).ToArray());
        }

        public KafkaSettings(string zipkinTopic, int maxAsyncRequests, int maxMessageBuffer, string[] serverUris)
        {
            ZipkinTopic = zipkinTopic;
            ServerUris = serverUris;
            MaxAsyncRequests = maxAsyncRequests;
            MaxMessageBuffer = maxMessageBuffer;
        }

        public string[] ServerUris { get; set; }
        public int MaxAsyncRequests { get; set; }
        public int MaxMessageBuffer { get; set;  }
        public string ZipkinTopic { get; set;  }
    }
}