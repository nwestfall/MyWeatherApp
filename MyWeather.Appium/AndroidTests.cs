using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.PageObjects;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Threading;
using System.IO;

namespace MyWeather.Appium
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class AndroidTests : BaseTests
    {
        AndroidDriver<AndroidElement> driver;

        DesiredCapabilities capabilities;

        Elements elements;

        [OneTimeSetUp]
        public void Setup()
        {
            capabilities = Devices.Android;
            Uri remoteUri = new Uri("http://localhost:4723/wd/hub");

            elements = new Elements();
            driver = new AndroidDriver<AndroidElement>(remoteUri, capabilities);
            PageFactory.InitElements(driver, elements, new AppiumPageObjectMemberDecorator());
        }

        [Test]
        public void GetWeatherTest()
        {
            elements.GetWeatherButton.Click();
            Thread.Sleep(5000);
            TakeScreenshot(driver, "Weather.jpg", "Weather Results");
        }

        [Test]
        public void GetWeatherForAlbanyTest()
        {
            elements.GetWeatherLocationEntry.Click();
            TakeScreenshot(driver, "WeatherLocationEntry.jpg", "Weather Location Entry with Keyboard");
            elements.GetWeatherLocationEntry.Clear();
            Assert.IsEmpty(elements.GetWeatherLocationEntry.Text);
            elements.GetWeatherLocationEntry.SendKeys("Albany, NY");
            Assert.AreEqual("Albany, NY", elements.GetWeatherLocationEntry.Text);
            elements.GetWeatherButton.Click();
            Thread.Sleep(5000);
            TakeScreenshot(driver, "WeatherAlbany.jpg", "Weather Results for Albany");
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver?.Quit();
        }
    }
}
