using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class AppSetting
    {
        public testConfig testConfig { get; set; }
    }
    public class testConfig
    {
        public string key { get; set; }
        public string value { get; set; }
    }
}
