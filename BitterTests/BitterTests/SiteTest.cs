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
using MySql.Data.MySqlClient; //tried getting the connection to work, had trouble with it
using System.Runtime.Remoting.Messaging;

namespace BitterTests
{
    class SiteTest
    {
        public static bool Test001(IWebDriver driver) //LOGIN
        {
            try
            {

                LoginPage(driver, "nick", "asdf");

                Thread.Sleep(1000);

                if (driver.Url.Contains("index.php"))
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch 
            {
                return false;
            }
        }
        public static bool Test002(IWebDriver driver) //SEARCH FUNCTION WITHOUT TEXT
        {
            try
            {
                Thread.Sleep(1000);

                IWebElement search = SiteWebElement.searchButton(driver);

                search.Click();

                if (driver.Url.Contains("search.php"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch 
            {
                return false;
            }
        }
        public static bool Test003(IWebDriver driver) //SEARCH FUNCTION WITH TEXT
        {
            try
            {
                Thread.Sleep(1000);

                IWebElement searchTxt = SiteWebElement.searchTextBox(driver);
                IWebElement searchBtn = SiteWebElement.searchButton(driver);

                searchTxt.Click();
                searchTxt.SendKeys("test");
                searchBtn.Click();
                if (driver.Url.Contains("test"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch 
            {
                return false;
            }
        }

        public static bool Test004(IWebDriver driver) //HOME LINK
        {
            try
            {
                Thread.Sleep(1000);

                IWebElement homeLink = SiteWebElement.homeLink(driver);
                homeLink.Click();

                if (driver.Url.Contains("index.php"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch 
            {
                return false;
            }
        }
        public static bool Test005(IWebDriver driver) //NOTIFICATIONS LINK
        {
            try
            {
                Thread.Sleep(1000);

                IWebElement notificationsLink = SiteWebElement.notificationsLink(driver);

                notificationsLink.Click();

                if (driver.Url.Contains("notifications.php"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            catch 
            {
                return false;
            }
        }
        public static bool Test006(IWebDriver driver) //MESSAGES LINK
        {
            try
            {
                Thread.Sleep(1000);

                IWebElement messagesLink = SiteWebElement.messagesLink(driver);
                messagesLink.Click();

                if (driver.Url.Contains("DirectMessage.php"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch 
            {
                return false;
            }
        }

        public static bool Test007(IWebDriver driver) //CONTACT US LINK
        {
            try
            {
                Thread.Sleep(1000);

                IWebElement contactUsLink = SiteWebElement.contactUsLink(driver);
                contactUsLink.Click();

                if (driver.Url.Contains("contactus"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch 
            {
                return false;
            }
        }

        public static bool Test008(IWebDriver driver) //USERPAGE LINK
        {
            try
            {
                driver.Navigate().GoToUrl("http://10.157.123.12/site7/index.php");

                Thread.Sleep(1000);

                IWebElement userPageLink = SiteWebElement.userPageLink(driver);
                userPageLink.Click();

                if (driver.Url.Contains("userpage.php"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch 
            {
                return false;
            }
        }

        public static bool Test009(IWebDriver driver) //LOGOUT
        {
            try
            {
                Thread.Sleep(1000);

                IWebElement logoutDropdown = SiteWebElement.logoutDropdown(driver);
                logoutDropdown.Click();

                IWebElement logoutButton = SiteWebElement.logoutButton(driver);
                logoutButton.Click();

                if (driver.Url.Contains("login.php"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch 
            {
                return false;
            }
        }

        public static bool Test010(IWebDriver driver) //EDIT PROFILE PIC LINK
        {
            try
            {
                LoginPage(driver, "nick", "asdf");

                Thread.Sleep(1000);

                IWebElement logoutDropdown = SiteWebElement.logoutDropdown(driver);
                logoutDropdown.Click();

                IWebElement editProfilePic = SiteWebElement.editProfilePic(driver);
                editProfilePic.Click();

                if (driver.Url.Contains("edit_photo.php"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch 
            {
                return false;
            }
        }

        public static bool Test011(IWebDriver driver) //LOGIN WITH INCORRECT PASSWORD
        {
            try
            {
                //couldn't get the webpage to properly reset, so I just logged out and logged back in with the incorrect password
                IWebElement logoutDropdown = SiteWebElement.logoutDropdown(driver);
                logoutDropdown.Click();

                IWebElement logoutButton = SiteWebElement.logoutButton(driver);
                logoutButton.Click();

                LoginPage(driver, "nick", "hacked");
                
                IAlert alert = driver.SwitchTo().Alert();

                string success = alert.Text;

                Thread.Sleep(1000);

                if (success.Contains("Incorrect Password. Please Try again!"))
                {
                    alert.Accept();
                    return true;
                    
                }
                else
                {
                    return false;
                }
            }
            catch 
            {
                return false;
            }
        }

        public static bool Test012(IWebDriver driver) //LOGIN WITH INCORRECT USERNAME
        {
            try
            {
                LoginPage(driver, "hacker", "asdf");

                IAlert alert = driver.SwitchTo().Alert();

                string success = alert.Text;

                Thread.Sleep(1000);

                if (success.Contains("Incorrect Screen Name. Please Try again!"))
                {
                    alert.Accept();
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch 
            {
                return false;
            }
        }

        public static bool Test013(IWebDriver driver) //LOGIN WITH NO USERNAME
        {
            try
            {
                LoginPage(driver, "", "asdf");

                Thread.Sleep(1000);

                if (driver.Url.Contains("login.php"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch 
            {
                return false;
            }
        }
        public static bool Test014(IWebDriver driver) //LOGIN WITH NO PASSWORD
        {
            try
            {
                LoginPage(driver, "nick", "");

                Thread.Sleep(1000);

                if (driver.Url.Contains("login.php"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch 
            {
                return false;
            }
        }
        //test 15 is worth 2
        public static bool Test015(IWebDriver driver) //CREATE USER - seems to be bug with random data, using static data for now
        {
            try
            {
                
                RegisterPage(driver, "NB", "E3B3Y4", "test@gmail.com");

                IAlert alert = driver.SwitchTo().Alert();
                string success = alert.Text;

                Thread.Sleep(1000);

                if (success.Contains("NEW TROLL USER ACCEPTED AND INSERTED!"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch 
            {
                return false;
            }
        }
        public static bool Test016(IWebDriver driver) //TESTS POSTAL CODE TOO SHORT
        {
            try
            {
                RegisterPage(driver, "NB", "E3B3", "test@gmail.com");
                IAlert alert = driver.SwitchTo().Alert();
                string success = alert.Text;
                Thread.Sleep(1000);

                if (success.Contains("NEW TROLL USER ACCEPTED AND INSERTED!"))
                {
                    alert.Accept();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return true;
            }
        }
        public static bool Test017(IWebDriver driver) //TESTS POSTAL CODE TOO LONG
        {
            try
            {
                RegisterPage(driver, "NB", "E3A94576", "test@gmail.com");
                IAlert alert = driver.SwitchTo().Alert();
                string success = alert.Text;
                Thread.Sleep(1000);
                
                if (success.Contains("NEW TROLL USER ACCEPTED AND INSERTED!"))
                {
                    alert.Accept();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch 
            {
                return false;
            }
        }

        public static bool Test018(IWebDriver driver) //create account with static data
        {
            try
            {
                RegisterPageWithoutThings(driver, "NB", "E3B3Y4", "password", "password", "testemail@gmail.com", "newuser",
                    "5061111111", "100 Main Street", "test.com", "Fredericton", "John", "Smith", "coding is fun");
                IAlert alert = driver.SwitchTo().Alert();
                string success = alert.Text;
                Thread.Sleep(1000);

                if (success.Contains("NEW TROLL USER ACCEPTED AND INSERTED!"))
                {
                    alert.Accept();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }


        public static bool Test019(IWebDriver driver) //TESTS PASSWORD NEEDING MATCH
        {
            try
            {
                RegisterPageWithoutThings(driver, "NB", "E3A9Z7", "HELLO", "GOODBYE", "test@gmail.com", "newuser",
                    "5061111111", "100 Main Street", "test.com", "Fredericton", "John", "Smith", "coding is fun");

                IAlert alert = driver.SwitchTo().Alert();
                string success = alert.Text;
                Thread.Sleep(1000);

                if (success.Contains("NEW TROLL USER ACCEPTED AND INSERTED!"))
                {
                    alert.Accept();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool Test021(IWebDriver driver)
        {
            try
            {
                LoginPage(driver, "newuser", "password");

                Thread.Sleep(1000);

                if (driver.Url.Contains("index.php"))
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }

        }
        
        //17.test long postal code &
        //18.test password confirm mismatch &
        //19.test login with new user 
        //20.test make post with new user 
        //21.test retweet from new user 
        //22.test sending a message 
        //23.test following, see if number changes
        //25.test moment link "broken counts as 2"
        //26. test notif, see if updates after retweet
        //27. send message to non existent user 
        //28. send message to existing user 
        //29. send message to self
        //30. send message to user with no messages
        //31. send message with no user

        public static void LoginPage(IWebDriver driver, string strUsername, string strPassword)
            {
            driver.Url = "http://10.157.123.12/site7/login.php";

                //enter username
                SiteWebElement.txtLoginUserName(driver).SendKeys(strUsername);
                //enter password
                SiteWebElement.txtLoginPassword(driver).SendKeys(strPassword);
                //click login button
                SiteWebElement.btnLogin(driver).Click();
            }

        public static void RegisterPage(IWebDriver driver, string province, string postalcode, string email)
        {
            driver.Url = "http://10.157.123.12/site7/signup.php";

            var faker = new Faker();

            // Generate fake data in variables so they can be used to log in
            string firstName = faker.Name.FirstName();
            string lastName = faker.Name.LastName();
            string username = faker.Internet.UserName();
            string password = faker.Internet.Password();
            string phoneNumber = faker.Phone.PhoneNumberFormat();
            string address = faker.Address.StreetAddress();
            string url = faker.Internet.Url();
            string description = faker.Rant.Review();
            string location = faker.Address.City();
            //send fake data to the register page
            SiteWebElement.txtFirstName(driver).SendKeys(firstName);
            SiteWebElement.txtLastName(driver).SendKeys(lastName);
            SiteWebElement.txtEmail(driver).SendKeys(email);
            SiteWebElement.txtLoginUserName(driver).SendKeys(username);
            SiteWebElement.txtLoginPassword(driver).SendKeys(password);
            SiteWebElement.txtConfirmPassword(driver).SendKeys(password);
            SiteWebElement.txtPhoneNumber(driver).SendKeys(phoneNumber);
            SiteWebElement.txtAddress(driver).SendKeys(address);
            SiteWebElement.txtProvince(driver).Click();
            SiteWebElement.txtProvince(driver).SendKeys(province);
            SiteWebElement.txtPostalCode(driver).SendKeys(postalcode);
            SiteWebElement.txtUrl(driver).SendKeys(url);
            SiteWebElement.txtDesc(driver).SendKeys(description);
            SiteWebElement.txtLocation(driver).SendKeys(location);
            SiteWebElement.btnLogin(driver).Click();

        }
        public static void RegisterPageWithoutThings(IWebDriver driver, string province, string postalcode, string password, string confirmPass, string email,
             string username, string phone, string address, string url, string location, string firstName, string lastName, string description)
        {
            driver.Url = "http://10.157.123.12/site7/signup.php";

            var faker = new Faker();


            //send data to the page
            SiteWebElement.txtFirstName(driver).SendKeys(firstName);
            SiteWebElement.txtLastName(driver).SendKeys(lastName);
            SiteWebElement.txtEmail(driver).SendKeys(email);
            SiteWebElement.txtLoginUserName(driver).SendKeys(username);
            SiteWebElement.txtPhoneNumber(driver).SendKeys(phone);
            SiteWebElement.txtAddress(driver).SendKeys(address);
            SiteWebElement.txtProvince(driver).Click();
            SiteWebElement.txtProvince(driver).SendKeys(province);
            SiteWebElement.txtPostalCode(driver).SendKeys(postalcode);
            SiteWebElement.txtUrl(driver).SendKeys(url);
            SiteWebElement.txtDesc(driver).SendKeys(description);
            SiteWebElement.txtLocation(driver).SendKeys(location);
            SiteWebElement.btnLogin(driver).Click();

        }
        public static void FakeData(IWebDriver driver)
        {
            // Create a Faker object.
            var faker = new Faker("en");

            Thread.Sleep(5000);
        }


    }
}


