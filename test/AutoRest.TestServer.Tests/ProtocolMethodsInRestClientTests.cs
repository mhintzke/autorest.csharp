﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Linq;
using Azure;
using NUnit.Framework;
using ProtocolMethodsInRestClient;

namespace AutoRest.TestServer.Tests
{
    internal class ProtocolMethodsInRestClientTests
    {
        [TestCase("Create", typeof(TestServiceRestClient))]
        [TestCase("CreateAsync", typeof(TestServiceRestClient))]
        [TestCase("Delete", typeof(TestServiceRestClient))]
        [TestCase("DeleteAsync", typeof(TestServiceRestClient))]

        [TestCase("Create", typeof(FirstTemplateRestClient))]
        [TestCase("CreateAsync", typeof(FirstTemplateRestClient))]
        [TestCase("Get", typeof(FirstTemplateRestClient))]
        [TestCase("GetAsync", typeof(FirstTemplateRestClient))]

        [TestCase("Get", typeof(SecondTemplateRestClient))]
        [TestCase("GetAsync", typeof(SecondTemplateRestClient))]
        public void ProtocolMethodGeneratedInRestClient(string methodName, Type clientType)
        {
            var methods = clientType.GetMethods();
            Assert.IsNotNull(methods);

            var restClientMethods = methods.Where(m => m.Name.Equals(methodName));
            Assert.AreEqual(2, restClientMethods.Count());

            var isProtocolMethodExists = false;
            foreach (var method in restClientMethods)
            {
                if (method.GetParameters().Any(p => p.ParameterType.Equals(typeof(RequestContext))))
                {
                    isProtocolMethodExists = true;
                }
            }

            Assert.IsTrue(isProtocolMethodExists);
        }

        [TestCase("Get", typeof(TestServiceRestClient))]
        [TestCase("GetAsync", typeof(TestServiceRestClient))]

        [TestCase("Delete", typeof(FirstTemplateRestClient))]
        [TestCase("DeleteAsync", typeof(FirstTemplateRestClient))]

        [TestCase("Create", typeof(SecondTemplateRestClient))]
        [TestCase("CreateAsync", typeof(SecondTemplateRestClient))]
        [TestCase("Delete", typeof(SecondTemplateRestClient))]
        [TestCase("DeleteAsync", typeof(SecondTemplateRestClient))]
        public void ProtocolMethodNotGeneratedInRestClient(string methodName, Type clientType)
        {
            var methods = clientType.GetMethods();
            Assert.IsNotNull(methods);

            var restClientMethods = methods.Where(m => m.Name.Equals(methodName));
            Assert.AreEqual(1, restClientMethods.Count());
            var parameters = restClientMethods.FirstOrDefault().GetParameters();
            Assert.IsFalse(parameters.Any(p => p.GetType().Equals(typeof(RequestContext))));
        }

    }
}
