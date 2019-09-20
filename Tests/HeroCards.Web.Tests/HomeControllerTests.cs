using HeroCards.Web.Controllers;
using HeroCards.Web.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace HeroCards.Web.Tests
{
    [TestCategory("HomeController Tests")]
    [TestClass]
    public class HomeControllerTests
    {
        HomeController ctrl;

        public HomeControllerTests()
        {
            ctrl = new HomeController();
        }

        [TestMethod]
        public void Index_Has_PopulateViewModel()
        {
            var result = ctrl.Index();
            var viewModel = ctrl.ViewData.Model as HomeIndexVm;
            Assert.AreEqual(8, viewModel.Heroes.Count());
            Assert.AreEqual(16, viewModel.Skills.Count());
            Assert.AreEqual(5, viewModel.Races.Count());
        }

    }
}
