﻿// Copyright (c) André N. Klingsheim. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Web;
using Moq;
using NUnit.Framework;
using NWebsec.Core.HttpHeaders.Configuration;
using NWebsec.HttpHeaders;
using NWebsec.Mvc.Helpers;

namespace NWebsec.Mvc.Tests.Unit.Helpers
{
    [TestFixture]
    public class HttpHeaderConfigurationOverrideHelperTests
    {
        private HttpContextBase _mockContext;
        private HttpHeaderConfigurationOverrideHelper _headerConfigurationOverrideHelper;

        [SetUp]
        public void Setup()
        {
            var mockedContext = new Mock<HttpContextBase>();
            IDictionary<String, Object> nwebsecContentItems = new Dictionary<string, object>();
            mockedContext.Setup(x => x.Items["nwebsecheaderoverride"]).Returns(nwebsecContentItems);
            _mockContext = mockedContext.Object;
            _headerConfigurationOverrideHelper = new HttpHeaderConfigurationOverrideHelper();
        }

        [Test]
        public void GetNoCacheHeadersWithOverride_NoOverride_ReturnsNull()
        {
            Assert.IsNull(_headerConfigurationOverrideHelper.GetNoCacheHeadersWithOverride(_mockContext));
        }

        [Test]
        public void GetNoCacheHeadersWithOverride_ConfigOverriden_ReturnsOverrideElement()
        {
            var configOverride = new SimpleBooleanConfiguration { Enabled = true };

            _headerConfigurationOverrideHelper.SetNoCacheHeadersOverride(_mockContext, configOverride);

            Assert.AreSame(configOverride, _headerConfigurationOverrideHelper.GetNoCacheHeadersWithOverride(_mockContext));
        }
        
        [Test]
        public void GetXFrameoptionsWithOverride_NoOverride_ReturnsNull()
        {
            Assert.IsNull(_headerConfigurationOverrideHelper.GetXFrameoptionsWithOverride(_mockContext));
        }

        [Test]
        public void GetXFrameoptionsWithOverride_ConfigOverriden_ReturnsOverrideElement()
        {
            var configOverride = new XFrameOptionsConfiguration { Policy = XFrameOptionsPolicy.Deny };

            _headerConfigurationOverrideHelper.SetXFrameoptionsOverride(_mockContext, configOverride);

            Assert.AreSame(configOverride, _headerConfigurationOverrideHelper.GetXFrameoptionsWithOverride(_mockContext));
        }

        [Test]
        public void GetXContentTypeOptionsWithOverride_NoOverride_ReturnsNull()
        {
            Assert.IsNull(_headerConfigurationOverrideHelper.GetXContentTypeOptionsWithOverride(_mockContext));
        }

        [Test]
        public void GetXContentTypeOptionsWithOverride_ConfigOverriden_ReturnsOverrideElement()
        {
            var configOverride = new SimpleBooleanConfiguration { Enabled = true };

            _headerConfigurationOverrideHelper.SetXContentTypeOptionsOverride(_mockContext, configOverride);

            Assert.AreSame(configOverride, _headerConfigurationOverrideHelper.GetXContentTypeOptionsWithOverride(_mockContext));
        }

        [Test]
        public void GetXDownloadOptionsWithOverride_NoOverride_ReturnsNull()
        {
            Assert.IsNull(_headerConfigurationOverrideHelper.GetXDownloadOptionsWithOverride(_mockContext));
        }

        [Test]
        public void GetXDownloadOptionsWithOverride_ConfigOverriden_ReturnsOverrideElement()
        {
            var configOverride = new SimpleBooleanConfiguration { Enabled = true };

            _headerConfigurationOverrideHelper.SetXDownloadOptionsOverride(_mockContext, configOverride);

            Assert.AreSame(configOverride, _headerConfigurationOverrideHelper.GetXDownloadOptionsWithOverride(_mockContext));
        }

        [Test]
        public void GetXXssProtectionWithOverride_NoOverride_ReturnsNull()
        {
            Assert.IsNull(_headerConfigurationOverrideHelper.GetXXssProtectionWithOverride(_mockContext));
        }

        [Test]
        public void GetXXssProtectionWithOverride_ConfigOverriden_ReturnsOverrideElement()
        {
            var configOverride = new XXssProtectionConfiguration { Policy = XXssProtectionPolicy.FilterEnabled };

            _headerConfigurationOverrideHelper.SetXXssProtectionOverride(_mockContext, configOverride);

            Assert.AreSame(configOverride, _headerConfigurationOverrideHelper.GetXXssProtectionWithOverride(_mockContext));
        }

        [Test]
        public void GetXRobotsTagWithOverride_NoOverride_ReturnsNull()
        {
            Assert.IsNull(_headerConfigurationOverrideHelper.GetXRobotsTagWithOverride(_mockContext));
        }

        [Test]
        public void GetXRobotsTagWithOverride_ConfigOverriden_ReturnsOverrideElement()
        {
            var configOverride = new XRobotsTagConfiguration { Enabled = true, NoIndex = true };

            _headerConfigurationOverrideHelper.SetXRobotsTagHeaderOverride(_mockContext, configOverride);

            Assert.AreSame(configOverride, _headerConfigurationOverrideHelper.GetXRobotsTagWithOverride(_mockContext));
        }
    }
}
