using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdobeConnectTool
{
    /// 
    /// The AsyncTracker class moniters when a group of 
    /// asynchronous processes have been completed.
    /// 
    public static class AsyncTracker
    {
        private static int _counter = 0;
        private static int _total = 0;

        /// 
        /// SET THE TOTAL NUMBER OF CALLS THAT WILL BE MADE
        /// 
        public static void SetEvents(int number)
        {
            _total = number;
        }

        /// 
        /// INCREMENT THE COUNTER WHEN A THREAD IS COMPLETE
        /// 
        public static void EventDone()
        {
            _counter++;
        }

        /// 
        /// CONTINUE LOOPING WHILE THE COUNTER IS NOT FINISHED
        /// 
        public static void ProceedWhenAllEventsAreComplete()
        {
            while (_counter != _total)
            {
                Thread.Sleep(10);
            }
        }

        /// 
        /// SET THE COUNTER TO 0
        /// 
        public static void ResetTracker()
        {
            _counter = 0;
        }
    }
}
