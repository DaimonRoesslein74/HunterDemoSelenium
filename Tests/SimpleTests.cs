using HunterDaimonTestProject.CoolStuff;
using HunterDaimonTestProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HunterDaimonTestProject.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [TearDown]
        public void Teardown()
        {

        }



        [Test]
        public void Test1()
        {
            GoogleHomePage homePage = new GoogleHomePage();
            homePage.Initialize();
            Assert.True(homePage.searchForStackOverflow());
            Thread.Sleep(10000);
        }
    }
}