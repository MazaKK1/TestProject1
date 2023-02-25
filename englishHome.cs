using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Testing
{
    public class englishHome
    {
        public static string homepage(string EHome)
        {
            string message = "",
            homePageMessage = "";

            try
            {
                var google = Driver.Instance.FindElement(By.Name("q"));
                google.Click();
                google.SendKeys(EHome);
                google.SendKeys(Keys.Enter);
                Thread.Sleep(1000);

                var englishHomePage = Driver.Instance.FindElement(By.CssSelector("#rso > div:nth-child(1) > div > div > div > div > div > div > div.yuRUbf > a > h3"));
                englishHomePage.Click();
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                message += "ERROR!!" + e.Message;
            }
            message += homePageMessage;
            return message;
        }

        public static string functionalities()
        {
            string message = "",
            functionalitiesMessage = "";

            try
            {
                var functionBedroom = Driver.Instance.FindElement(By.XPath("/html/body/div[4]/header/div[2]/div/div/div/ul/li[1]/a"));
                functionBedroom.Click();
                Thread.Sleep(1000);

                var functionKitchen = Driver.Instance.FindElement(By.XPath("/html/body/div[4]/header/div[2]/div/div/div/ul/li[2]/a"));
                functionKitchen.Click();
                Thread.Sleep(1000);

                var functionBathroom = Driver.Instance.FindElement(By.XPath("/html/body/div[4]/header/div[2]/div/div/div/ul/li[3]/a"));
                functionBathroom.Click();
                Thread.Sleep(1000);

                var functionDecorations = Driver.Instance.FindElement(By.XPath("/html/body/div[4]/header/div[2]/div/div/div/ul/li[4]/a"));
                functionDecorations.Click();
                Thread.Sleep(1000);

                var functionCosmetics = Driver.Instance.FindElement(By.XPath("/html/body/div[4]/header/div[2]/div/div/div/ul/li[5]/a"));
                functionCosmetics.Click();
                Thread.Sleep(1000);

                var functionLivingroom = Driver.Instance.FindElement(By.XPath("/html/body/div[4]/header/div[2]/div/div/div/ul/li[6]/a"));
                functionLivingroom.Click();
                Thread.Sleep(1000);

                var fundtionCarpets = Driver.Instance.FindElement(By.XPath("/html/body/div[4]/header/div[2]/div/div/div/ul/li[7]/a"));
                fundtionCarpets.Click();
                Thread.Sleep(1000);

                var functionKids = Driver.Instance.FindElement(By.XPath("/html/body/div[4]/header/div[2]/div/div/div/ul/li[8]/a"));
                functionKids.Click();
                Thread.Sleep(1000);

                var functionClothes = Driver.Instance.FindElement(By.XPath("/html/body/div[4]/header/div[2]/div/div/div/ul/li[9]/a"));
                functionClothes.Click();
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                message += "ERROR!!" + e.Message;
            }
            message += functionalitiesMessage;
            return message;
        }

        public static string decorations()
        {
            string message = "",
            decorationsMessage = "";

            try
            {
                var elementDecorations = Driver.Instance.FindElement(By.XPath("/html/body/div[4]/header/div[2]/div/div/div/ul/li[4]/a"));
                Actions actions = new Actions(Driver.Instance);
                actions.MoveToElement(elementDecorations);
                actions.Perform();
                Thread.Sleep(1000);

                var mirros = Driver.Instance.FindElement(By.XPath("/html/body/div[4]/header/div[2]/div/div/div/ul/li[4]/div/div/div/div[1]/div/div/div/div[3]/div/div/div/div/ul/li[1]/a"));
                mirros.Click();
                Thread.Sleep(1000);

                var selectMirror = Driver.Instance.FindElement(By.CssSelector("body > div.website-wrapper > div.main-page-wrapper > div > div > div > div.products.elements-grid.basel-products-holder.title-line-two.pagination-pagination.row.grid-columns-3 > div.product-grid-item.basel-hover-quick.product.col-sm-4.col-xs-6.type-product.post-27520.status-publish.instock.product_cat-ogledala.product_tag-disc_dec_2022.product_tag-disc_feb_2023.product_tag-disc_nov_2022.product_tag-disc_oct_2022.has-post-thumbnail.taxable.shipping-taxable.purchasable.product-type-simple > div.product-element-top > div.hover-img > a > img"));
                selectMirror.Click();
                Thread.Sleep(1000);

                var buyMirror = Driver.Instance.FindElement(By.CssSelector("#product-27520 > div:nth-child(1) > div > div > div > div.col-sm-6.summary.entry-summary > div > div > form > button"));
                buyMirror.Click();
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                message += "ERROR!!" + e.Message;
            }
            message += decorationsMessage;
            return message;
        }

        public static string leaveBasket()
        {
            string message = "",
            basketMessage = "";

            try
            {
                var leaveBasket = Driver.Instance.FindElement(By.CssSelector("body > div.basel-close-side"));
                leaveBasket.Click();
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                message += "ERROR!!" + e.Message;
            }
            message += basketMessage;
            return message;
        }

        public static string carpets()
        {
            string message = "",
            carpetsMessage = "";

            try
            {
                var fundtionCarpets = Driver.Instance.FindElement(By.XPath("/html/body/div[4]/header/div[2]/div/div/div/ul/li[7]/a"));
                fundtionCarpets.Click();
                Thread.Sleep(1000);

                var carpetsFilterByMaxPrice = Driver.Instance.FindElement(By.CssSelector("#basel-woocommerce-sort-by-2 > form > ul > li:nth-child(4) > a"));
                carpetsFilterByMaxPrice.Click();
                Thread.Sleep(1000);

                var carpetsChangeView = Driver.Instance.FindElement(By.CssSelector("#list-view"));
                carpetsChangeView.Click();
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                message += "ERROR!!" + e.Message;
            }
            message += carpetsMessage;
            return message;
        }

        internal static string bedroom()
        {
            string message = "",
            bedroomMessage = "";

            try
            {
                var elementBedroom = Driver.Instance.FindElement(By.XPath("/html/body/div[4]/header/div[2]/div/div/div/ul/li[1]/a"));
                Actions actions = new Actions(Driver.Instance);
                actions.MoveToElement(elementBedroom);
                actions.Perform();
                Thread.Sleep(1000);

                var bedroomCovers = Driver.Instance.FindElement(By.XPath("/html/body/div[4]/header/div[2]/div/div/div/ul/li[1]/div/div/div/div[1]/div/div/div/div[3]/div/div/div/div/ul/li[5]/a/strong"));
                bedroomCovers.Click();
                Thread.Sleep(1000);

                var coversRandom = Driver.Instance.FindElement(By.CssSelector("#basel-woocommerce-sort-by-2 > form > ul > li:nth-child(5) > a"));
                coversRandom.Click();
                Thread.Sleep(1000);

                var bedroom = Driver.Instance.FindElement(By.XPath("/html/body/div[4]/header/div[2]/div/div/div/ul/li[1]/a"));
                bedroom.Click();
                Thread.Sleep(1000);

                var bedProtection = Driver.Instance.FindElement(By.CssSelector("body > div.website-wrapper > div.main-page-wrapper > div > div > div > div.products.elements-grid.basel-products-holder.elements-list.pagination-pagination.row.grid-columns-3 > div.product-grid-item.product-list-item.product.col-xs-12.first.last.type-product.post-1716.status-publish.last.instock.product_cat-nadmadraci.product_tag-160x200-cm.product_tag-disc_dec_2022.product_tag-disc_feb_2023.product_tag-disc_nov_2022.product_tag-disc_oct_2022.product_tag-timeless.has-post-thumbnail.taxable.shipping-taxable.purchasable.product-type-simple > div.product-list-content > div.product-list-buttons > a"));
                bedProtection.Click();
                Thread.Sleep(1000);

                var seeBasket = Driver.Instance.FindElement(By.CssSelector("body > div.cart-widget-side > div.widget.woocommerce.widget_shopping_cart > div > p.woocommerce-mini-cart__buttons.buttons > a.button.btn-cart.wc-forward"));
                seeBasket.Click();
                Thread.Sleep(1000);

                var removeProduct1 = Driver.Instance.FindElement(By.CssSelector("#post-10 > div > div > form > div.responsive-table > table > tbody > tr:nth-child(1) > td.product-remove > a"));
                removeProduct1.Click();
                Thread.Sleep(1000);
                var removeProduct2 = Driver.Instance.FindElement(By.CssSelector("#post-10 > div > div > form > div.responsive-table > table > tbody > tr > td.product-remove > a"));
                removeProduct2.Click();
                Thread.Sleep(1000);

                var backToStore = Driver.Instance.FindElement(By.CssSelector("#post-10 > div > div > p.return-to-shop > a"));
                backToStore.Click();
                Thread.Sleep(1000);
            }
            catch (Exception e)
            {
                message += "ERROR!!" + e.Message;
            }
            message += bedroomMessage;
            return message;
        }
    }
}