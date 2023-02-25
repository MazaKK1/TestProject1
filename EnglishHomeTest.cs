namespace Testing
{
    [TestClass]
    public class EnglishHomeTest
    {
        [TestInitialize]
        public void Init()
        {
            TestArguments parameters = new TestArguments();

            int a = int.Parse(parameters.browser);

            Driver.Initialize(a);
        }
        [TestMethod]
        public void TestMethod1()
        {
            string subject = "";
            string body = "";
            TestArguments parameters = new TestArguments();
            string URL = parameters.url;

            OpenUrl.GoTo(URL);

            string homePageMessage = englishHome.homepage("English Home");

            string functionalitiesMessage = englishHome.functionalities();

            string decorationsMesssage = englishHome.decorations();

            string basketMessage = englishHome.leaveBasket();

            string carpetsMessage = englishHome.carpets();

            string bedroomMessage = englishHome.bedroom();
            

            if (!homePageMessage.Contains("ERROR") && (!functionalitiesMessage.Contains("ERROR")) && (!decorationsMesssage.Contains("ERROR")) && (!carpetsMessage.Contains("ERROR")) && (!bedroomMessage.Contains("ERROR")))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prošao" + "\n" + homePageMessage + functionalitiesMessage + decorationsMesssage + carpetsMessage + bedroomMessage;
            }
            else
            {
                subject = "Failed!!! " + subject;
                body = homePageMessage + functionalitiesMessage + decorationsMesssage + carpetsMessage + bedroomMessage;
            }

            Functions.SendEmailAttachment(subject, body);

            Assert.IsTrue(subject.Contains("Passed"));
            Assert.IsFalse(subject.Contains("Failed"));
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
 }