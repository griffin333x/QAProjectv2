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
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool Test002(IWebDriver driver) //SEARCH FUNCTION WITHOUT TEXT
        {
            try
            {
                Thread.Sleep(1000);
                //try search function
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
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool Test003(IWebDriver driver) //SEARCH FUNCTION WITH TEXT
        {
            try
            {
                Thread.Sleep(1000);
                //try search function
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
            catch (Exception ex)
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
            catch (Exception ex)
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

            catch (Exception ex)
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
            catch (Exception ex)
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
            catch (Exception ex)
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
            catch (Exception ex)
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
            catch (Exception ex)
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
            catch (Exception ex)
            {
                return false;
            }
        }


        






        public static void LoginPage(IWebDriver driver, string strUsername, string strPassword)
            {
                driver.Navigate().GoToUrl("http://10.157.123.12/site7/login.php");

                //enter username
                SiteWebElement.txtLoginUserName(driver).SendKeys(strUsername);
                //enter password
                SiteWebElement.txtLoginPassword(driver).SendKeys(strPassword);
                //click login button
                SiteWebElement.btnLogin(driver).Click();
            }


        
    
    }
}


