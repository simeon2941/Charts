/*
 * Course: CSCI-473   Assignment :6    Spring 2021
 * 
 * Erind Hysa   zid: z1879691
 * Simeon Lico  zid: z1885981
 * 
 * Due Date : 04/15/2021
 * 
 * In the main we read the data from the four files in tha data folder.After reading them
 * we add them to the global class called mylist
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErindSimeon_Assignment6
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string slacker; //holder for the line
            string[] tokens; //holder for the tokens
            try
            {
                using (StreamReader inFile = new StreamReader(Path.Combine("..//..//data", "US.txt"))) //open the file
                {
                    slacker = inFile.ReadLine(); //read the first line

                    while (slacker != null) //iterate until the end of file
                    {
                        tokens = slacker.Split('\t'); //split each line into tokens with tab as the delimter
                        GlobalList.myList.Add(new CovidData(tokens[0], Double.Parse(tokens[1]), Double.Parse(tokens[2]), Double.Parse(tokens[3]), Double.Parse(tokens[4]), "us", Double.Parse(tokens[5]))); //add the tokens to the list
                        slacker = inFile.ReadLine(); //read the next line
                    }
                }
            }
            catch (IOException e) //if file failed to open print a message
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            string slacker1; //holder for the line
            string[] tokens1; //holder for the tokens
            try
            {
                using (StreamReader inFile = new StreamReader(Path.Combine("..//..//data", "UK.txt"))) //open the file
                {
                    slacker1 = inFile.ReadLine(); //read the first line
                    while (slacker1 != null)//iterate until the end of the file
                    {
                        tokens1 = slacker1.Split('\t'); //split the first line into tokens
                        GlobalList.myList.Add(new CovidData(tokens1[0], Double.Parse(tokens1[1]), Double.Parse(tokens1[2]), Double.Parse(tokens1[3]), Double.Parse(tokens1[4]), "uK", Double.Parse(tokens1[5]))); //add the tokens to the list
                        slacker1 = inFile.ReadLine(); //read the next line
                    }
                }
            }
            catch (IOException e)//print a message if file faild to open
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            String slacker2; //holder for the line
            string[] tokens2; //holder for the tokens
            try
            {
                using (StreamReader inFile = new StreamReader(Path.Combine("..//..//data", "Canada.txt"))) //open the file
                {
                    slacker2 = inFile.ReadLine(); //read the first line
                    while (slacker2 != null) //iterate until the end of the file
                    {
                        tokens2 = slacker2.Split('\t'); //spit the line into tokens
                        GlobalList.myList.Add(new CovidData(tokens2[0], Double.Parse(tokens2[1]), Double.Parse(tokens2[2]), Double.Parse(tokens2[3]), Double.Parse(tokens2[4]), "canada", Double.Parse(tokens2[5]))); //add them to the list
                        slacker2 = inFile.ReadLine();//read the next line
                    }
                }
            }
            catch (IOException e) //print a message if it failed to open
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            String slacker3; //holder for the line
            string[] tokens3; //holder for the tokens
            try
            {
                using (StreamReader inFile = new StreamReader(Path.Combine("..//..//data", "Brazil.txt"))) //open the file
                {
                    slacker3 = inFile.ReadLine(); //read the first line
                    while (slacker3 != null) //iterate until the end of the file
                    {
                        tokens3 = slacker3.Split('\t'); //split the line into tokens
                        GlobalList.myList.Add(new CovidData((tokens3[0]), Double.Parse(tokens3[1]), Double.Parse(tokens3[2]), Double.Parse(tokens3[3]), Double.Parse(tokens3[4]), "brazil", Double.Parse(tokens3[5]))); //add tokens to the list
                        slacker3 = inFile.ReadLine(); //read the next line
                    }
                }
            }
            catch (IOException e) //print a message if it failed to open the file
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Application.Run(new Form1()); //run form1
        }
    }
}
