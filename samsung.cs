using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;

namespace Testing
{
    public class samsung
    {
        public static string homepage(string HP)
        {
            string message = "",
            HomepageMessage = "";

            try
            {
                var google = Driver.Instance.FindElement(By.Name("q"));
                google.Click();
                google.SendKeys(HP);
                google.SendKeys(Keys.Enter);
                Thread.Sleep(1000);

                var samsungHomePage = Driver.Instance.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div > div > div > div > div.yuRUbf > a"));
                samsungHomePage.Click();
                Thread.Sleep(1000);

                var acceptCookies = Driver.Instance.FindElement(By.CssSelector("#header > div.cookie-bar.cookie-bar--type-manage > div > div > div.cookie-bar__manage > a"));
                acceptCookies.Click();
                Thread.Sleep(500);
            }
            catch (Exception e)
            {
                message += "ERROR!!" + e.Message;
            }
            message += HomepageMessage;
            return message;
        }

        public static string functionalities()
        {
            string message = "",
            FunctionalitiesMessage = "";

            try
            {
                var funcMobile = Driver.Instance.FindElement(By.CssSelector("#component-id > div.nv00-gnb__inner-wrap > div.nv00-gnb__l0-menu-wrap > ul.nv00-gnb__l0-menu-list.left-menu > li:nth-child(1) > button"));
                funcMobile.Click();
                Thread.Sleep(1000);

                var funcTVAudio = Driver.Instance.FindElement(By.CssSelector("#component-id > div.nv00-gnb__inner-wrap > div.nv00-gnb__l0-menu-wrap > ul.nv00-gnb__l0-menu-list.left-menu > li:nth-child(2) > button"));
                funcTVAudio.Click();
                Thread.Sleep(1000);

                var funcAppliances = Driver.Instance.FindElement(By.CssSelector("#component-id > div.nv00-gnb__inner-wrap > div.nv00-gnb__l0-menu-wrap > ul.nv00-gnb__l0-menu-list.left-menu > li:nth-child(3) > button"));
                funcAppliances.Click();
                Thread.Sleep(1000);

                var funcComputing = Driver.Instance.FindElement(By.CssSelector("#component-id > div.nv00-gnb__inner-wrap > div.nv00-gnb__l0-menu-wrap > ul.nv00-gnb__l0-menu-list.left-menu > li:nth-child(4) > button"));
                funcComputing.Click();
                Thread.Sleep(1000);

                var funcDisplays = Driver.Instance.FindElement(By.CssSelector("#component-id > div.nv00-gnb__inner-wrap > div.nv00-gnb__l0-menu-wrap > ul.nv00-gnb__l0-menu-list.left-menu > li:nth-child(5) > button"));
                funcDisplays.Click();
                Thread.Sleep(1000);

                var funcAccessories = Driver.Instance.FindElement(By.CssSelector("#component-id > div.nv00-gnb__inner-wrap > div.nv00-gnb__l0-menu-wrap > ul.nv00-gnb__l0-menu-list.left-menu > li:nth-child(6) > button"));
                funcAccessories.Click();
                Thread.Sleep(1000);

                var funcSmartT = Driver.Instance.FindElement(By.CssSelector("#component-id > div.nv00-gnb__inner-wrap > div.nv00-gnb__l0-menu-wrap > ul.nv00-gnb__l0-menu-list.left-menu > li:nth-child(7) > button"));
                funcSmartT.Click();
                Thread.Sleep(1000);

                var funcOffers = Driver.Instance.FindElement(By.CssSelector("#component-id > div.nv00-gnb__inner-wrap > div.nv00-gnb__l0-menu-wrap > ul.nv00-gnb__l0-menu-list.left-menu > li:nth-child(8) > button"));
                funcOffers.Click();
                Thread.Sleep(1000);

                var funcOutlet = Driver.Instance.FindElement(By.CssSelector("#component-id > div.nv00-gnb__inner-wrap > div.nv00-gnb__l0-menu-wrap > ul.nv00-gnb__l0-menu-list.left-menu > li:nth-child(9) > a"));
                funcOutlet.Click();
                Thread.Sleep(1000);

                var funcExplore = Driver.Instance.FindElement(By.CssSelector("#component-id > div.nv00-gnb__inner-wrap > div.nv00-gnb__l0-menu-wrap > ul.nv00-gnb__l0-menu-list.right-menu > li:nth-child(1) > button"));
                funcExplore.Click();
                Thread.Sleep(1000);

                var funcSupport = Driver.Instance.FindElement(By.CssSelector("#component-id > div.nv00-gnb__inner-wrap > div.nv00-gnb__l0-menu-wrap > ul.nv00-gnb__l0-menu-list.right-menu > li:nth-child(2) > button"));
                funcSupport.Click();
                Thread.Sleep(1000);

                var funcBussines = Driver.Instance.FindElement(By.CssSelector("#component-id > div.nv00-gnb__inner-wrap > div.nv00-gnb__l0-menu-wrap > ul.nv00-gnb__l0-menu-list.right-menu > li:nth-child(3) > button"));
                funcBussines.Click();
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                message += "ERROR!!" + e.Message;
            }
            message += FunctionalitiesMessage;
            return message;
        }

