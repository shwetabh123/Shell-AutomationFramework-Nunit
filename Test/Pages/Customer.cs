using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Base;
using Test.Helpers;

namespace Test.Pages
{
   public class Customer
    {
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement selectColco { get; set; }

        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement Start { get; set; }

        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement Customers { get; set; }


        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement CreatetopLevelCustomer { get; set; }

        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement LineOfBusiness { get; set; }

        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement FullName { get; set; }

        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement ShortName { get; set; }

        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement TradingName { get; set; }
        public Customer()
        {
            PageFactory.InitElements(DriverContext.Driver,this);
        }
        public void selectcolco(string colconame)
        {
        }

        public string CreateCustomerDetails(string colconame,int i ,string lineofbusiness,string band)
        {

            string customerERP = "";
            string pth = AppDomain.CurrentDomain.BaseDirectory;
            Actions action = new Actions(DriverContext.Driver);



            IReadOnlyCollection<string> all_windowHandles = DriverContext.Driver.WindowHandles;

            foreach(string handle in all_windowHandles)
            {

                if(DriverContext.Driver.Title.Contains(colconame))
                {
                    string fileName = @"";
                    ExcelHelper eat = new ExcelHelper(fileName);

                    BrowserHelper.BrowserMaximize();
                    action.MoveToElement(Start).Build().Perform();

                    action.MoveToElement(Customers).Build().Perform();
                    action.MoveToElement(CreatetopLevelCustomer).Click().Build().Perform();

                    ComboBoxHelper.SelectInDropDownByText(LineOfBusiness,lineofbusiness);

                    string randomnumber = RandomNumberandStringGenerator.randomnumberwithoneargument(6);


                    string fullname = "Automation" + randomnumber;

                    TextBoxHelper.ClearandTypeinTextBox(FullName,fullname);

                    TextBoxHelper.ClearandTypeinTextBox(ShortName, fullname);

                    TextBoxHelper.ClearandTypeinTextBox(TradingName, fullname);

                }

            }
            return customerERP;

        }





    }
}
