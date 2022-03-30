using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse //Creating a new class
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //Creating multiple variables with an integer data type
            int stotal = 0;
            int utotal = 0;
            int vtotal = 0;
            int ctotal = 0;
            int ltotal = 0;
            int length = input.Length; //Assigns the result of checking the length of the input to the variable length
            input = input.Replace(" ", String.Empty); //Ensures spaces are not seen as variables, changing then into nothing
            Console.WriteLine("The sentence has : " + length + " characters."); //Outputs the lenght of input
            //List of integers to hold the first five measurements:
            //1. Number of sentences
               for (int i = 0; i < input.Length; i++) //loops thorugh input
            {
                if (input[i]  == '*') //Checks if any character of the Input has an specific symbol
                {
                    stotal++; //Counts the number of symbols, indicating the end of a sentence
                }
            }
            //2. Number of vowels
               for (int i = 0; i < input.Length; i++) //loops thorugh input
            {
                if (input[i]  == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u') //Checks if any character of the Input has any of the specific symbols
                {
                    vtotal++; // Totals the amount
                }
            }
            //3. Number of consonants
               for (int i = 0; i < input.Length; i++) //loops thorugh input
            {
                ctotal++; // Totals the amount
            }            
            
            ctotal = ctotal - vtotal; //Takes the vowels away from the consonants
            //4. Number of upper case letters
            for (int i = 0; i < input.Length; i++) //loops thorugh input
            {
                if (char.IsUpper(input[i])) utotal++; //Checks if any of the characters are Upper Case, Totals the amount
            }
            //5. Number of lower case letters
               for (int i = 0; i < input.Length; i++) //loops thorugh input
            {
                ltotal++; // Totals the amount
            }            
            
            ltotal = ltotal - utotal; //Takes the Upper Case lettesr away from the Lower Case letters

            List<int> values = new List<int>(); ///Creates a new list
            //Initialise all the values in the list to '0'
            for(int i = 0; i<5; i++)
            {
                values.Add(0);
            }

            //Adds each value to the list, respective to its numerical position
            values[0] = stotal;
            //Console.WriteLine(stotal);
            values[1] = vtotal;
            //Console.WriteLine(vtotal);
            values[2] = ctotal;
            //Console.WriteLine(ctotal);
            values[3] = utotal;
            //Console.WriteLine(utotal);
            values[4] = ltotal;
            //Console.WriteLine(ltotal);
            //foreach(var i in values){
                //Console.WriteLine(i);
            //}
            return values; //Returns the list 
        }
    }
}
