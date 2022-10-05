using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Quiz
{
    public class RegisterClass : CommonClass
    {
        By ClickRegister = By.XPath("//*[@id='header']/div/div/div/div[2]/div/ul/li[4]/a");
        By EnterName = By.XPath("//*[@id='form']/div/div/div[3]/div/form/input[2]");
        By EnterEmail = By.XPath("//*[@id='form']/div/div/div[3]/div/form/input[3]");
        By ClickBtn = By.XPath("//*[@id='form']/div/div/div[3]/div/form/button");


        public void Register()
        {
            click_Button(ClickRegister);
            text_field(EnterName, "Maisam");
            text_field(EnterEmail, "maisamyounis11@gmail.com");
            click_Button(ClickBtn);
        }


        //Enter infomation

        By ClickRadioBtn = By.Id("id_gender1");
        By Enterpass = By.Id("password");
        By clickday = By.Id("days");
        By selectday = By.XPath("//*[@id='days']/option[6]");
        By clickmonth = By.Id("months");
        By selectmonth = By.XPath("//*[@id='months']/option[13]");
        By clickyear = By.Id("years");
        By selectyear = By.XPath("//*[@id='years']/option[25]");
        By clickcheckbox1 = By.Id("newsletter");
        By clickcheckbox2 = By.Id("optin");
        By Fname = By.Id("first_name");
        By Lname = By.Id("last_name");
        By company = By.Id("company");
        By address1 = By.Id("address1");
        By address2 = By.Id("address2");
        By country = By.Id("country");
        By selectcountry = By.XPath("//*[@id='country']/option[2]");
        By state = By.Id("state");
        By city = By.Id("city");
        By zipcode = By.Id("zipcode");
        By phoneno = By.Id("mobile_number");
        By ClickCreateBtn = By.XPath("//*[@id='form']/div/div/div/div[1]/form/button");


         public void EnterInfo()
        {
            click_Button(ClickRadioBtn);
            text_field(Enterpass, "Maisam1$");
            click_Button(clickday);
            click_Button(selectday);
            click_Button(clickmonth);
            click_Button(selectmonth);
            click_Button(clickyear);
            click_Button(selectyear);
            click_Button(clickcheckbox1);
            click_Button(clickcheckbox2);
            text_field(Fname, "Maisam");
            text_field(Lname, "Younas");
            text_field(company, "Contour software");
            text_field(address1, "house no 11");
            text_field(address2, "house no 11");
            click_Button(selectcountry);
            text_field(state, "hello");
            text_field(city, "hey");
            text_field(zipcode, "887766");
            text_field(phoneno, "0887826764675");
            click_Button(ClickCreateBtn);

        }




    }


}
