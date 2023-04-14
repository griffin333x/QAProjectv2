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

            bool Test013 = SiteTest.Test013(driver);

            if (Test013)
            {
                Console.WriteLine("Test013 : Passed!");
            }
            else
            {
                Console.WriteLine("Test013 : Failed!");
            }

            bool Test014 = SiteTest.Test014(driver);

            if (Test014)
            {
                Console.WriteLine("Test014 : Passed!");
            }
            else
            {
                Console.WriteLine("Test014 : Failed!");
            }

            bool Test015 = SiteTest.Test015(driver);

            if (Test015)
            {
                Console.WriteLine("Test015 : Passed!");
            }
            else
            {
                Console.WriteLine("Test015 : Failed!");
            }

            bool Test016 = SiteTest.Test016(driver);

            if (Test016)
            {
                Console.WriteLine("Test016 : Passed!");
            }
            else
            {
                Console.WriteLine("Test016 : Failed!");
            }

            bool Test017 = SiteTest.Test017(driver);

            if (Test017)
            {
                Console.WriteLine("Test017 : Passed!");
            }
            else
            {
                Console.WriteLine("Test017 : Failed!");
            }

            bool Test018 = SiteTest.Test018(driver);

            if (Test018)
            {
                Console.WriteLine("Test018 : Passed!");
            }
            else
            {
                Console.WriteLine("Test018 : Failed!");
            }

            bool Test019 = SiteTest.Test019(driver);

            if (Test019)
            {
                Console.WriteLine("Test019 : Passed!");
            }
            else
            {
                Console.WriteLine("Test019 : Failed!");
            }

            //bool Test020 = SiteTest.Test020(driver);

            //if (Test020)
            //{
            //    Console.WriteLine("Test020 : Passed!");
            //}
            //else
            //{
            //    Console.WriteLine("Test020 : Failed!");
            //}
            bool Test021 = SiteTest.Test021(driver);

            if (Test021)
            {
                Console.WriteLine("Test021 : Passed!");
            }
            else
            {
                Console.WriteLine("Test021 : Failed!");
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
