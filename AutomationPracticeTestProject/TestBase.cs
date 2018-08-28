using AutomationPracticeTestProject.Flows;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        [TestCleanup()]
        public void Cleanup()
        {
            webDriver.Quit();
        }
    }
}