using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //QUESTION 1//

            int[] targetRange(int[] marks, int target)
            {
                //Set our index to 0 and set the output array as -1,-1
                int index = 0;
                int[] output = { -1, -1 };

                //Create a while loop to scan through the array and increase the
                //index by one searching if the target is greater than the index
                //if all the index points are greater than the target it will return
                //the output we set above.  Otherwise it will search and return the index
                //point of the first and last point of the target
                while ((index < marks.Length) && (marks[index] < target))
                    index++;
                if ((index >= marks.Length) || (marks[index] > target))
                    return output;
                output[0] = index;
                while ((index < marks.Length) && (marks[index] == target))
                    index++;
                output[1] = index - 1;
                return output;
            }
            //This is to test and show the output of the method working.
            Console.WriteLine("Question 1 Output:");
            Console.WriteLine("=======================");

            int[] testarray = { 5, 6, 6, 9, 9, 12 };
            int[] outputarray = targetRange(testarray, 12);
            int[] outputarray2 = targetRange(testarray, 10);

            Console.WriteLine("Test first array marks are [5, 6, 6, 9, 9, 12] and the test " +
                "target is 9");
            Console.WriteLine(outputarray[0].ToString() + (",") + outputarray[1].ToString());
            Console.WriteLine("The second test array marks are [5, 6, 6, 9, 9, 12] and the test" +
                "target is 10");
            Console.WriteLine(outputarray2[0].ToString() + (",") + outputarray2[1].ToString());


            //QUESTION 2//

            string StringReverse(string s)
            {
                //concert the input string of the function to a char array and create a new empty char array
                //the same length as the string input.
                char[] forward = s.ToCharArray();
                char[] flipped = new char[forward.Length];
                Stack<char> word = new Stack<char>();

                //created a stack and ran a for loop to put the characters onto the stack up until a white space is
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
            //these next lines are to test with the sample data provided in the question

            string test = StringReverse("University of South Florida");
            Console.WriteLine("Question 2 Output:");
            Console.WriteLine("=======================");
            Console.WriteLine("The sample string is \"University of South Florida\".");
            Console.WriteLine(test);



            //QUESTION 3//

            int minSum(int[] arr)
            {
                int sum = arr[0];
                int maxindex = arr.Length - 1;

                //create a loop to go through the array and if an array index is equal to the
                //index before it replaces it with j which is the array index value +1 and then add the array to sum
                //which was set at index 0. continue through loop until reach maxindex which is the array length.

                for (int i = 1; i <= maxindex; i++)
                {
                    if (arr[i] == arr[i - 1])
                        arr[i] = arr[i] + 1;
                    sum = sum + arr[i];
                }
                return sum;
            }
            //These next lines are to test the method using the samples provided in the question.
            Console.WriteLine("Question 3 Output:");
            Console.WriteLine("=======================");

            int[] input1 = { 2, 2, 3, 5, 6 };
            Console.WriteLine(minSum(input1));
            int[] input2 = { 40, 40 };
            Console.WriteLine(minSum(input2));
            int[] input3 = { 4, 5, 6, 9 };
            Console.WriteLine(minSum(input3));



            //QUESTION 4//
            static string FreqSort(string s)
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
                    for (int i=1; i<=count; i++)
                    {
                        output[index] = letter.Key;
                        index++;
                    }

                }
                string final = new string(output);
                return final;

                
                    
                }
            //these next lines are to test the method using the samples provided in the question
            Console.WriteLine("Question 4 Output:");
            Console.WriteLine("=======================");

            Console.WriteLine(FreqSort("Dell"));
            Console.WriteLine(FreqSort("eebhhh"));
            Console.WriteLine(FreqSort("yYkk"));
        }
        }
    }








