﻿using AutomationPracticeTestProject.Flows;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationPracticeTestProject.AutomationPractice
{
    [TestClass]
    public class SearchPageTest : TestBase<ContinueToSearchResultsPageWorkFlow>
    {
        [TestMethod]
        public void SearchPage()
        {
            _sut.Continue().IsActive("automationpractice.com/index.php?controller=search&orderby=position&orderway=desc&search_query=dresses&submit_search=").Should().BeTrue("Cannot reach search results page.");
        }
    }
}