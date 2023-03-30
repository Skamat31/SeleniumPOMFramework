using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumPOMFramework.Source.Pages;
using SeleniumPOMFramework.Source.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumPOMFramework.Test
{
    public class HomePageTest : WebDriverConfigFunctions
    {

        [Test]
        public void SearchFlights() 
        {
            HomePage hp = new HomePage();
            Utility ul = new Utility();
            SearchResultsPage sr = new SearchResultsPage();
            hp.closePopUp();
            hp.SearchAndSelectSource("Mumbai");
            hp.SearchAndSelectDestination("New Delhi");
            hp.selectJourneyType();
            hp.selectPassenger(2, 1);
            hp.clickOnDatePicker();
            hp.selectDeparturedate();
            hp.selectReturnDate();
            hp.SearchFlights();
            ul.WaitTillPageLoads();
            sr.selectMorningFlight();
            sr.sortByDeparture();

        }
    }
}
