using OpenQA.Selenium;
using SeleniumBoilerplate.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SeleniumBoilerplate.Scenarios
{
    public class SimplePageTests : IClassFixture<StartupFixture>
    {
        StartupFixture fixture;
        IWebDriver browser;
        public SimplePageTests(StartupFixture fixture)
        {
            this.fixture = fixture;
            browser = fixture.InicializaDriver("chrome");
        }

        [Fact]
        public void AbrirNavegadorEFazerValidacao()
        {
            #region Navega até a tela
            browser.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_loading/1");
            #endregion

            #region Clica no elemento e faz a validação
            #endregion
        }
    }
}
