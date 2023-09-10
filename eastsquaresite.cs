using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Testing
{
    public class eastsquaresite
    {
        public static string home(string ESHome)
        {
            string message = "",
            homePageMessage = "";

            try
            {
                var google = Driver.Instance.FindElement(By.Name("q"));
                google.Click();
                google.SendKeys(ESHome);
                google.SendKeys(Keys.Enter);
                Thread.Sleep(1000);

                var ESHomepage = Driver.Instance.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div.Z26q7c.UK95Uc.jGGQ5e > div > div > a > div"));
                ESHomepage.Click();
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                message += "ERROR!!" + e.Message;
            }
            message += homePageMessage;
            return message;
        }

        public static string func()
        {
            string message = "",
            Functionalities = "";

            try
            {
                var aboutus = Driver.Instance.FindElement(By.CssSelector("#__next > div > header > div > div > div > ul > li:nth-child(1) > button > span.MuiButton-label"));
                aboutus.Click();
                Thread.Sleep(1000);

                var team = Driver.Instance.FindElement(By.CssSelector("#__next > div > header > div > div > div > ul > li:nth-child(2) > button > span.MuiButton-label"));
                Actions actions = new Actions(Driver.Instance);
                actions.MoveToElement(team);
                actions.Perform();
                team.Click();
                Thread.Sleep(1000);

                var faq = Driver.Instance.FindElement(By.CssSelector("#__next > div > header > div > div > div > ul > li:nth-child(3) > button > span.MuiButton-label"));
                Actions actions1 = new Actions(Driver.Instance);
                actions.MoveToElement(faq);
                actions.Perform();
                faq.Click();
                Thread.Sleep(1000);

                var products = Driver.Instance.FindElement(By.CssSelector("#__next > div > header > div > div > div > ul > li:nth-child(4) > button > span.MuiButton-label"));
                Actions actions2 = new Actions(Driver.Instance);
                actions.MoveToElement(products);
                actions.Perform();
                products.Click();
                Thread.Sleep(1000);

                var contact = Driver.Instance.FindElement(By.CssSelector("#__next > div > header > div > div > div > ul > li:nth-child(5) > button > span.MuiButton-label"));
                Actions actions3 = new Actions(Driver.Instance);
                actions.MoveToElement(contact);
                actions.Perform();
                contact.Click();
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                message += "ERROR!!" + e.Message;
            }
            message += Functionalities;
            return message;
        }
    }
}