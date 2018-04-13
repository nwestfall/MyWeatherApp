# This sample code uses the Appium python client
# pip install Appium-Python-Client
# Then you can paste this into a file and simply run with Python

from appium import webdriver
import time
from threading import Thread
import os
import unittest

class AndroidTest(unittest.TestCase):
    def setUp(self):
        caps = {}
        """
        Locally"""
        caps["automationName"] = "UiAutomator2"
        caps["platformName"] = "Android"
        caps["platformVersion"] = "8.1"
        caps["deviceName"] = "Essential PH1"
        caps["appPackage"] = "com.refractored.myweather"
        caps["appActivity"] = ".MainActivity"
        caps["noReset"] = True
        
        self.driver = webdriver.Remote("http://127.0.0.1:4723/wd/hub", caps)
        time.sleep(5)

    def test_getweathertest(self):
        el1 = self.driver.find_element_by_xpath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.support.v4.view.ViewPager/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.widget.Button")
        el1.click()
        time.sleep(5)
        directory = os.getenv('SCREENSHOT_PATH', '')
        file_name = 'Weather.png'
        self.driver.save_screenshot(directory + file_name)

    def test_getweatherforalbanytest(self):
        el1 = self.driver.find_element_by_xpath("//android.widget.EditText[@content-desc=\"LocationEntry\"]")
        el1.click()
        directory = os.getenv('SCREENSHOT_PATH', '')
        file_name = 'WeatherLocationEntry.png'
        self.driver.save_screenshot(directory + file_name)
        el1.clear()
        text = el1.get_attribute('text')
        assert text == ''
        el1.set_value('Albany, NY')
        text2 = el1.get_attribute('text')
        assert text2 == 'Albany, NY'
        el2 = self.driver.find_element_by_xpath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.support.v4.view.ViewPager/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[4]/android.widget.Button")
        el2.click()
        time.sleep(5)
        file_name = 'WeatherAlbany.png'
        self.driver.save_screenshot(directory + file_name)
    
    def tearDown(self):
        self.driver.quit()