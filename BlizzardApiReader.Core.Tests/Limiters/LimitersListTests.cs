using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlizzardApiReader.Core.Tests
{
    [TestClass]
    public class LimitersListTests
    {
        [TestMethod]
        public void AddRemoveCases()
        {
            var limiter1 = new TimeRateLimiter(TimeSpan.FromSeconds(10), 5);
            var limiter2 = new TimeRateLimiter(TimeSpan.FromMinutes(1), 5);
            var limiters = new LimitersList();
            limiters.Clear();
            limiters.Add(limiter1);
            Action failedRemove = () => limiters.Remove(limiter2);
            failedRemove.Should().Throw<KeyNotFoundException>();
            Action successfulRemove = () => limiters.Remove(limiter1);
            successfulRemove.Should().NotThrow();
        }

        [TestMethod]
        public void AnyReachedLimit_ShouldFalse()
        {
            var limiter1 = new TimeRateLimiter(TimeSpan.FromSeconds(10), 5);
            var limiter2 = new TimeRateLimiter(TimeSpan.FromMinutes(1), 5);
            var limiters = new LimitersList();
            limiters.Add(limiter1);
            limiters.Add(limiter2);
            limiters.AnyReachedLimit().Should().BeFalse();
        }

        [TestMethod]
        public void AnyReachedLimit_ShouldTrueZeroAllowed()
        {
            var limiter1 = new TimeRateLimiter(TimeSpan.FromSeconds(10), 0);
            var limiters = new LimitersList();
            limiters.Add(limiter1);
            limiters.AnyReachedLimit().Should().BeTrue();
        }
        
        [TestMethod]
        public void AnyReachedLimit_ShouldTrueRealLimit()
        {
            var limiter1 = new TimeRateLimiter(TimeSpan.FromSeconds(10), 5);
            var limiter2 = new TimeRateLimiter(TimeSpan.FromMinutes(1), 5);
            var limiters = new LimitersList();
            limiters.Add(limiter1);
            limiters.Add(limiter2);
            for (int i = 0; i < 10; ++i)
            {
                limiters.NotifyAll(null, null);
            }
            limiters.AnyReachedLimit().Should().BeTrue();
        }
    }
}
