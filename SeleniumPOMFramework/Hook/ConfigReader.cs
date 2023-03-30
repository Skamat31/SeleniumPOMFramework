using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using SeleniumPOMFramework.Source.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Microsoft.Extensions.Configuration;

namespace SeleniumPOMFramework.Hook
{
    public class ConfigReader
    {
        static ConfigSetting config;
        static string cofigsettingpath = System.IO.Directory.GetParent(@"../../../").FullName
            + Path.DirectorySeparatorChar + "ConfigFiles/Config.json";
        

        [BeforeTestRun]

        public void readConfig()
        {
            config = new ConfigSetting();
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(cofigsettingpath);
            IConfiguration configuration = builder.Build();
            configuration.Bind(config);
        }

    }
}
