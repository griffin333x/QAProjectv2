using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Security.Policy;


namespace BitterTests
{
    class SiteWebElement
    {
        public static IWebElement txtLoginUserName (IWebDriver driver)
        {
            
            //retrieve the username text box
            IWebElement txtLoginUserName = driver.FindElement(By.Id("username"));
            return txtLoginUserName;
        }
        public static IWebElement txtLoginPassword(IWebDriver driver)
        {
            //retrieve the password text box
            IWebElement txtLoginPassword = driver.FindElement(By.Id("password"));
            return txtLoginPassword;
        }
        public static IWebElement btnLogin(IWebDriver driver)
        {
            //retrieve the login button
            IWebElement btnLogin = driver.FindElement(By.Id("button"));
            return btnLogin;
        }

        //search button
        public static IWebElement searchButton(IWebDriver driver)
        {
            IWebElement searchButton = driver.FindElement(By.CssSelector("button.btn.btn-outline-light.my-2.my-sm-0[type='submit']"));
            return searchButton;
        }
        //search text box
        public static IWebElement searchTextBox(IWebDriver driver)
        {
            IWebElement searchTextBox = driver.FindElement(By.CssSelector("input.form-control.mr-sm-2[type='text']"));
            return searchTextBox;
        }
        //Home link
        public static IWebElement homeLink(IWebDriver driver)
        {
            IWebElement homeLink = driver.FindElement(By.CssSelector("a.nav-link[href='index.php']"));
            return homeLink;
        }
        //notifications link
        public static IWebElement notificationsLink(IWebDriver driver)
        {
            IWebElement notificationsLink = driver.FindElement(By.CssSelector("a.nav-link[href='notifications.php']"));
            return notificationsLink;
        }
        //messages link
        public static IWebElement messagesLink(IWebDriver driver)
        {
            //<li class="nav-item">
                //< a class="nav-link" href="DirectMessage.php">
                    //<img class="bannericons" src="images/messages.png">Messages</a>

            IWebElement messagesLink = driver.FindElement(By.CssSelector("a.nav-link[href='DirectMessage.php']"));
            return messagesLink;

        }




        

    }
}
