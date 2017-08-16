using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.DependencyInjection
{
    public class Operation
    {
        IErrorLogger logger = new FileLogger();
        public void Division()
        {
            try
            {
                int firstNumber = 15, secondNumber = 0, result;
                result = firstNumber / secondNumber;
                Console.WriteLine("Result is :{0}", result);
            }
            catch (DivideByZeroException ex)
            {
                logger.LogMessage(ex);
            }
        }
    }
}