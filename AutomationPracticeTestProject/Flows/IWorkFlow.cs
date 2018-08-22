using OpenQA.Selenium;

namespace AutomationPracticeTestProject.Flows
{
    public interface IWorkFlow
    {
        void Initialize(IWebDriver webDriver);
    }
}