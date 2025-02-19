using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Kara Crumpton
 * CPT 206 - Lab 4 - Class Library
 * Feb 18th 2025
 */

namespace KCrumpton_CPT_206___Lab_4_Class_Library
{
    public class States
    {
        // class that will hold all the stuff
        public int ID {  get; set; }
        public string Name { get; set; }
        public string Capital { get; set; }
        public string LargestCity { get; set; }
        public double Population { get; set; }
        public string Flower { get; set; }
        public string Bird {  get; set; }
        public string Colors { get; set; }
        public double MedianIncome { get; set; }
        public decimal ComputerJobs { get; set; }
        public string Turtles { get; set; }

        // parameterless constructor, just in case? I don't think I need this... putting it in anyway. 
        public States()
        {

        }

        // Constructor with all the stuff. 
        public States(int iD, string name, string capital, string largestCity, double population, string flower, string bird, string colors, double medianIncome, decimal computerJobs, string turtles)
        {
            ID = iD;
            Name = name;
            Capital = capital;
            LargestCity = largestCity;
            Population = population;
            Flower = flower;
            Bird = bird;
            Colors = colors;
            MedianIncome = medianIncome;
            ComputerJobs = computerJobs;
            Turtles = turtles;
        }
    }

}
