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
        SimplePage simplePage;
        IWebDriver browser;
        public SimplePageTests(StartupFixture fixture)
        {
            this.fixture = fixture;
            browser = fixture.InicializaDriver("");
        }

        [Fact]
        public void AbrirNavegadorEFazerValidacao()
        {
            simplePage = new SimplePage(fixture);
            #region Navega até a tela
            browser.Navigate().GoToUrl("https://the-internet.herokuapp.com/dynamic_loading/1");
            #endregion

            #region Clica no elemento e faz a validação
            simplePage.validaCampos();
            #endregion
        }
    }
}
