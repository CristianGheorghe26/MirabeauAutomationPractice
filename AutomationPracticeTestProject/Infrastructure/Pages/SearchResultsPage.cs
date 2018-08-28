using OpenQA.Selenium;

namespace AutomationPracticeTestProject.Infrastructure.Pages
{
    public class SearchResultsPage : PageElements
    {
        public SearchResultsPage(ref IWebDriver webDriver)
        {
            driver = webDriver;
        }
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
    }
}