using AutomationPracticeTestProject.Flows;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationPracticeTestProject.AutomationPractice
{
    [TestClass]
    public class SearchResultsPageTest : TestBase<ContinueToSearchResultsPageWorkFlow>
    {
        [TestMethod]
        public void SearchResultsPage()
        {
            _sut.Continue().AreProductsAvailable().Should().BeTrue("No products are available");
        }
    }
}
