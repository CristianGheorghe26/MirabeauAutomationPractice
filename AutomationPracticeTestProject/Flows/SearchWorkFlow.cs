using AutomationPracticeTestProject.Flows;
using AutomationPracticeTestProject.Infrastructure.Pages;
using OpenQA.Selenium;

namespace AutomationPracticeTestProject.Flows
{
    public class SearchWorkFlow : IWorkFlow
    {
        private SearchPage _searchPage;

        public void Initialize(IWebDriver webDriver)
        {
            _searchPage = new SearchPage(webDriver);
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://automationpractice.com");
        }
        public SearchPage Continue()
        {
            _searchPage.Continue();
            return _searchPage;
        }
    }
}