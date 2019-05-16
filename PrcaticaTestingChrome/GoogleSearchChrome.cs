using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace PrcaticaTestingChrome
{

    [TestClass]
    class GoogleSearchChrome
    {
        [TestMethod]
        public void Should_Search_Using_Chrome()
        {
            //Initialize the firefox driver
            using (var driver = new ChromeDriver())
            {
                //MAximize the browser
                driver.Manage().Window.Maximize();

                //go to the "Google" homepage
                driver.Navigate().GoToUrl("https://www.google.com");

                //Find the search texbox (by ID) on the homepage
                //var searchbox = driver.FindElementByName("q");
                var searchbox = driver.FindElementByXPath("//input[@name='q']");

                //Enter the text (to search for) in the textbox
                searchbox.SendKeys("Automation using selenium 3.0 in C#");

                //find the search button (by Name) on the homepage
                var searchbutton = driver.FindElementByXPath("/html/body/div/div/form/div/div/div/center/input[@name='btnK']");

                //clcik "Submit" to start the search
                searchbutton.Submit();
                System.Threading.Thread.Sleep(5000);
                //Find the id of the div containing result stats,
                //located just above the results table
                var searchResult = driver.FindElementById("resultStats");
            }
        }
    }
}
