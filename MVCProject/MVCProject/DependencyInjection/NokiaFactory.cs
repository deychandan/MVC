using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.DependencyInjection
{
    class NokiaFactory : IPhoneFactory
    {
        public IFeature GetFeature()
        {
            return new Asha();
        }

        public ISmart GetSmart()
        {
            return new Lumia();
        }

    }
}