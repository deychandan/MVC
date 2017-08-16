using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.DependencyInjection
{
    class SamsungFactory : IPhoneFactory
    {
        public IFeature GetFeature()
        {
            return new Primo();
        }

        public ISmart GetSmart()
        {
            return new GalaxyS2();
        }

    }
}