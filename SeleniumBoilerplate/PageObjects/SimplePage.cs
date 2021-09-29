using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SeleniumBoilerplate.PageObjects
{
    public class SimplePage : IClassFixture<StartupFixture>
    {
        IWebDriver driver;
        StartupFixture fixture;
        private By btnStart = By.CssSelector("#start > button");
        private By lblFinish = By.CssSelector("#finish > h4");

        public SimplePage(StartupFixture fixture)
        {
            this.fixture = fixture;
            driver = fixture.InicializaDriver("");
        }
        /* 
         * Valida a existencia do elemento lblFinish
         * @return Boolean
         */
        public void validaCampos()
        {
            driver.FindElement(btnStart).Click();
            driver.FindElement(lblFinish);

            return;
        }
    }
}
