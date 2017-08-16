using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.DependencyInjection
{
    public class Lumia : ISmart
    {
        public string Name()
        {
            return "Lumia";
        }
    }
}