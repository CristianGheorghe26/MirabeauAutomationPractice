using OpenQA.Selenium;

namespace AutomationPracticeTestProject.Flows
{
    public class SearchResultsWorkFlow : IWorkFlow
    {
        private SearchResultsWorkFlow _searchresultsPage;
        private ContinueToSearchResultsPageWorkFlow _continueToSearchResultsPageWorkFlow;
        public void Initialize(IWebDriver webDriver)
        {
            _continueToSearchResultsPageWorkFlow = new ContinueToSearchResultsPageWorkFlow();
            _continueToSearchResultsPageWorkFlow.Initialize(webDriver);
        }
    }
}