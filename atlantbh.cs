using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Testing
{
    public class atlantbh
    {
        public static string Homepage(string HP)
        {
            string message = "",
            HomePageMessage = "";

            try
            {
                var google = Driver.Instance.FindElement(By.Name("q"));
                google.Click();
                google.SendKeys(HP);
                google.SendKeys(Keys.Enter);
                Thread.Sleep(1000);

                var homepage = Driver.Instance.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div > div > div > div > div.yuRUbf > a > h3"));
                homepage.Click();
                Thread.Sleep(1000);

                var acceptcookies = Driver.Instance.FindElement(By.CssSelector("#cn-accept-cookie"));
                acceptcookies.Click();
                Thread.Sleep(500);
            }
            catch (Exception e)
            {
                message += "ERROR!!" + e.Message;
            }
            message += HomePageMessage;
            return message;
            
        }

        public static string Functionalities()
        {
            string message = "",
            FunctionalitiesMessage = "";

            try
            {
                var home = Driver.Instance.FindElement(By.CssSelector("#menu-item-1081 > a"));
                home.Click();
                Thread.Sleep(500);

                var services = Driver.Instance.FindElement(By.CssSelector("#menu-item-1451 > a"));
                services.Click();
                Thread.Sleep(500);

                var careers = Driver.Instance.FindElement(By.CssSelector("#menu-item-17838 > a"));
                careers.Click();
                Thread.Sleep(500);

                var givingback = Driver.Instance.FindElement(By.CssSelector("#menu-item-18684 > a"));
                givingback.Click();
                Thread.Sleep(500);

                var blog = Driver.Instance.FindElement(By.CssSelector("#menu-item-13931 > a"));
                blog.Click();
                Thread.Sleep(500);

                var contact = Driver.Instance.FindElement(By.CssSelector("#menu-item-14574 > a"));
                contact.Click();
                Thread.Sleep(500);
            }
            catch (Exception e)
            {
                message += "ERROR!!" + e.Message;
            }
            message += FunctionalitiesMessage;
            return message;
        }

        public static string Search(string QA)
        {
            string message = "",
            SearchMessage = "";

            try
            {
                var searchbutton = Driver.Instance.FindElement(By.CssSelector("#top > div > div > div.col.span_9.col_last > nav > ul.sf-menu.sf-js-enabled.sf-arrows > li.astm-search-menu.is-menu.is-dropdown.menu-item > a"));
                searchbutton.Click();
                Thread.Sleep(500);

                var searchinput = Driver.Instance.FindElement(By.CssSelector("#is-search-input-0"));
                searchinput.Click();
                searchinput.SendKeys(QA);
                searchinput.SendKeys(Keys.Enter);
                Thread.Sleep(1000);

                var selectblog = Driver.Instance.FindElement(By.CssSelector("#search-results > article:nth-child(3) > div > h2 > a"));
                Actions actions = new Actions(Driver.Instance);
                actions.MoveToElement(selectblog);
                actions.Perform();
                selectblog.Click();
                Thread.Sleep(1000);

                var subscribe = Driver.Instance.FindElement(By.CssSelector("#mlb2-5847491 > div > div > div.ml-form-embedBody.ml-form-embedBodyDefault.row-form > form > div.ml-form-formContent > div > div > input"));
                Actions actions2 = new Actions(Driver.Instance);
                actions2.MoveToElement(subscribe);
                actions2.Perform();
                subscribe.Click();
                subscribe.SendKeys("mashas_house@live.com");
                var subscribesubmit = Driver.Instance.FindElement(By.CssSelector("#mlb2-5847491 > div > div > div.ml-form-embedBody.ml-form-embedBodyDefault.row-form > form > div.ml-form-embedSubmit"));
                subscribesubmit.Click();
            }
            catch (Exception e)
            {
                message += "ERROR!!" + e.Message;
            }
            message += SearchMessage;
            return message;
        }

        public static string Services()
        {
            string message = "",
            ServiceMessage = "";

            try
            {
                var services = Driver.Instance.FindElement(By.CssSelector("#menu-item-1451 > a"));
                Actions actions = new Actions(Driver.Instance);
                actions.MoveToElement(services);
                actions.Perform();
                Thread.Sleep(1000);

                var QAservices = Driver.Instance.FindElement(By.CssSelector("#menu-item-18275 > a"));
                QAservices.Click();
                Thread.Sleep(500);

                var meetatlanters = Driver.Instance.FindElement(By.CssSelector("#fws_642341bca7cd3 > div.col.span_12.left > div > div > div.wpb_wrapper > div > div > div > a"));
                meetatlanters.Click();
                Thread.Sleep(500);

                var meetSabina = Driver.Instance.FindElement(By.CssSelector("#fws_6423421960d2d > div.col.span_12.left > div.vc_col-sm-4.wpb_column.column_container.vc_column_container.col.child_column.has-animation.no-extra-padding.instance-5.animated-in > div > div.wpb_wrapper > div > div.team-member-overlay"));
                meetSabina.Click();
                Thread.Sleep(500);

                var exit = Driver.Instance.FindElement(By.CssSelector("body > div.nectar_team_member_overlay.open > div > div.team_member_details"));
                exit.Click();
                Thread.Sleep(500);
            }
            catch (Exception e)
            {
                message += "ERROR!!" + e.Message;
            }
            message += ServiceMessage;
            return message;
        }

        public static string Careers()
        {
            string message = "",
            CareersMessage = "";

            try
            {
                var careers = Driver.Instance.FindElement(By.CssSelector("#menu-item-17838 > a"));
                Actions actions = new Actions(Driver.Instance);
                actions.MoveToElement(careers);
                actions.Perform();
                Thread.Sleep(1000);

                var culture = Driver.Instance.FindElement(By.CssSelector("#menu-item-18042 > a"));
                culture.Click();
                Thread.Sleep(500);

                var blogselect = Driver.Instance.FindElement(By.CssSelector("#post-17127 > div > div > div.content-inner > a"));
                blogselect.Click();
                Thread.Sleep(500);

                var leavecomment = Driver.Instance.FindElement(By.CssSelector("#comment"));
                leavecomment.Click();
                leavecomment.SendKeys("WOW! You truly are an inspiration.");
                Thread.Sleep(500);
                var name = Driver.Instance.FindElement(By.CssSelector("#author"));
                name.Click();
                name.SendKeys("John");
                Thread.Sleep(500);
                var email = Driver.Instance.FindElement(By.CssSelector("#email"));
                email.Click();
                email.SendKeys("mashas_house@live.com");
                Thread.Sleep(500);
                var submitcomment = Driver.Instance.FindElement(By.CssSelector("#submit"));
                submitcomment.Click();
                Thread.Sleep(500);
            }
            catch (Exception e)
            {
                message += "ERROR!!" + e.Message;
            }
            message += CareersMessage;
            return message;
        }
    }
}