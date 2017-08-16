using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject.DependencyInjection
{
    interface IErrorLogger
    {
        void LogMessage(Exception ex);
    }
}
