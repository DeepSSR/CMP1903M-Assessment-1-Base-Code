using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input //Creating a new class
    {
        //Handles the text input for Assessment 1
        string text = "nothing";
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            //assining the Variable, with a string data 
            string manualInput; 
			Console.Write("Enter sentences ending with * - "); 
			manualInput = Console.ReadLine(); //Passing the input from the user into the variable
            while (string.IsNullOrEmpty(manualInput)) //Checks if input is empty while looping 
                {                    

                    try //If input is empty, this alerts the user and requires a re-try
                    {
                        Console.WriteLine("Can't be empty!");
                        Console.Write("Enter sentences ending with * - ");
                        manualInput = Console.ReadLine();
                    }
                    catch(Exception ex) //Catches any errors occouring during running the program
                    {
                        Console.Write("Error info: " + ex.Message);
                    }

                }
            //returns any output value from the class
            return manualInput;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {

            return text;
        }

    }
}
