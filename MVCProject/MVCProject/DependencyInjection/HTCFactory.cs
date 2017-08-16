using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.DependencyInjection
{
    class HTCFactory : IPhoneFactory
    {
        public IFeature GetFeature()
        {
            return new Genie();
        }

        public ISmart GetSmart()
        {
            return new Titan();
        }
    }
}