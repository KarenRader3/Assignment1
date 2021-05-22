using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Question4
    {
        public void Answer()
        {

            //these next lines are to test the method using the samples provided in the question
            Console.WriteLine("Question 4 Output:");
            Console.WriteLine("=======================");

            Console.WriteLine("The first example test string is \"Dell\"");
            Console.WriteLine("Result: " + FreqSort("Dell"));
            Console.WriteLine("The first example test string is \"eebhhh\"");
            Console.WriteLine("Result: " + FreqSort("eebhhh"));
            Console.WriteLine("The first example test string is \"yYkk\"");
            Console.WriteLine("Result: " + FreqSort("yYkk"));
            Console.WriteLine(" ");

        }
        public static string FreqSort(string s)
        {
            //convert the string input from the function call into a char array and create an empty dictionary with key as a char
            //and value as an int 
            char[] input = s.ToCharArray();
            Dictionary<char, int> dict = new Dictionary<char, int>();


            int maxindex = input.Length - 1;
            for (int i = 0; i <= maxindex; i++)
            {
                //check if key is in dictionary already and if so increment the
                //value by 1 and if not add key to dictionary with value 1
                if (dict.ContainsKey(input[i]))
                    dict[input[i]] = dict[input[i]] + 1;
                else dict.Add(input[i], 1);
            }

            // sort the keys by frequency and assign them into the char array output in descending order
            // repeating for the total number of the value assigned for each key

            char[] output = new char[input.Length];
            int index = 0;
            foreach (KeyValuePair<char, int> letter in dict.OrderByDescending(key => key.Value))

            {
                int count = letter.Value;
                for (int i = 1; i <= count; i++)
                {
                    output[index] = letter.Key;
                    index++;
                }
            }
            string final = new string(output);
            return final;

        }
    }
}
