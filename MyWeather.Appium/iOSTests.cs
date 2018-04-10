using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium.PageObjects;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Appium.iOS;
using System;
using System.Threading;
using System.IO;

namespace MyWeather.Appium
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class iOSTests : BaseTests
    {
        IOSDriver<IOSElement> driver;

        DesiredCapabilities capabilities;

        Elements elements;

        [OneTimeSetUp]
        public void Setup()
        {
            capabilities = Devices.iOS;
            Uri remoteUri = new Uri("http://localhost:4723/wd/hub");

            elements = new Elements();
            driver = new IOSDriver<IOSElement>(remoteUri, capabilities);
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
            
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver?.Quit();
        }
    }
}
