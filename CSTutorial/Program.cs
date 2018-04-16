using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola"); //prints output w/ new line 
            //Write(); //prints output w/o new line
            //remove specific characters using (remove_char("string", index))

            int x = 1, y = 2, z = 0;
            z = x + y;

            Console.WriteLine("{0} + {1} = {2}", x, y, z); //faster way instead of (" x + y = z")

            string a = Console.ReadLine(); //reading user input
            int b = Int32.Parse(a); //convert string to int or int b = Int32.Parse(Console.ReadLine());
            int c = b + z;

            Console.WriteLine("{0} + {1} = {2}", b, z, c); // or instead of ",c" use b + z 

            Swap(b, c);

            int n = 0;

            //finding largest string
            string line = "The brown fox jumped over the lazy dog";

            //string will be split at a new string when there is a whitespace (can add more parameters if needed b/c of the "new[]" command)
            string[] arr = line.Split(new char[] { ' ' }, StringSplitOptions.None); //None - return value includes array elements that contain an empty string
            //StringSplitOptions.RemoveEmptyEntries - return value excludes array elements that contain an empty string
            //Ex ",," if None, there will be an empty element in the array || RemoveEmptyEntries will remove those elements 
            //StringSplitOption can be omitted || Can also limit # of strings using Split(new[], int32); which takes a type of array and # of items returned
            //split on string - can choose a string to split || split on char - choose split on a character

            string LongestWord = "";
            int counter = 0;
            //compares every string in arr with counter and if string length > counter, set longestword to s and change the counter
            foreach (String s in arr)
            {
                if (s.Length > counter)
                {
                    LongestWord = s;
                    counter = s.Length;
                }
            }

            Console.WriteLine(LongestWord);

            String UserInput = Console.ReadLine();
            int value;
            bool boo = true;

            String[] InputSplit = UserInput.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < InputSplit.Length; i++)
            {
                if (int.TryParse(InputSplit[i], out value)) //try parsing UserInput and if true, set value
                {
                    Console.WriteLine("value at [" + i + "] is:" + value);
                }
                else
                {
                    Console.WriteLine("value at [" + i + "] is NAN");
                }
            }

            //Console.ReadLine(); //waits for new line to be entered before closing application
            Console.ReadKey(); //waits for any input from the user (Except for modifier keys such as shift / ctrl / caps / etc.)
        }

        public static void Swap(int x, int y) //create methods out side of main (no function prototype required)
        {
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("x: {0} | y: {1}", x, y);
        }
    }
}