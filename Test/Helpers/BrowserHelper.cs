using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Base;

namespace Test.Helpers
{
    public  class BrowserHelper
    {

        public static void BrowserMaximize()
        {

            DriverContext.Driver.Manage().Window.Maximize();
        }

        public static void GoBack()
        {

            DriverContext.Driver.Navigate().Back();
        }

        public static void Forward()
        {

            DriverContext.Driver.Navigate().Forward();
        }


        public static void RefreshPage()
        {

            DriverContext.Driver.Navigate().Refresh();
        }
    }
}
