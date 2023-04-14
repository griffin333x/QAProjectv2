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
        public static IWebElement txtLoginUserName(IWebDriver driver)
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
            //some of these selectors are really long, couldn't get it to work with more simple ones
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


            IWebElement messagesLink = driver.FindElement(By.CssSelector("a.nav-link[href='DirectMessage.php']"));
            return messagesLink;

        }
        //contact us link
        public static IWebElement contactUsLink(IWebDriver driver)
        {
            IWebElement contactUsLink = driver.FindElement(By.CssSelector("a.nav-link[href='contactus']"));
            return contactUsLink;
        }
        //userpage link
        public static IWebElement userPageLink(IWebDriver driver)
        {
            IWebElement userPageLink = driver.FindElement(By.CssSelector("a[href='userpage.php?user_id=1025']"));
            return userPageLink;
        }
        //dropdown menu for logout
        public static IWebElement logoutDropdown(IWebDriver driver)
        {
            IWebElement logoutDropdown = driver.FindElement(By.Id("dropdown01"));
            return logoutDropdown;
        }
        //logout button
        public static IWebElement logoutButton(IWebDriver driver)
        {
            IWebElement logoutButton = driver.FindElement(By.LinkText("Logout"));
            return logoutButton;
        }
        //edit profile pic
        public static IWebElement editProfilePic(IWebDriver driver)
        {
            IWebElement editProfilePic = driver.FindElement(By.LinkText("Edit Profile Picture"));
            return editProfilePic;
        }
        //first name field
        public static IWebElement txtFirstName(IWebDriver driver)
        {
            IWebElement txtFirstName = driver.FindElement(By.Id("firstname"));
            return txtFirstName;
        }
        //last name field
        public static IWebElement txtLastName(IWebDriver driver)
        {
            IWebElement txtLastName = driver.FindElement(By.Id("lastname"));
            return txtLastName;
        }
        //email field
        public static IWebElement txtEmail(IWebDriver driver)
        {
            IWebElement txtEmail = driver.FindElement(By.Id("email"));
            return txtEmail;
        }
        //confirm password field
        public static IWebElement txtConfirmPassword(IWebDriver driver)
        {
            IWebElement txtConfirmPassword = driver.FindElement(By.Id("confirm"));
            return txtConfirmPassword;
        }
        //phone number field
        public static IWebElement txtPhoneNumber(IWebDriver driver)
        {
            IWebElement txtPhoneNumber = driver.FindElement(By.Id("phone"));
            return txtPhoneNumber;
        }
        //address field
        public static IWebElement txtAddress(IWebDriver driver)
        {
            IWebElement txtAddress = driver.FindElement(By.Id("address"));
            return txtAddress;
        }
        //province field
        public static IWebElement txtProvince(IWebDriver driver)
        {
            IWebElement txtProvince = driver.FindElement(By.Id("province"));
            return txtProvince;
        }
        //postal code field
        public static IWebElement txtPostalCode(IWebDriver driver)
        {
            IWebElement txtPostalCode = driver.FindElement(By.Id("postalCode"));
            return txtPostalCode;
        }
        //url field
        public static IWebElement txtUrl(IWebDriver driver)
        {
            IWebElement txtUrl = driver.FindElement(By.Id("url"));
            return txtUrl;
        }
        //description field
        public static IWebElement txtDesc(IWebDriver driver)
        {
            IWebElement txtDesc = driver.FindElement(By.Id("desc"));
            return txtDesc;
        }
        //location field
        public static IWebElement txtLocation(IWebDriver driver)
        {
            IWebElement txtLocation = driver.FindElement(By.Id("location"));
            return txtLocation;
        }









    }

    
}
