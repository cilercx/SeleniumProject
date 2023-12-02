using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTestProject
{
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Initiliaze()
        {
            driver.Navigate().GoToUrl("http://www.google.com.tr");
            Console.WriteLine("Google sayfasý açýldý.");
        }

        [Test]
        public void ExecuteTest()
        {
            string yazilanYazi = "Çiler Sürücü Kursu";
            IWebElement webElement = driver.FindElement(By.Name("q"));
            webElement.SendKeys(yazilanYazi);
            Console.WriteLine("Arama kýsmýna " + yazilanYazi + " yazildi.");
        }

        [TearDown]
        public void CleanUp()
        {
            System.Threading.Thread.Sleep(3000);
            driver.Close();
            Console.WriteLine("Uygulama Kapatýldý.");
        }
    }
}