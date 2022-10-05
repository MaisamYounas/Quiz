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
    public class PurchaseOrderClass : CommonClass
    {
        By clickProduct = By.XPath("/html/body/section[2]/div/div/div[2]/div[1]/div[6]/div/div[2]/ul/li/a");
        By ClickaddCart = By.XPath("/html/body/section/div/div/div[2]/div[2]/div[2]/div/span/button");
        By clickcon = By.XPath("//*[@id='cartModal']/div/div/div[3]/button");
        By clickCartbtn = By.XPath("//a[@href='/view_cart']");
        By Clickproceed = By.XPath("//*[@id='do_action']/div[1]/div/div/a");
        By clicksignup = By.XPath("//*[@id='checkoutModal']/div/div/div[2]/p[2]/a/u");

        //Sign_Up
        By EnterName = By.XPath("//*[@id='form']/div/div/div[3]/div/form/input[2]");
        By EnterEmail = By.XPath("//*[@id='form']/div/div/div[3]/div/form/input[3]");
        By ClickBtn = By.XPath("//*[@id='form']/div/div/div[3]/div/form/button");

        //public void Register()
        //{

        //    text_field(EnterName, "Maisam");
        //    text_field(EnterEmail, "maisam@gmail.com");
        //    click_Button(ClickBtn);
        //}


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
        By ClickContinue = By.XPath("//*[@id='form']/div/div/div/div/a");

        By clickCart = By.XPath("//a[@href='/view_cart']");
        By Clickproceed2 = By.XPath("//*[@id='do_action']/div[1]/div/div/a");
        By EnterComment = By.XPath("//*[@id='ordermsg']/textarea");
        By clickplaceorder = By.XPath("//a[@href='/payment']");
        By EnterCardName = By.XPath("//*[@id='payment-form']/div[1]/div/input");
        By EnterCardNo = By.XPath("//*[@id='payment-form']/div[2]/div/input");
        By enterCVC = By.XPath("//*[@id='payment-form']/div[3]/div[1]/input");
        By enterExpire = By.XPath("//*[@id='payment-form']/div[3]/div[2]/input");
        By enterCardyear = By.XPath("//*[@id='payment-form']/div[3]/div[3]/input");
        By ClickPaybtn = By.XPath("//*[@id='submit']");
        By Clickdownload = By.XPath("//*[@id='form']/div/div/div/a");

        //public void EnterInfo()
        //{
        //    click_Button(ClickRadioBtn);
        //    text_field(Enterpass, "Maisam1$");
        //    click_Button(clickday);
        //    click_Button(selectday);
        //    click_Button(clickmonth);
        //    click_Button(selectmonth);
        //    click_Button(clickyear);
        //    click_Button(selectyear);
        //    click_Button(clickcheckbox1);
        //    click_Button(clickcheckbox2);
        //    text_field(Fname, "Maisam");
        //    text_field(Lname, "Younas");
        //    text_field(company, "Contour software");
        //    text_field(address1, "house no 11");
        //    text_field(address2, "house no 11");
        //    click_Button(selectcountry);
        //    text_field(state, "hello");
        //    text_field(city, "hey");
        //    text_field(zipcode, "887766");
        //    text_field(phoneno, "08878267675");
        //    click_Button(ClickCreateBtn);

        //}





        public void PurchasedOrder()
        {
            scrolltoViewElement(clickProduct);
            click_Button(clickProduct);
            click_Button(ClickaddCart);
            Thread.Sleep(1000);
            click_Button(clickcon);
            Thread.Sleep(1000);
            click_Button(clickCartbtn);
            click_Button(Clickproceed);
            click_Button(clicksignup);
            Thread.Sleep(5000);

            //Register
            text_field(EnterName, "Maisam");
            text_field(EnterEmail, "maisam9@gmail.com");
            click_Button(ClickBtn);
            Thread.Sleep(5000);

            //Enter information
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
            text_field(phoneno, "08878267675");
            click_Button(ClickCreateBtn);
            click_Button(ClickContinue);
            Thread.Sleep(2000);
            click_Button(clickCart);
            click_Button(Clickproceed2);
            scrolltoViewElement(EnterComment);
            text_field(EnterComment, "Order is delivery safely");
            click_Button(clickplaceorder);
            text_field(EnterCardName, "HBL");
            text_field(EnterCardNo, "782716673714777");
            text_field(enterCVC, "886");
            text_field(enterExpire, "2020");
            text_field(enterCardyear, "2025");
            click_Button(ClickPaybtn);
            click_Button(Clickdownload);




        }

    }
}
