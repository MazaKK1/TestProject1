namespace Testing
{
    [TestClass]
    public class SamsungTest
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

            string HomepageMessage = samsung.homepage("samsung.com");

            string FunctionalitiesMessage = samsung.functionalities();

            string MobileMessage = samsung.mobile();

            string ComputingMessage = samsung.computing();

            string OutletMessage = samsung.outlet();

            string SupportMessage = samsung.support();

            if (!HomepageMessage.Contains("ERROR") && (!FunctionalitiesMessage.Contains("ERROR")) && (!MobileMessage.Contains("ERROR")) && (!ComputingMessage.Contains("ERROR")) && (!OutletMessage.Contains("ERROR")) && (!SupportMessage.Contains("ERROR")))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prošao" + "\n" + HomepageMessage + FunctionalitiesMessage + MobileMessage + ComputingMessage + OutletMessage + SupportMessage;
            }
            else
            {
                subject = "Failed!!! " + subject;
                body = HomepageMessage + FunctionalitiesMessage + MobileMessage + ComputingMessage + OutletMessage + SupportMessage;
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