using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Botify
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var options = new ChromeOptions();
            //options.AddArguments("--disable-gpu");

            var chromeDriver = new ChromeDriver();
            chromeDriver.Navigate().GoToUrl("http://petrowiki.org");

            chromeDriver.FindElementByXPath("//*[@id=\"searchInput\"]").Clear();
            chromeDriver.Keyboard.SendKeys("geophysics");
            chromeDriver.Keyboard.SendKeys(Keys.Enter);

            var titles = chromeDriver.FindElementsByClassName("mw-search-result-heading");

            foreach (var title in titles)
            {
                Console.WriteLine(title.Text);
            }

        }
    }
}
