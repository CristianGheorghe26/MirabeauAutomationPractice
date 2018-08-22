using OpenQA.Selenium;

namespace AutomationPracticeTestProject.Infrastructure.Pages
{
    public abstract class PageElements
    {
        public IWebDriver driver;
        public bool IsActive(string Url)
        {
            return driver.Url.EndsWith(Url);
        }
    }
}