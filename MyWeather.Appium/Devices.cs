using System;

using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;

namespace MyWeather.Appium
{
    public static class Devices
    {
        public static DesiredCapabilities Android
        {
            get
            {

                DesiredCapabilities androidCapabilities = new DesiredCapabilities();
                androidCapabilities.SetCapability("platformName", "Android");
                androidCapabilities.SetCapability("platformVersion", "8.1");
                androidCapabilities.SetCapability("deviceName", "Essential PH1");
                androidCapabilities.SetCapability("automationName", "UiAutomator2");
                androidCapabilities.SetCapability("appPackage", "com.refractored.myweather");
                androidCapabilities.SetCapability("appActivity", ".MainActivity");
                androidCapabilities.SetCapability("noReset", true);
                return androidCapabilities;
            }
        }

        public static DesiredCapabilities iOS
        {
            get
            {
                DesiredCapabilities iosCapabilities = new DesiredCapabilities();
                iosCapabilities.SetCapability("platformName", "iOS");
                iosCapabilities.SetCapability("platformVersion", "11.2");
                iosCapabilities.SetCapability("deviceName", "iPhone Simulator");
                iosCapabilities.SetCapability("automationName", "XCUITest");
                iosCapabilities.SetCapability("bundleId", "com.refractored.myweather");
                iosCapabilities.SetCapability("udid", "2AC3422C-028A-4FDC-81D4-56E9B8EDC84E");
                return iosCapabilities;
            }
        }
    }
}
