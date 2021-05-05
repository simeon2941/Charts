/*
 * Course: CSCI-473   Assignment :6    Spring 2021
 * 
 * Erind Hysa   zid: z1879691
 * Simeon Lico  zid: z1885981
 * 
 * Due Date : 04/15/2021
 * 
 * Description:
 * This file contains the code for the code for form3
 * it will graph a column graph
 */
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace ErindSimeon_Assignment6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            //Remove the Default Series.
            if (chart1.Series.Count() == 1)
            {
                chart1.Series.Remove(chart1.Series[0]);
            }
            //array string of country names
            string[] countryNames = new string[] { "us", "uk", "canada", "brazil" };
            //  this.chart1.Titles.Add("This is a title");
            Title title = new Title();//generate a new title
            title.Font = new Font("Verdana", 16, System.Drawing.FontStyle.Bold); //pick a font for the title
            title.Text = "Number of New Cases per Day"; //pick the text for the title
            chart1.Titles.Add(title);//add the title to the graph
            //iterate through the countryNames
            foreach (string country in countryNames)
            {
                //linq query to grab dates for every country
                string[] x = (from p in GlobalList.myList.AsEnumerable()
                              where p.CountryName.ToLower() == country
                              select p.Date).ToArray();
                //query to grab the number of vacines for every county
                double[] y = (from p in GlobalList.myList.AsEnumerable()
                              where p.CountryName.ToLower() == country
                              select p.NbrNewCases).ToArray();

                //Add Series to the Chart.
                chart1.Series.Add(new Series(country));
                chart1.Series[country].ChartType = SeriesChartType.Column; // pick Column for SeriesChartType
                chart1.ChartAreas[0].AxisX.Minimum = 0; //minimum value of xAxis
                chart1.ChartAreas[0].AxisX.Maximum = 11; //maximum value of xAxis
                chart1.ChartAreas[0].AxisX.Interval = 1; //interval 
                chart1.ChartAreas[0].AxisY.Maximum = 100000;  //maximum value for yAxis
                chart1.ChartAreas[0].AxisY.Interval = 10000;  //minimum value for yAxis

                chart1.ChartAreas[0].AxisX.Title = "Date";  //set the title for xAxis
                chart1.ChartAreas[0].AxisX.TitleFont = new System.Drawing.Font("Verdana", 12, System.Drawing.FontStyle.Bold);  //set the font for the title of xAxis
                chart1.ChartAreas[0].AxisY.Title = "Number of New Cases"; //set the title for yAxis
                chart1.ChartAreas[0].AxisY.TitleFont = new System.Drawing.Font("Verdana", 12, System.Drawing.FontStyle.Bold); //set the font the title of yAxis
                chart1.Series[country].Points.DataBindXY(x, y);  //plot the points

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
            this.Close();
        }
    }
}
