using AutomationPracticeTestProject.Flows;
using AutomationPracticeTestProject.Infrastructure.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationPracticeTestProject.Flows
{
    public class ContinueToSearchResultsPageWorkFlow : IWorkFlow
    {
        private SearchPage _searchPage;
        private SearchWorkFlow _searchWorkFlow;
        public void Initialize(IWebDriver webDriver)
        {
            _searchPage = new SearchPage(webDriver);
            _searchWorkFlow = new SearchWorkFlow();
            _searchWorkFlow.Initialize(webDriver);
        }
        private void FillSearchData()
        {
            _searchPage.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _searchPage.SearchQuery.SendKeys("dresses");
        }

        public SearchResultsPage Continue()
        {
            FillSearchData();
            return _searchPage.Continue();
        }
    }
}