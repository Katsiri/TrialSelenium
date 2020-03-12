using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guru99
{
    class Guru99Demo
    {
        //IWebDriver driver;
        IWebDriver m_driver;

        //[Test]
        //public void cssDemo()
        //{
        //    m_driver = new ChromeDriver("D:\\1_Work\\6_C#_NET\\chromedriver");
        //    m_driver.Url = "http://demo.guru99.com/test/guru99home/";
        //    m_driver.Manage().Window.Maximize();
        //    IWebElement link = m_driver.FindElement(By.XPath(".//*[@id='rt-header']//div[2]/div/ul/li[2]/a"));
        //    link.Click();
        //    m_driver.Close();
        //}

        [Test]
        public void cssDemo2()
        {
            m_driver = new ChromeDriver("D:\\1_Work\\6_C#_NET\\chromedriver");
            m_driver.Url = "http://demo.guru99.com/test/guru99home/";
            m_driver.Manage().Window.Maximize();


            // Store locator values of email text box and sign up button				
            IWebElement emailTextBox = m_driver.FindElement(By.XPath(".//*[@id='philadelphia-field-email']"));
            IWebElement signUpButton = m_driver.FindElement(By.XPath(".//*[@id='philadelphia-field-submit']"));

            emailTextBox.SendKeys("test123@gmail.com");
            signUpButton.Click();

            //IWebElement element = m_driver.FindElement(By.XPath("xpath of Webelement"));
            //Boolean status = element.Displayed;

            //if (m_driver.FindElement(By.CssSelector("a > font")).Displayed)
            //{
            //    System.Console.WriteLine("Element is Visible");
            //}
            //else
            //{
            //    System.Console.WriteLine("Element is InVisible");
            //}

        }

        [Test]
        public void testLoginOS()
        {
            m_driver = new ChromeDriver("D:\\1_Work\\6_C#_NET\\chromedriver");
            m_driver.Url = "https://katsiri-katsin.outsystemscloud.com/ExWeb/";
            m_driver.Manage().Window.Maximize();


            // Store locator values of email text box and sign up button				
            //IWebElement emailTextBox = m_driver.FindElement(By.XPath(".//*[@id='philadelphia-field-email']"));
            IWebElement LoginButton = m_driver.FindElement(By.CssSelector(".seleniumLoginButton"));

            //emailTextBox.SendKeys("test123@gmail.com");
            LoginButton.Click();

            var wait = new WebDriverWait(m_driver, TimeSpan.FromSeconds(10));
            wait.Until(m_driver => m_driver.FindElement(By.XPath(".//div[@class='Feedback_Message_Error']")).Displayed);

            IWebElement Message = m_driver.FindElement(By.XPath(".//div[@class='Feedback_Message_Error']"));
            Boolean status = Message.Displayed;
            Assert.That(status == true);

            //bool isfound = m_driver.PageSource.Contains("invalid");
            //IWebElement errorMsg = m_driver.FindElement(By.CssSelector(".Feedback_Message_Error"));
            //WebDriverWait defaultWait = new WebDriverWait(m_driver, TimeSpan.FromSeconds(30));
            //defaultWait.Until(
            //                   m_driver.FindElement(By.CssSelector(".Feedback_Message_Error"))
            //                   );

            //bool isfound = m_driver.FindElement(By.CssSelector(".Feedback_Message_Error")).Displayed;
            //IWebElement errorMsg = m_driver.FindElement(By.CssSelector(".Feedback_Message_Error"));
            //if (errorMsg.Displayed)
            //{

            //}


            //IWebElement element = m_driver.FindElement(By.XPath("xpath of Webelement"));
            //Boolean status = element.Displayed;

            //if (m_driver.FindElement(By.CssSelector("a > font")).Displayed)
            //{
            //    System.Console.WriteLine("Element is Visible");
            //}
            //else
            //{
            //    System.Console.WriteLine("Element is InVisible");
            //}

        }

        [Test]
        public void testLoginOS2()
        {
            m_driver = new ChromeDriver("D:\\1_Work\\6_C#_NET\\chromedriver");
            m_driver.Url = "https://katsiri-katsin.outsystemscloud.com/ExWeb/";
            m_driver.Manage().Window.Maximize();


            // Store locator values of email text box and sign up button				
            //IWebElement emailTextBox = m_driver.FindElement(By.XPath(".//*[@id='philadelphia-field-email']"));
            IWebElement LoginButton = m_driver.FindElement(By.CssSelector(".seleniumLoginButton"));

            //emailTextBox.SendKeys("test123@gmail.com");
            LoginButton.Click();

            var wait = new WebDriverWait(m_driver, TimeSpan.FromSeconds(10));
            wait.Until(m_driver => m_driver.FindElement(By.XPath(".//div[@class='Feedback_Message_Success']")).Displayed);

            IWebElement Message = m_driver.FindElement(By.XPath(".//div[@class='Feedback_Message_Success']"));
            Boolean status = Message.Displayed;
            //Assert.That(Message.Text.Equals("Hello from JavaScript!"));
            Assert.That(status == true);
                    

        }

        [Test]
        public void testLoginOSSuccess()
        {
            m_driver = new ChromeDriver("D:\\1_Work\\6_C#_NET\\chromedriver");
            m_driver.Url = "https://katsiri-katsin.outsystemscloud.com/ExWeb/";
            m_driver.Manage().Window.Maximize();


            // Store locator values of email text box and sign up button				
            //IWebElement emailTextBox = m_driver.FindElement(By.XPath(".//*[@id='philadelphia-field-email']"));

            IWebElement UsernameTextBox = m_driver.FindElement(By.CssSelector(".seleniumUsername"));
            UsernameTextBox.SendKeys("mary.jane");

            IWebElement PasswordTextBox = m_driver.FindElement(By.CssSelector(".seleniumPassword"));
            PasswordTextBox.SendKeys("123456");

            IWebElement LoginButton = m_driver.FindElement(By.CssSelector(".seleniumLoginButton"));

            LoginButton.Click();
            var wait = new WebDriverWait(m_driver, TimeSpan.FromSeconds(10));
            wait.Until(m_driver => m_driver.Title.Contains("Homepage"));

            Assert.That(m_driver.Title.Contains("Homepage"));
            //Assert.That(m_driver.Title.Contains("Login"));
            //string URL = m_driver.Url;
            //Assert.Equals(URL, "https://katsiri-katsin.outsystemscloud.com/ExWeb//Homepage.aspx");
            ///Homepage.aspx

            //IWebElement Message = m_driver.FindElement(By.XPath(".//div[@class='Feedback_Message_Success']"));
            //Boolean status = Message.Displayed;
            //Assert.That(status == true);
            ;

        }

        [Test]
        public void testInquiry()
        {
            m_driver = new ChromeDriver("D:\\1_Work\\6_C#_NET\\chromedriver");
            m_driver.Url = "https://katsiri-katsin.outsystemscloud.com/ExWeb/";
            m_driver.Manage().Window.Maximize();


            IWebElement UsernameTextBox = m_driver.FindElement(By.CssSelector(".seleniumUsername"));
            UsernameTextBox.SendKeys("mary.jane");

            IWebElement PasswordTextBox = m_driver.FindElement(By.CssSelector(".seleniumPassword"));
            PasswordTextBox.SendKeys("123456");

            IWebElement LoginButton = m_driver.FindElement(By.CssSelector(".seleniumLoginButton"));

            LoginButton.Click();
            var wait = new WebDriverWait(m_driver, TimeSpan.FromSeconds(10));
            wait.Until(m_driver => m_driver.Title.Contains("Homepage"));

            //IWebElement ProductLink = m_driver.FindElement(By.XPath("./html/body/form/div[4]/div/header/div/div[1]/div[3]/nav/div/div[1]/div[1]/a"));
            IWebElement ProductLink = m_driver.FindElement(By.CssSelector(".seleniumProductLink")); 
            ProductLink.Click();

            IWebElement SearchTextBox = m_driver.FindElement(By.CssSelector(".seleniumSearchTextBox"));
            SearchTextBox.SendKeys("In-Ear Audio");

            IWebElement SearchButton = m_driver.FindElement(By.CssSelector(".seleniumSearchButton"));
            SearchButton.Click();

            var wait2 = new WebDriverWait(m_driver, TimeSpan.FromSeconds(10));

            IWebElement CounterLabel = m_driver.FindElement(By.CssSelector(".Counter_Message"));
            wait2.Until(m_driver => m_driver.FindElement(By.CssSelector(".Counter_Message")).Text.Trim().Substring(0, 1).Equals("4"));
            //wait2.Until(m_driver => m_driver.FindElement(By.CssSelector(".Counter_Message")).Text.Trim().Substring(0,1).Equals("2"));

            //Counter_Message = 2
            //wait2.Until(m_driver => m_driver.Title.Contains("Homepage"));
            //wait2.Until(d => (bool)(d as IJavaScriptExecutor).ExecuteScript("return jQuery.active == 0"));

            //System.Threading.Thread.Sleep(10);

            //IWebElement tableElement = m_driver.FindElement(By.XPath("/html/body/form/div[4]/div/div/main/div[3]/div/table"));

            //                                             /html/body/form/div[4]/div/div/main/div[3]/div/table/tbody/tr[1]
            int rowcount = m_driver.FindElements(By.XPath("/html/body/form/div[4]/div/div/main/div[3]/div/table/tbody/tr")).Count();
            

            
            IWebElement tableElement = m_driver.FindElement(By.XPath("/html/body/form/div[4]/div/div/main/div[3]/div/table/tbody"));
            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));
            IList<IWebElement> rowTD;
            foreach (IWebElement row in tableRow)
            {
                rowTD = row.FindElements(By.TagName("td"));
                TestContext.WriteLine("rowTD[1] - " + rowTD[1].Text);
                //if (rowTD.Count > 9)
                //{
                //    if (rowTD[8].Text.Equals("Suspended") && rowTD[10].Text.Equals("Publishing Failed");
                //    //test failed
                //}
            }

            //IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));
            ////IList<IWebElement> rowTD;
            //int countRow = 0;
            //foreach (IWebElement row in tableRow)
            //{
            //    countRow = countRow + 1;
            //}

            //IWebElement Message = m_driver.FindElement(By.XPath(".//div[@class='Feedback_Message_Success']"));
            //IWebElement rows = m_driver.FindElement(By.XPath(".//div[@class='seleniumProductTable']/table/tbody/tr/td[1]"));
            //System.out.println("No of rows are : " + rows.size());

            //System.Diagnostics.Debug.WriteLine("test out Debug");
            Assert.That(rowcount == 4);
            TestContext.WriteLine("TestContext Message..." + rowcount);

            //m_driver.Close();

            //Assert.That(m_driver.Title.Contains("Homepage"));


        }

        //[SetUp]
        //public void startBrowser()
        //{
        //    driver = new ChromeDriver("D:\\1_Work\\6_C#_NET\\chromedriver");

        //}

        //[Test]
        //public void test()
        //{
        //    driver.Url = "http://www.google.co.in";
        //}

        //[TearDown]
        //public void closeBrowser()
        //{
        //    driver.Close();
        //}
    }
}
