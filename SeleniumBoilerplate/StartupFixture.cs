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
        private char separador = Path.PathSeparator;

        public IWebDriver InicializaDriver(string browser)
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
                    Console.WriteLine("Browser não é suportado!");
                    break;
            }

            return _driver;
        }

        public void Dispose()
        {
            Screenshot screenshot = (_driver as ITakesScreenshot).GetScreenshot();

            string ScreenshotDir = Path.Combine($"{Directory.GetCurrentDirectory()}{separador}Evidencias");

            screenshot.SaveAsFile($"{ScreenshotDir}{DateTime.Now}", ScreenshotImageFormat.Png);

            _driver.Quit();
        }
    }
}
