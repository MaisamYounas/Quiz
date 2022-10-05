using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace Quiz
{
    public class CommonClass
    {
            public static IWebDriver driver;

            public void browserMethod(string browserName)
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
            }
            public void url(string u)
            {
                driver.Url = u;
            }
            public void click_Button(By path)
            {
                driver.FindElement(path).Click();

            }
        public void text_field(By path, string data)
        {
            driver.FindElement(path).SendKeys(data);

        }
        public void scrolltoViewElement(By path)
        {

            IJavaScriptExecutor scroller = (IJavaScriptExecutor)driver;
            IWebElement fElement = driver.FindElement(path);
            scroller.ExecuteScript("arguments[0].scrollIntoView(true);", fElement);
  
        }


    }   }      

