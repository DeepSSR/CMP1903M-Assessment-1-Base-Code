using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            int stotal = 0;
            int utotal = 0;
            int vtotal = 0;
            int ctotal = 0;
            int ltotal = 0;
            int length = input.Length;
            input = input.Replace(" ", String.Empty);
            Console.WriteLine("The sentence has : " + length + " characters.");
            //List of integers to hold the first five measurements:
            //1. Number of sentences
               for (int i = 0; i < input.Length; i++)
            {
                if (input[i]  == '*')
                {
                    stotal++;
                }
            }
            //2. Number of vowels
               for (int i = 0; i < input.Length; i++)
            {
                if (input[i]  == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                {
                    vtotal++;
                }
            }
            //3. Number of consonants
               for (int i = 0; i < input.Length; i++)
            {
                ctotal++;
            }            
            
            ctotal = ctotal - vtotal;
            //4. Number of upper case letters
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i])) utotal++;
            }
            //5. Number of lower case letters
               for (int i = 0; i < input.Length; i++)
            {
                ltotal++;
            }            
            
            ltotal = ltotal - utotal;            

            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for(int i = 0; i<5; i++)
            {
                values.Add(0);
            }

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
            return values;
        }
    }
}
