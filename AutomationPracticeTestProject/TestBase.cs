using AutomationPracticeTestProject.Flows;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationPracticeTestProject
{
    public abstract class TestBase<SUT> where SUT : class, IWorkFlow, new()
    {
        protected SUT _sut => BuildSut();
        protected IWebDriver webDriver;
        private SUT BuildSut()
        {
            var sut = new SUT();
            webDriver = new ChromeDriver();
            sut.Initialize(webDriver);
            return sut;
        }
        public TestBase()
        {
        }
    }
}