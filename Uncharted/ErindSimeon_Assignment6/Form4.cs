/*
 * Course: CSCI-473   Assignment :6    Spring 2021
 * 
 * Erind Hysa   zid: z1879691
 * Simeon Lico  zid: z1885981
 * 
 * Due Date : 04/15/2021
 * 
 * Description:
 * This file contains the code for the code for form4
 * it will graph a line graph when form gets loaded
 */
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ErindSimeon_Assignment6
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            //Remove the Default Series.
            if (chart1.Series.Count() == 1)
            {
                chart1.Series.Remove(chart1.Series[0]);
            }
            //array string of country names
            string[] countryNames = new string[] { "us", "uk", "canada", "brazil" };
            Title title = new Title(); //generate a new title
            title.Font = new Font("Verdana", 16, System.Drawing.FontStyle.Bold); //pick a font for the title
            title.Text = "Percentage of Deaths for US,UK,Canada,Brasil"; //pick the text for the title
            chart1.Titles.Add(title);//add the title to the graph
            //query to grab the number of vacines for every county
            double[] y = (from p in GlobalList.myList.AsEnumerable()
                              where p.Date == "4/4/2021"
                              select (p.TotalDeaths)).ToArray();
            //Add Series to the Chart.
            chart1.Series.Add(new Series("Deaths"));
            chart1.Series["Deaths"].ChartType = SeriesChartType.Pie; //pick pie as the chart type
            chart1.Series["Deaths"].Points.DataBindXY(countryNames, y); //plot the graph
            //add the percentage of each country
            foreach (DataPoint p in chart1.Series["Deaths"].Points)
            {
                p.Label = "#PERCENT\n#VALX";
            }
        }
        /*
        * goBackButton(object sender, EventArgs e)
        * go back when they click the button
        * params: Sender: Reference to the object that called this function,
        *         EventArgs: The arguments passed from the calling object
        * return: none
        */
        private void goBackButton(object sender, EventArgs e)
        {
            this.Close(); //close this form
        }
    }
}
