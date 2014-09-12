using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sandbox.WCF.Server
{
    public static class Calculator
    {
        public static Task<IEnumerable<decimal>> Operate(decimal val1, decimal val2)
        {
            var response = Task.Run(() =>
                {
                    var divisionResult = Decimal.Divide(val1, val2);
                    var multiplicationResult = Decimal.Multiply(val1, val2);

                    IEnumerable<decimal> result = new List<decimal> {divisionResult, multiplicationResult};

                    return result;
                });


            return response;
        }
    }
}