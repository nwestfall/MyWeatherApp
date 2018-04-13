using System;
using System.IO;
using OpenQA.Selenium.Remote;
using NUnit.Framework;

namespace MyWeather.Appium
{
    public class BaseTests
    {
        public BaseTests()
        {
        }

        public void TakeScreenshot(RemoteWebDriver driver, string filename, string description = null)
        {
            var screenshot = driver.GetScreenshot().AsByteArray;
            var filePath = Path.Combine(TestContext.CurrentContext.TestDirectory, filename);
            using (var fs = File.Create(filePath))
                fs.Write(screenshot, 0, screenshot.Length);
            TestContext.AddTestAttachment(filePath, description);
        }
    }
}
