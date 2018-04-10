using System;

using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.PageObjects.Attributes;

namespace MyWeather.Appium
{
    public class Elements
    {
        [FindsByAndroidUIAutomator(XPath = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.support.v4.view.ViewPager/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.widget.Button")]
        [FindsByIOSUIAutomation(XPath = "//XCUIElementTypeStaticText[@name=\"Get Weather\"]")]
        public IMobileElement<AppiumWebElement> GetWeatherButton;
    }
}
