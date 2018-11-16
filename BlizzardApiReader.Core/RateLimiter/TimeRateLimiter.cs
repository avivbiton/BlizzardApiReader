using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlizzardApiReader.Core
{
    public class TimeRateLimiter : IRateLimiter
    {
        /*
         * 
         * This class is completely un-tested, need testing asap.
         * 
         * */



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
            calculateAndSetNextReset();

        }

        public bool IsAtRateLimit()
        {
            if (isReadyToReset())
                resetLimiter();

            return currentRateCounter >= RatesPerTimespan;
        }

        public void OnHttpRequest(ApiReader reader, IApiResponse responseMessage)
        {
            if (isReadyToReset())
                resetLimiter();

            currentRateCounter++;
        }

        /// <summary>
        ///  Calculate the next time the limiter reset and set it
        /// </summary>
        private void calculateAndSetNextReset()
        {
            timeUntilTheNextReset = DateTime.Now.Add(TimeBetweenLimitReset);
        }

        private bool isReadyToReset()
        {
            return DateTime.Now >= timeUntilTheNextReset;
        }

        private void resetLimiter()
        {
            currentRateCounter = 0;
            calculateAndSetNextReset();
        }
    }
}