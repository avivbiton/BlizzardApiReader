using System;

namespace BlizzardApiReader.Core
{
    public class TimeRateLimiter : IRateLimiter
    {

        /// <summary>
        /// Time limiters that reset every DateTime, and allow only RatesPerDateTime requests
        /// </summary>

        public int RatesPerTimespan { get; set; }
        public TimeSpan TimeBetweenLimitReset { get; set; }

        private DateTime timeUntilTheNextReset;
        private int currentRateCounter = 0;

        public TimeRateLimiter(TimeSpan timeBetweenReset, int maxRatePerReset)
        {
            TimeBetweenLimitReset = timeBetweenReset;
            RatesPerTimespan = maxRatePerReset;

            currentRateCounter = 0;
            CalculateAndSetNextReset();
        }

        public bool IsAtRateLimit()
        {
            if (isReadyToReset())
                ResetLimiter();

            return currentRateCounter >= RatesPerTimespan;
        }

        public void OnApiRequest(ApiReader reader)
        {
            if (isReadyToReset())
                ResetLimiter();

            currentRateCounter++;
        }

        /// <summary>
        ///  Calculate the next time the limiter reset and set it
        /// </summary>
        private void CalculateAndSetNextReset()
        {
            timeUntilTheNextReset = DateTime.Now.Add(TimeBetweenLimitReset);
        }

        private bool isReadyToReset()
        {
            return DateTime.Now >= timeUntilTheNextReset;
        }

        private void ResetLimiter()
        {
            currentRateCounter = 0;
            CalculateAndSetNextReset();
        }
    }
}
