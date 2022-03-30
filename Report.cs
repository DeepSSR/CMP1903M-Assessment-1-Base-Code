using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report //Creating a new class
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)

        List<int> values = new List<int>(); //Creates a new list
        public void outputConsole(List<int> values){ 
            //   foreach(var i in values){
            //     Console.WriteLine(i);
            // }
            //Prints each value individualy, with it's corrisponding position
            Console.WriteLine("Total Scentences " + values[0]);
            Console.WriteLine("Total Vowels " + values[1]);
            Console.WriteLine("Total Consonants " + values[2]);
            Console.WriteLine("Total Upper Case Letters " + values[3]);
            Console.WriteLine("Total Lower Case Letters " + values[4]);
        }

    }
}