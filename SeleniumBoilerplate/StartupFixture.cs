using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;
using Xunit;

namespace SeleniumBoilerplate
{
    public class StartupFixture : IDisposable
    {
        IWebDriver _driver;

        public IWebDriver InicializaDriver(string? browser)
        {
            switch (browser)
            {
                case "chrome":
                    _driver = new ChromeDriver();
                    break;
                case "firefox":
                    _driver = new FirefoxDriver();
                    break;
                default:
                    _driver = new ChromeDriver(Path.Combine($"{Directory.GetCurrentDirectory()}\\Drivers"));
                    break;
            }

            return _driver;
        }

        public void Dispose()
        {
            Screenshot screenshot = (_driver as ITakesScreenshot).GetScreenshot();

            string screenshotDir = Path.Combine($"{Directory.GetCurrentDirectory()}\\Evidencias");

            if(!Directory.Exists(screenshotDir))
            {
                Directory.CreateDirectory(screenshotDir);
            }

            //screenshot.SaveAsFile($"{screenshotDir}{DateTime.Now}", ScreenshotImageFormat.Png);

            _driver.Quit();
        }
    }
}
