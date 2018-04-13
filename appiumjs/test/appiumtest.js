// Requires the webdriverio client library
// (npm install webdriverio)
// Then paste this into a .js file and run with Node:
// node <file>.js

const assert = require('assert');
const wdio = require('webdriverio');
const caps = {"platformName":"iOS","platformVersion":"11.2","deviceName":"iPhone Simulator","automationName":"XCUITest","bundleId":"com.refractored.myweather","udid":"2AC3422C-028A-4FDC-81D4-56E9B8EDC84E"};
//const caps = {"automationName":"UiAutomator2","platformName":"Android","platformVersion":"8.1","deviceName":"Essential PH1","appPackage":"com.refractored.myweather","appActivity":".MainActivity","noReset":true};
const driver = wdio.remote({
  protocol: "http",
  host: "localhost",
  port: 4723,
  path: "/wd/hub",
  desiredCapabilities: caps
});

describe('Weather Tests', function() {
  describe('Get Weather', function() {
    it('should load the weather for the entered city', function(done) {
      this.timeout(30000);
      driver.init()
        .element("//XCUIElementTypeButton[@name=\"Get Weather\"]")
        .click()
        .pause(5000)
        .screenshot()
        .saveScreenshot("Weather.jpg")
        .closeApp().then(() => {
          done();
        })
    });
  });
});






















/*
driver.init()
        .element("//XCUIElementTypeButton[@name=\"Get Weather\"]")
        .click()
        .pause(5000)
        .screenshot()
        .saveScreenshot("Weather.jpg")
        .closeApp().then(() => {
          done();
        })
        */