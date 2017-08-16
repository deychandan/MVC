using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.DependencyInjection
{
    public class Genie : IFeature
    {
        public string Name()
        {
            return "Genie";
        }
    }
}