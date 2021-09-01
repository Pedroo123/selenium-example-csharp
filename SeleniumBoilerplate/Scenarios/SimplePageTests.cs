using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SeleniumBoilerplate.Scenarios
{
    public class SimplePageTests : IClassFixture<StartupFixture>
    {
        StartupFixture fixture;

        public SimplePageTests(StartupFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void AbrirNavegador()
        {
            var browser = fixture.InicializaDriver("chrome");

            browser.Navigate().GoToUrl("www.google.com");
        }
    }
}
