using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.DependencyInjection
{
    public class Titan : ISmart
    {
        public string Name()
        {
            return "Titan";
        }
    }
}