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
    class Program
    {
        static void Main()
        {
            Input iObject = new Input();
            Analyse aObject = new Analyse();
            Report rObject = new Report();
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            string input; 
            input = iObject.manualTextInput();
            //Console.WriteLine(input);

            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            List<int> analyse = new List<int>();
            analyse = aObject.analyseText(input);
            Console.WriteLine(analyse);
            //Receive a list of integers back
            //foreach(var i in analyse){
                //Console.WriteLine(i);
            //}

            //Report the results of the analysis
            rObject.outputConsole(analyse);

            //TO ADD: Get the frequency of individual letters?
            
           
        }
        
        
    
    }
}
