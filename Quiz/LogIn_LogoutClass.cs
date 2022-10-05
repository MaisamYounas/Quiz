using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Quiz
{
    public class LogIn_LogoutClass : CommonClass
    {
        By Clicklogin = By.XPath("//*[@id='header']/div/div/div/div[2]/div/ul/li[4]/a");
        By Enteremail = By.XPath("//*[@id='form']/div/div/div[1]/div/form/input[2]");
        By Enterpass = By.XPath("//*[@id='form']/div/div/div[1]/div/form/input[3]");
        By clickloginbtn = By.XPath("//*[@id='form']/div/div/div[1]/div/form/button");


        public void log_in()
        {
            click_Button(Clicklogin);
            text_field(Enteremail, "maisamyounis11@gmail.com");
            text_field(Enterpass, "Maisam1$");
            click_Button(clickloginbtn);
        }

        //Log Out

        By CLickLogout = By.XPath("//a[@href='/logout']");

        public void Log_out()
        {
            click_Button(CLickLogout);
        }

    }
}
