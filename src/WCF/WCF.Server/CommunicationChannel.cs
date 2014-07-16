using System;
using WCF.Common;

namespace WCF.Server
{
    public class CommunicationChannel : ICommunicationChannel
    {
        public decimal Add(int val1, int val2)
        {
            return Decimal.Add(val1, val2);
        }

        public decimal Divide(int numerator, int denominator)
        {
            return Decimal.Divide(numerator, denominator);
        }
    }
}