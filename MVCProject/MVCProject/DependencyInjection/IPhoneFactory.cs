using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCProject.DependencyInjection
{
    interface IPhoneFactory
    {
        IFeature GetFeature();
        ISmart GetSmart();
    }
}
