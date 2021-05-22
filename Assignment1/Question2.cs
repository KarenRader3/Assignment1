using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Question2
    {
        public void Answer()
        {
            //these next lines are to test with the sample data provided in the question
            string test = StringReverse("University of South Florida");
            Console.WriteLine("Question 2 Output:");
            Console.WriteLine("=======================");
            Console.WriteLine("The sample string is \"University of South Florida\".");
            Console.WriteLine("Result: " + test);
            Console.WriteLine(" ");
        }
        public string StringReverse(string s)
        {
            //convert the input string of the function to a char array and create a new empty char array
            //the same length as the string input.
            char[] forward = s.ToCharArray();
            char[] flipped = new char[forward.Length];
            Stack<char> word = new Stack<char>();

            //create a stack and run a for loop to put the characters onto the stack up until a white space is
            //reached at which point it pops the stack back off putting it into the flipped char array
            int index = 0;
            for (int i = 0; i < forward.Length; i++)
            {
                if (forward[i] != ' ')
                    word.Push(forward[i]);
                else
                {
                    while (word.Count > 0)
                    {
                        flipped[index] = word.Pop();
                        index++;
                    }
                    flipped[index] = ' ';
                    index++;
                }
            }
            while (word.Count > 0)
            {
                flipped[index] = word.Pop();
                index++;
            }
            string final = new string(flipped);
            return final;
        }
    }
}
