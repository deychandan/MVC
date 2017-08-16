using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.DependencyInjection
{
    public class GalaxyS2 : ISmart
    {
        public string Name()
        {
            return "GalaxyS2";
        }
    }
}