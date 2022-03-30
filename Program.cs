//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMP1903M_Assessment_1_Base_Code;
using static CMP1903M_Assessment_1_Base_Code.Input; 
using static CMP1903M_Assessment_1_Base_Code.Analyse; 
using static CMP1903M_Assessment_1_Base_Code.Report;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program //Creating a new class
    {
        static void Main()
        {
            //Instantalises objects relating to each files output
            Input iObject = new Input();
            Analyse aObject = new Analyse();
            Report rObject = new Report();
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>(); //Creates a new list

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            string input; 
            input = iObject.manualTextInput(); //Applies the output from the manualTextInput method to the variable input
            //Console.WriteLine(input);

            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            List<int> analyse = new List<int>();
            analyse = aObject.analyseText(input); //Applies the output from the analyseText method to the variable analyse
            Console.WriteLine(analyse);
            //Receive a list of integers back
            //foreach(var i in analyse){
                //Console.WriteLine(i);
            //}

            //Report the results of the analysis
            rObject.outputConsole(analyse); //Applies the output from the outputConsole method to the variable rObject

            //TO ADD: Get the frequency of individual letters?
            
           
        }
        
        
    
    }
}
