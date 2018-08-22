using AutomationPracticeTestProject.Infrastructure.Pages;
using OpenQA.Selenium;

namespace AutomationPracticeTestProject.Infrastructure.Pages
{
    public class SearchResultsPage : PageElements
    {
        public SearchResultsPage(ref IWebDriver webDriver)
        {
            driver = webDriver;
        }
        //public void Go()
        //{
        //}
    }
}