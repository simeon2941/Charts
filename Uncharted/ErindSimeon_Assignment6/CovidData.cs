/*
 * Course: CSCI-473   Assignment :6   Spring 2021
 * 
 * Erind Hysa   zid: z1879691
 * Simeon Lico  zid: z1885981
 * 
 * Due Date : 04/15/2021
 * 
 * Description:
 * This class will hold information about a a line of the text file
 * it will keep info for date,nbrVacines,NbrNewCases, deaths, population, countryName
 * and total of deaths
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErindSimeon_Assignment6
{
    public class CovidData 
    {
        private readonly String date; //string variable to hold date
        private readonly double nbrVacines; //variable to hold nubmer of vacines
        private readonly double nbrNewCases; //variable to hold number of new cases
        private readonly double deaths; //variable to hold number of deaths
        private readonly double population; //variable to hold population number
        private string countryName; //variable to hold countryName
        private readonly double totalDeaths; //variable to hold total deaths
        //default constructor where all attributes are set to 0 or empty
        public CovidData()
        {
            this.date = "";
            this.nbrVacines = 0;
            this.nbrNewCases = 0;
            this.deaths = 0;
            this.population = 0;
            this.countryName = "";
            this.totalDeaths = 0;
        }
        //alterantive constructor used to populate new CovidData
        public CovidData(string date, double nbrVacines, double nbrNewCases, double deaths, double population, string countryName,double totalDeaths)
        {
            this.date = date;
            this.nbrVacines = nbrVacines;
            this.nbrNewCases = nbrNewCases;
            this.deaths = deaths;
            this.population = population;
            this.countryName = countryName;
            this.totalDeaths = totalDeaths;
        }
        //readonly Date//getters
        public string Date
        {
            get { return date; }
        }
        //readonly NbrVacines so we have only getters
        public double NbrVacines
        {
            get { return nbrVacines; }
        }
        //readOnly TotalDeaths so we have only getters
        public double TotalDeaths
        {
            get { return totalDeaths; }
        }
        //readonly NbrNewCases so we have only getters
        public double NbrNewCases
        {
            get { return nbrNewCases; }
        }
        //readonly Deaths so we have only getters
        public double Deaths
        {
            get { return deaths; }
        }
        //readOnly Population
        public double Population
        {
            get { return population; }
        }
        //readonly CountrynAME
        public string CountryName
        {
            get { return countryName; }
        }
    }
}
