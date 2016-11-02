using System.Web.Mvc;
using HiTeamCity.Controllers;
using NUnit.Framework;

namespace HiTeamCity.Test.Unit
{
    [TestFixture]
    public class HomePageTest
    {
        private HomeController  _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new HomeController();
        }

        [Test]
        public void GetHomePage()
        {
            var actual = _sut.Index() as ViewResult;
            if (actual != null)
            {
                Assert.That(actual.ViewName, Is.EqualTo(string.Empty));
            }
        }

        [Test]
        public void GetAboutPage()
        {
            var actual = _sut.About() as ViewResult;
            if (actual != null)
            {
                Assert.That(actual.ViewBag.Message, Is.EqualTo("Your application description page."));
            }
        }
    }
}