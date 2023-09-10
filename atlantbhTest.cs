namespace Testing
{
    [TestClass]
    public class atlantbhTest
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

            string HomePageMessage = atlantbh.Homepage("AtlantBH");
            string FunctionalitiesMessage = atlantbh.Functionalities();
            string SearchMessage = atlantbh.Search("QA");
            string ServicesMessage = atlantbh.Services();
            string CareersMessage = atlantbh.Careers();

            if (!HomePageMessage.Contains("ERROR") && (!FunctionalitiesMessage.Contains("ERROR")) && (!SearchMessage.Contains("ERROR")) && (!ServicesMessage.Contains("ERROR")) && (!CareersMessage.Contains("ERROR")))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prošao" + "\n" + HomePageMessage + FunctionalitiesMessage + SearchMessage + ServicesMessage + CareersMessage;
            }
            else
            {
                subject = "Failed!!! " + subject;
                body = HomePageMessage + FunctionalitiesMessage + SearchMessage + ServicesMessage + CareersMessage;
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