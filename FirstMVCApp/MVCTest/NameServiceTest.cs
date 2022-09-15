using FirstMVCApp.Controllers;
using FirstMVCApp.Services;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace MVCTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(1)]
        [TestCase(0)]
        public void NameGetTest(int exp)
        {
            //Arrange
            NameRepo repo = new NameRepo();
            //action
            //repo.Add("Tim");
            var result = repo.Get();
            //assert
            Assert.AreEqual(exp, result.Count);
        }
        [Test]
        [TestCase(2)]
        public void HomeControllerTest(int exp)
        {
            //Arrange
            //NameRepo repo = new NameRepo();
            //repo.Add("Tim");
            Mock<IRepo> repoMoq = new Mock<IRepo>();
            repoMoq.Setup(r => r.Get()).Returns(new List<string>{ "Tim", "Vim" });
            HomeController hc = new HomeController(repoMoq.Object);
            //action
            var result = hc.Check();
            //assert
            Assert.AreEqual(exp, result.Count);
        }

    }
}