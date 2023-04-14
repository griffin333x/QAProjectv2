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
            //SiteReset();
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

            bool Test006 = SiteTest.Test006(driver);

            if (Test006)
            {
                Console.WriteLine("Test006 : Passed!");
            }
            else
            {
                Console.WriteLine("Test006 : Failed!");
            }

            bool Test007 = SiteTest.Test007(driver);

            if (Test007)
            {
                Console.WriteLine("Test007 : Passed!");
            }
            else
            {
                Console.WriteLine("Test007 : Failed!");
            }

            bool Test008 = SiteTest.Test008(driver);
            
            if (Test008)
            {
                Console.WriteLine("Test008 : Passed!");
            }
            else
            {
                Console.WriteLine("Test008 : Failed!");
            }

            bool Test009 = SiteTest.Test009(driver);

            if (Test009)
            {
                Console.WriteLine("Test009 : Passed!");
            }
            else
            {
                Console.WriteLine("Test009 : Failed!");
            }

            bool Test010 = SiteTest.Test010(driver);

            if (Test010)
            {
                Console.WriteLine("Test010 : Passed!");
            }
            else
            {
                Console.WriteLine("Test010 : Failed!");
            }

            bool Test011 = SiteTest.Test011(driver);

            if (Test011)
            {
                Console.WriteLine("Test011 : Passed!");
            }
            else
            {
                Console.WriteLine("Test011 : Failed!");
            }

            bool Test012 = SiteTest.Test012(driver);

            if (Test012)
            {
                Console.WriteLine("Test012 : Passed!");
            }
            else
            {
                Console.WriteLine("Test012 : Failed!");
            }
        }

        public static void SiteReset()
        {
            string myConnectionString = "server=10.157.123.12;database=bitter-site7;uid=site7;pwd=aQ7zlR0dpbTsTqns;";
            connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = new MySqlCommand();

            command.Connection = connection;
            command.CommandText = "reset";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }


    }
}
