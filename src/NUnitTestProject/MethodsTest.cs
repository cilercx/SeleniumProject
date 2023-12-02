using OpenQA.Selenium;

namespace NUnitTestProject
{
    public class MethodsTest
    {

        /// <summary>
        /// Enter text
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="element"></param>
        /// <param name="value"></param>
        /// <param name="elementType"></param>
        public static void EnterText(IWebDriver driver, string element, string value, string elementType)
        {
            if (elementType == "id")
            {
                driver.FindElement(By.Id(element)).SendKeys(value);
            }
            else if (elementType == "Name")
            {
                driver.FindElement(By.Name(element)).SendKeys(value);
            }
        }


        public static void Click(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "id")
            {
                driver.FindElement(By.Id(element)).Click();
            }
            else if (elementType == "Name")
            {
                driver.FindElement(By.Name(element)).Click();
            }
        }
    }
}
