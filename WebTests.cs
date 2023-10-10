using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    [TestFixture]
    public class WebTests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test_GoogleSearch()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            var searchBox = driver.FindElement(By.Name("q"));
            searchBox.SendKeys("OpenAI");
            searchBox.Submit();
            Assert.IsTrue(driver.Title.Contains("OpenAI"));
        }

        [TearDown]
        public void Close()
        {
            driver.Close();
        }
    }
}
