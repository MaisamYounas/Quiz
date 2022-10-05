using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;


namespace Quiz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Register()
        {
            RegisterClass obj = new RegisterClass();
            obj.browserMethod("chrome");
            obj.url("https://automationexercise.com/");
            obj.Register();
            Thread.Sleep(5000);
            obj.EnterInfo();

        }

        [TestMethod]
        public void Login_logout()
        {
            LogIn_LogoutClass obj = new LogIn_LogoutClass();
            obj.browserMethod("chrome");
            obj.url("https://automationexercise.com/");
            obj.log_in();
            Thread.Sleep(5000);
            obj.Log_out();
        }


        [TestMethod]
        public void purchasedorder()
        {
            PurchaseOrderClass obj = new PurchaseOrderClass();
            obj.browserMethod("chrome");
            obj.url("https://automationexercise.com/");
            obj.PurchasedOrder();
          
        }


    }
}