        public static string mobile()
        {
            string message = "",
            MobileMessage = "";

            try
            {
                var funcMobile = Driver.Instance.FindElement(By.CssSelector("#component-id > div.nv00-gnb__inner-wrap > div.nv00-gnb__l0-menu-wrap > ul.nv00-gnb__l0-menu-list.left-menu > li:nth-child(1) > button"));
                Actions actions = new Actions(Driver.Instance);
                actions.MoveToElement(funcMobile);
                actions.Perform();
                Thread.Sleep(1000);

                var smartPhones = Driver.Instance.FindElement(By.CssSelector("#component-id > div.nv00-gnb__inner-wrap > div.nv00-gnb__l0-menu-wrap > ul.nv00-gnb__l0-menu-list.left-menu > li:nth-child(1) > div > div.nv00-gnb__l1-menu-wrap.l1-only > ul > li:nth-child(2) > a"));
                smartPhones.Click();
                Thread.Sleep(1000);

                var baterryLife = Driver.Instance.FindElement(By.CssSelector("#slider1 > div > div.bleed-card__text-wrap.text-black > div > div > div > a"));
                actions.MoveToElement(baterryLife);
                actions.Perform();
                Thread.Sleep(1000);
                baterryLife.Click();
                Thread.Sleep(1000);

                var offers = Driver.Instance.FindElement(By.CssSelector("#null > div > div > div.ma-g-floating-nav.aem-GridColumn.aem-GridColumn--default--12 > section > div > div > div.ma-floating-nav__menu-wrap > div > h2 > ul > li:nth-child(4) > a"));
                actions.MoveToElement(offers);
                actions.Perform();
                Thread.Sleep(1000);
                offers.Click();
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                message += "ERROR!!" + e.Message;
            }
            message += MobileMessage;
            return message;
        }

        public static string computing()
        {
            string message = "",
            ComputingMessage = "";

            try
            {
                var funcComputing = Driver.Instance.FindElement(By.CssSelector("#component-id > div.nv00-gnb__inner-wrap > div.nv00-gnb__l0-menu-wrap > ul.nv00-gnb__l0-menu-list.left-menu > li:nth-child(4) > button"));
                Actions actions = new Actions(Driver.Instance);
                actions.MoveToElement(funcComputing);
                actions.Perform();
                Thread.Sleep(1000);

                var galaxyBook3Ultra = Driver.Instance.FindElement(By.CssSelector("#component-id > div.nv00-gnb__inner-wrap > div.nv00-gnb__l0-menu-wrap > ul.nv00-gnb__l0-menu-list.left-menu > li:nth-child(4) > div > div:nth-child(2) > ul > li:nth-child(3) > a"));
                galaxyBook3Ultra.Click();
                Thread.Sleep(1000);

                var buyBook3 = Driver.Instance.FindElement(By.CssSelector("#content > div > div > div > div > div.pd-g-floating-nav.aem-GridColumn.aem-GridColumn--default--12 > section > div > div > div.floating-navigation__header > div > div > a"));
                buyBook3.Click();
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                message += "ERROR!!" + e.Message;
            }
            message += ComputingMessage;
            return message;
        }

        public static string outlet()
        {
            string message = "",
            OutletMessage = "";

            try
            {
                var funcOutlet = Driver.Instance.FindElement(By.CssSelector("#component-id > div.nv00-gnb__inner-wrap > div.nv00-gnb__l0-menu-wrap > ul.nv00-gnb__l0-menu-list.left-menu > li:nth-child(9) > a"));
                funcOutlet.Click();
                Thread.Sleep(1000);

                var scrollOption = Driver.Instance.FindElement(By.CssSelector("#all-deals-gdc > div > div > div.Filters__container___1jbag > div.Filters__containerwarp___5o7Hs > div.Filters__nextArrow___38KPg > img"));
                scrollOption.Click();
                scrollOption.Click();
                scrollOption.Click();
                scrollOption.Click();
                scrollOption.Click();

                var cookingAppliances = Driver.Instance.FindElement(By.CssSelector("#filterContainer > div:nth-child(8) > div > div.Filters__imgWrapper___GF1S7 > img"));
                cookingAppliances.Click();
                Thread.Sleep(1000);

                var FAQ = Driver.Instance.FindElement(By.CssSelector("#faqs > section > div:nth-child(5) > p"));
                Actions actions = new Actions(Driver.Instance);
                actions.MoveToElement(FAQ);
                actions.Perform();
                Thread.Sleep(1000);
                FAQ.Click();
            }
            catch (Exception e)
            {
                message += "ERROR!!" + e.Message;
            }
            message += OutletMessage;
            return message;
        }

        public static string support()
        {
            string message = "",
            SupportMessage = "";

            try
            {
                var funcSupport = Driver.Instance.FindElement(By.CssSelector("#component-id > div.nv00-gnb__inner-wrap > div.nv00-gnb__l0-menu-wrap > ul.nv00-gnb__l0-menu-list.right-menu > li:nth-child(2) > button"));
                Actions actions = new Actions(Driver.Instance);
                actions.MoveToElement(funcSupport);
                actions.Perform();
                Thread.Sleep(1000);

                var ecoConscious = Driver.Instance.FindElement(By.CssSelector("#component-id > div.nv00-gnb__inner-wrap > div.nv00-gnb__l0-menu-wrap > ul.nv00-gnb__l0-menu-list.right-menu > li:nth-child(2) > div > div:nth-child(3) > ul > li:nth-child(6) > a"));
                ecoConscious.Click();
                Thread.Sleep(1000);

                var getSupport = Driver.Instance.FindElement(By.CssSelector("#contact-us > div > div > div > div.sp-g-contact-info__content-area > div.sp-g-contact-info__cta"));
                actions.MoveToElement(getSupport);
                actions.Perform();
                Thread.Sleep(1000);
                getSupport.Click();

            }
            catch (Exception e)
            {
                message += "ERROR!!" + e.Message;
            }
            message += SupportMessage;
            return message;
        }
    }
}