using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace ExerciseTest
{
    [TestClass]
    public class Exercise
    {
        [TestMethod]
        public void Exercise2()
        {
            //Initialize the firefox driver
            using (var driver = new FirefoxDriver())
            {
                //MAximize the browser
                driver.Manage().Window.Maximize();

                //go to the "Google" homepage
                driver.Navigate().GoToUrl("https://www.google.com");

                // Printing title on Console
                System.Diagnostics.Debug.WriteLine("Title of the page is : " + driver.Title.ToString());
                // Printing URL on Console
                System.Diagnostics.Trace.WriteLine("URL of the page is : " + driver.Url.ToString());
                // Printing Source on Console
                System.Diagnostics.Trace.WriteLine("Source of the page is : " + driver.PageSource.ToString());
                System.Threading.Thread.Sleep(500);
            }
        }

        [TestMethod]
        public void Exercise3()
        {
            //Initialize the firefox driver
            using (var driver = new ChromeDriver())
            {
                //MAximize the browser
                driver.Manage().Window.Maximize();

                //go to the "Google" homepage
                driver.Navigate().GoToUrl("https://www.google.com");
                
                // Printing URL on Console
                System.Diagnostics.Trace.WriteLine("URL of the page is : " + driver.Url.ToString());
                System.Threading.Thread.Sleep(50);

                //go to the "Amazon" homepage
                driver.Navigate().GoToUrl("https://www.amazon.com.mx/");
                System.Diagnostics.Trace.WriteLine("URL of the page is : " + driver.Url.ToString());
                System.Threading.Thread.Sleep(50);

                //go to the "Mercadolibre" homepage
                driver.Navigate().GoToUrl("https://www.mercadolibre.com.mx/");
                System.Diagnostics.Trace.WriteLine("URL of the page is : " + driver.Url.ToString());
                System.Threading.Thread.Sleep(50);

                driver.Navigate().Back();
                driver.Navigate().Back();
                System.Diagnostics.Trace.WriteLine("URL of the page is : " + driver.Url.ToString());
                System.Threading.Thread.Sleep(50);

                driver.Navigate().Forward();
                System.Diagnostics.Trace.WriteLine("URL of the page is : " + driver.Url.ToString());
                System.Threading.Thread.Sleep(50);

                driver.Navigate().Refresh();
                System.Diagnostics.Trace.WriteLine("URL of the page is : " + driver.Url.ToString());
                System.Threading.Thread.Sleep(50);
            }
        }

        [TestMethod]
        public void LoginExercise()
        {
            //Initialize the firefox driver
            using (var driver = new ChromeDriver())
            {
                //MAximize the browser
                driver.Manage().Window.Maximize();

                //go to the "Google" homepage
                driver.Navigate().GoToUrl("https://github.com/login");

                var Username = driver.FindElementByXPath("//input[@id='login_field']");
                var Password = driver.FindElementByXPath("//input[@id='password']");

                Username.SendKeys("antoniocarrazco55@gmail.com");
                Password.SendKeys("1dos3AnTONIO#%");
                System.Threading.Thread.Sleep(50);

                var Loginbtn = driver.FindElementByXPath("//input[@name='commit']");
                Loginbtn.Submit();
                System.Threading.Thread.Sleep(5000);
            }
        }

        [TestMethod]
        public void SearchAmazon()
        {
            //Initialize the firefox driver
            using (var driver = new ChromeDriver())
            {
                //MAximize the browser
                driver.Manage().Window.Maximize();

                //go to the "Google" homepage
                driver.Navigate().GoToUrl("https://www.amazon.com.mx/");
                System.Threading.Thread.Sleep(10000);

                var Searchbox = driver.FindElementByXPath("//input[@id='twotabsearchtextbox']");
                Searchbox.SendKeys("Selenium");

                var Searchbtn = driver.FindElementByXPath("//input[@value='Ir']");
                Searchbtn.Submit();

                System.Threading.Thread.Sleep(10000);
            }
        }
    }
}
