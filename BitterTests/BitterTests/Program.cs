using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Security.Policy;
using Bogus;
using MySql.Data.MySqlClient;





namespace BitterTests
{
    internal class Program
    {
        private static MySqlConnection connection;
        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver(@"C:\Selenium");

            driver.Manage().Window.Maximize();


            bool Test001 = SiteTest.Test001(driver);

            if (Test001)
            {
                Console.WriteLine("Test001 : Passed!");
            }
            else
            {
                Console.WriteLine("Test001 : Failed!");
            }

            bool Test002 = SiteTest.Test002(driver);

            if (Test002)
            {
                Console.WriteLine("Test002 : Passed!");
            }
            else
            {
                Console.WriteLine("Test002 : Failed!");
            }
            bool Test003 = SiteTest.Test003(driver);

            if (Test003)
            {
                Console.WriteLine("Test003 : Passed!");
            }
            else
            {
                Console.WriteLine("Test003 : Failed!");
            }

            bool Test004 = SiteTest.Test004(driver);

            if (Test004)
            {
                Console.WriteLine("Test004 : Passed!");
            }
            else
            {
                Console.WriteLine("Test004 : Failed!");
            }

            bool Test005 = SiteTest.Test005(driver);

            if (Test005)
            {
                Console.WriteLine("Test005 : Passed!");
            }
            else
            {
                Console.WriteLine("Test005 : Failed!");
            }
        }

    }
}
