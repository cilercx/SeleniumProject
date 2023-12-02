using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTestProject
{
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();

        /// <summary>
        /// Google sayfasi acildi.
        /// </summary>
        [SetUp]
        public void Initiliaze()
        {
            driver.Navigate().GoToUrl("https://giris.hepsiburada.com/?ReturnUrl=https%3A%2F%2Foauth.hepsiburada.com%2Fconnect%2Fauthorize%2Fcallback%3Fclient_id%3DSPA%26redirect_uri%3Dhttps%253A%252F%252Fwww.hepsiburada.com%252Fuyelik%252Fcallback%26response_type%3Dcode%26scope%3Dopenid%2520profile%26state%3D1931deb80cf44aa99607cfae43df5c9a%26code_challenge%3DUe4sEF6HJzGEAN6i9ydBBCehmOneAzB_bNVW7kAcHQY%26code_challenge_method%3DS256%26response_mode%3Dquery%26ActivePage%3DPURE_LOGIN%26oidcReturnUrl%3Dhttps%253A%252F%252Fwww.hepsiburada.com%252F");
            Console.WriteLine("Hepsiburada sayfasý açýldý.");
        }

        /// <summary>
        /// Arama kismina Ciler Surucu Kursu yazildi
        /// </summary>
        [Test]
        public void ExecuteTest()
        {
            //IWebElement element = driver.FindElement(By.Name("q"));

            MethodsTest.EnterText(driver, "username", "burakc34@gmail.com", "Name");

            System.Threading.Thread.Sleep(10000);

            //string yazilanYazi = "Çiler Sürücü Kursu";
            //IWebElement webElement = driver.FindElement(By.Name("q"));
            //webElement.SendKeys(yazilanYazi);
            //Console.WriteLine("Arama kýsmýna " + yazilanYazi + " yazildi.");
        }

        /// <summary>
        /// Uygulama Kapatildi.
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