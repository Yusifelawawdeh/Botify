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
            chromeDriver.Navigate().GoToUrl("https://reddit.com");

            var titles = chromeDriver.FindElementsByClassName("title");

            foreach (var title in titles)
            {
                Console.WriteLine(title.Text);
            }

        }
    }
}
