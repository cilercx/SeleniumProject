using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTestProject
{
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();

        /// <summary>
        /// Google sayfasý açýldý.
        /// </summary>
        [SetUp]
        public void Initiliaze()
        {
            driver.Navigate().GoToUrl("http://www.google.com.tr");
            Console.WriteLine("Google sayfasý açýldý.");
        }

        /// <summary>
        /// Arama kýsmýna Çiler Sürücü Kursu yazildi
        /// </summary>
        [Test]
        public void ExecuteTest()
        {
            string yazilanYazi = "Çiler Sürücü Kursu";
            IWebElement webElement = driver.FindElement(By.Name("q"));
            webElement.SendKeys(yazilanYazi);
            Console.WriteLine("Arama kýsmýna " + yazilanYazi + " yazildi.");
        }

        /// <summary>
        /// Uygulama Kapatýldý.
        /// </summary>
        [TearDown]
        public void CleanUp()
        {
            System.Threading.Thread.Sleep(3000);
            driver.Close();
            Console.WriteLine("Uygulama Kapatýldý.");
        }
    }
}