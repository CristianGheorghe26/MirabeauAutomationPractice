using System;
using OpenQA.Selenium;

namespace AutomationPracticeTestProject.Infrastructure.Pages
{
    public class SearchResultsPage : PageElements
    {
        public SearchResultsPage(ref IWebDriver webDriver)
        {
            driver = webDriver;
        }
        public IWebElement SearchResultsPresent => driver.FindElement(By.XPath("//*[@id='center_column']/h1/span[2]"));

        public object SearchQuery { get; internal set; }

        public bool AreProductsAvailable()
        {
            try
            {
                driver.FindElement(By.XPath("//*[@id='center_column']/h1/span[2]"));
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        internal SearchResultsPage Continue()
        {
            throw new NotImplementedException();
        }
    }
}