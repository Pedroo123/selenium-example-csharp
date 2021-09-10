using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumBoilerplate.PageObjects
{
    public static class SimplePage
    {
        public static readonly By botaoStart = By.CssSelector("#start > button");

        public static readonly By finishedWord = By.CssSelector("#finish > h4");
    }
}
