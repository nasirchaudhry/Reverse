using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//start namespace Reverse
namespace Reverse
{
    /// <summary> 
    /// This program will print characters of string in reverse order 
    /// </summary> 
    
    //start class Program 
    class Program
    {
        //start main method
        static void Main(string[] args)
        {
            //prompt user to enter a string
            Console.WriteLine("Please enter text to be reversed:");
            string inputText = Console.ReadLine();

            //declaring array
            char[] myChar = inputText.ToCharArray();
            Array.Reverse(myChar);

            //using foreach loop
            foreach (char character in myChar)
            {
                Console.Write(character);
            }
            Console.ReadLine();

        }//end main
    }//end class Program
}//end namespace Reverse