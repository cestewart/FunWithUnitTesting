using System;
using System.Configuration;

namespace FunWithUnitTesting
{
    public class FunWithUnitTestingConfiguration : IFunWithUnitTestingConfiguration
    {
        public int RunTimes => Convert.ToInt32(ConfigurationManager.AppSettings.Get("RunTimes"));
    }
}
