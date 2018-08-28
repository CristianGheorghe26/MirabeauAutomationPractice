using OpenQA.Selenium;

namespace AutomationPracticeTestProject.Infrastructure.Pages
{
    public class SearchPage : PageElements
    {
        private string Url;
        public SearchPage(IWebDriver webDriver)
        {
            driver = webDriver;
        }
        public IWebElement SearchQuery => driver.FindElement(By.XPath("//*[@id='search_query_top']"));
        public IWebElement SearchButton => driver.FindElement(By.XPath("//*[@id='searchbox']/button"));
        public SearchResultsPage Continue()
        {
            Click(SearchButton);
            return new SearchResultsPage(ref driver);
        }
        private void Click(IWebElement button)
        {
            button.Click();
        }
    }
}