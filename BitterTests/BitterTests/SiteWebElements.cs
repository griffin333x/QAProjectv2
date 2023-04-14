using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BitterTests
{

    class BitterElements
    {
        
        public static IWebElement TxtLoginUsername(IWebDriver driver)
        {
            //returns the username from the form authentication page
            IWebElement txtLoginUsername = driver.FindElement(By.Id("username"));
            return txtLoginUsername;
        }
        public static IWebElement TxtLoginPassword(IWebDriver driver)
        {
            //returns the password from the form authentication page
            IWebElement txtLoginPassword = driver.FindElement(By.Id("password"));
            return txtLoginPassword;
        }
        public static IWebElement BtnLogin(IWebDriver driver)
        {
            //returns the login button from the form authentication page
            IWebElement btnLogin = driver.FindElement(By.Id("button"));
            return btnLogin;
        }
        public static IWebElement SignupFName(IWebDriver driver)
        {
            //returns the login button from the form authentication page
            IWebElement signupName = driver.FindElement(By.Id("firstname"));
            return signupName;
        }
        public static IWebElement SignupLName(IWebDriver driver)
        {
            //returns the login button from the form authentication page
            IWebElement signupName = driver.FindElement(By.Id("lastname"));
            return signupName;
        }
        public static IWebElement SignupEmail(IWebDriver driver)
        {
            //returns the login button from the form authentication page
            IWebElement signupName = driver.FindElement(By.Id("email"));
            return signupName;
        }
        public static IWebElement SignupScreenName(IWebDriver driver)
        {
            //returns the login button from the form authentication page
            IWebElement signupName = driver.FindElement(By.Id("username"));
            return signupName;
        }
        public static IWebElement SignupPassword(IWebDriver driver)
        {
            //returns the login button from the form authentication page
            IWebElement signupName = driver.FindElement(By.Id("password"));
            return signupName;
        }
        public static IWebElement SignupConfirmPass(IWebDriver driver)
        {
            //returns the login button from the form authentication page
            IWebElement signupName = driver.FindElement(By.Id("confirm"));
            return signupName;
        }
        public static IWebElement SignupPhone(IWebDriver driver)
        {
            //returns the login button from the form authentication page
            IWebElement signupName = driver.FindElement(By.Id("phone"));
            return signupName;
        }
        public static IWebElement SignupAddress(IWebDriver driver)
        {
            //returns the login button from the form authentication page
            IWebElement signupName = driver.FindElement(By.Id("address"));
            return signupName;
        }
        public static IWebElement SignupChooseProvince(IWebDriver driver)
        {
            //returns the login button from the form authentication page
            IWebElement signupName = driver.FindElement(By.Id("firstname"));
            return signupName;
        }
        public static IWebElement SignupName(IWebDriver driver)
        {
            //returns the login button from the form authentication page
            IWebElement signupName = driver.FindElement(By.Id("firstname"));
            return signupName;
        }
        public static IWebElement SignupName(IWebDriver driver)
        {
            //returns the login button from the form authentication page
            IWebElement signupName = driver.FindElement(By.Id("firstname"));
            return signupName;
        }
        public static IWebElement SignupName(IWebDriver driver)
        {
            //returns the login button from the form authentication page
            IWebElement signupName = driver.FindElement(By.Id("firstname"));
            return signupName;
        }
        public static IWebElement SignupName(IWebDriver driver)
        {
            //returns the login button from the form authentication page
            IWebElement signupName = driver.FindElement(By.Id("firstname"));
            return signupName;
        }
        public static IWebElement SignupName(IWebDriver driver)
        {
            //returns the login button from the form authentication page
            IWebElement signupName = driver.FindElement(By.Id("firstname"));
            return signupName;
        }

    }
}

