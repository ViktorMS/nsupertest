﻿using NSuperTest.Client;
using NSuperTest.Client.MockClient;
using NSuperTest.Server;
using System;
using System.Collections.Generic;
using System.Text;

namespace NSuperTest.Registration.MockServer
{
    public class MockServer : IServer
    {
        public string Address { get; }

        public bool UseCamelCase { get; }

        public MockServer(string address, bool useCamelCase)
        {
            Address = address;
            UseCamelCase = useCamelCase;
        }

        public IHttpRequestClient GetClient()
        {
            return new MockClient();
        }
    }
}
