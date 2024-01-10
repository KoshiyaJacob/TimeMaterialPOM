﻿

using System.Reflection.PortableExecutable;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TimeAndMaterialsUsingPOM.ClassesFolder;

internal class Program
{
    public static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);


        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginAndHomePageVerification(driver);


        TimeAndMaterial timeAndMaterialObj = new TimeAndMaterial();
        timeAndMaterialObj.ClickTMandCreate(driver);


        CreateEditDelete createEditDeleteObj = new CreateEditDelete();

        createEditDeleteObj.CreateTimeAndMaterial(driver);

        createEditDeleteObj.EditTimeAndMaterial(driver);

        createEditDeleteObj.DeleteTimeAndMaterial(driver);

    






    }

}

       

