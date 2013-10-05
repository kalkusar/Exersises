using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;
using log4net;
using log4net.Config;

namespace Log4NETTest
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            var fi = new FileInfo("..\\..\\Config\\Log4NETConfig.xml");
            XmlConfigurator.Configure(fi);
            log.Info("Test log.");
            log.Debug("Test dbg log.");
        }
    }
}
