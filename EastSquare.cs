namespace Testing
{
    [TestClass]
    public class EastSquare
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

            string HomePage = eastsquaresite.home("east square");
            string Functionalities = eastsquaresite.func();

            if (!HomePage.Contains("ERROR") && (!Functionalities.Contains("ERROR")))
            {
                subject = "Passed!!! " + subject;
                body = "Test je prošao" + "\n" + HomePage + Functionalities;
            }
            else
            {
                subject = "Failed!!! " + subject;
                body = HomePage + Functionalities;
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