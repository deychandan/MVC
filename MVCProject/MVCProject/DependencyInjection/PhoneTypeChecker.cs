using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.DependencyInjection
{
    enum MANUFACTURERS
    {
        SAMSUNG,
        HTC,
        NOKIA
    }

    class PhoneTypeChecker
    {
        ISmart sam;
        IFeature htc;
        IPhoneFactory factory;
        MANUFACTURERS manu;

        public PhoneTypeChecker(MANUFACTURERS m)
        {
            manu = m;
        }

        public IPhoneFactory CheckProducts()
        {
            switch (manu)
            {
                case MANUFACTURERS.SAMSUNG:
                    factory = new SamsungFactory();
                    break;
                case MANUFACTURERS.HTC:
                    factory = new HTCFactory();
                    break;
                case MANUFACTURERS.NOKIA:
                    factory = new NokiaFactory();
                    break;
            }

            //Console.WriteLine(manu.ToString() + ":\nSmart Phone: " +
            //factory.GetSmart().Name() + "\nDumb Phone: " + factory.GetFeature().Name());
            return factory;
        }
    }
}