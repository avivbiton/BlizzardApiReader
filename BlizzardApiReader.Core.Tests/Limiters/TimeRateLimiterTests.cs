using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlizzardApiReader.Core.Tests
{
    [TestClass]
    public class TimeRateLimiterTests
    {

        private TimeRateLimiter limiter;

        [TestMethod]
        public void RateLimitReached_Test()
        {
            limiter = new TimeRateLimiter(TimeSpan.FromMinutes(1000), 1);
            aFakeRequest();

            limiter.IsAtRateLimit().Should().BeTrue();
        }

        [TestMethod]
        public void RateLimitResetCorrectly_Test()
        {
            limiter = new TimeRateLimiter(TimeSpan.FromMilliseconds(0), 1);
            limiter.IsAtRateLimit().Should().BeFalse();

            aFakeRequest();
            limiter.IsAtRateLimit().Should().BeFalse();

        }

        [TestMethod]
        public void ReachedLimitAfterManyRequests_Test()
        {
            int maxRequests = 100;
            limiter = new TimeRateLimiter(TimeSpan.FromMinutes(1000), maxRequests);
            for (int i = 0; i < maxRequests; i++)
                aFakeRequest();

            limiter.IsAtRateLimit().Should().BeTrue();
        }


        private void aFakeRequest()
        {
            limiter.OnHttpRequest(null, null);
        }
    }
}
