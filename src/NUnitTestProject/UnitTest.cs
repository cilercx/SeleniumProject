using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTestProject
{
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();

        /// <summary>
        /// Google sayfas� a��ld�.
        /// </summary>
        [SetUp]
        public void Initiliaze()
        {
            driver.Navigate().GoToUrl("http://www.google.com.tr");
            Console.WriteLine("Google sayfas� a��ld�.");
        }

        /// <summary>
        /// Arama k�sm�na �iler S�r�c� Kursu yazildi
        /// </summary>
        [Test]
        public void ExecuteTest()
        {
            string yazilanYazi = "�iler S�r�c� Kursu";
            IWebElement webElement = driver.FindElement(By.Name("q"));
            webElement.SendKeys(yazilanYazi);
            Console.WriteLine("Arama k�sm�na " + yazilanYazi + " yazildi.");
        }

        /// <summary>
        /// Uygulama Kapat�ld�.
        /// </summary>
        [TearDown]
        public void CleanUp()
        {
            System.Threading.Thread.Sleep(3000);
            driver.Close();
            Console.WriteLine("Uygulama Kapat�ld�.");
        }
    }
}