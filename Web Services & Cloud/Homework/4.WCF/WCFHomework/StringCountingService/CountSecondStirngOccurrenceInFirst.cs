using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace StringCountingService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CountSecondStirngOccurrenceInFirst" in both code and config file together.
    public class CountSecondStirngOccurrenceInFirst : ICountSecondStirngOccurrenceInFirst
    {
        public int CountSecondStirngOccurrenceInFirstt(string first, string second)
        {
            int index = second.IndexOf(first);
            int count = 0;

            while (index == -1)
            {
                count++;
                index = second.IndexOf(first, index + 1);
            }

            return count;
        }
    }
}
