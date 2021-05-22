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
            int[] outputarray = targetRange(testarray, 9);
            int[] outputarray2 = targetRange(testarray, 10);

            Console.WriteLine("The example test array marks are [5, 6, 6, 9, 9, 12]");
            Console.WriteLine("Target 9::  " + outputarray[0].ToString() + (",") + outputarray[1].ToString());
            Console.WriteLine("Target 10::  " + outputarray2[0].ToString() + (",") + outputarray2[1].ToString());
            Console.WriteLine(" ");


            //QUESTION 2//

            string StringReverse(string s)
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
            //these next lines are to test with the sample data provided in the question

            string test = StringReverse("University of South Florida");
            Console.WriteLine("Question 2 Output:");
            Console.WriteLine("=======================");
            Console.WriteLine("The sample string is \"University of South Florida\".");
            Console.WriteLine("Result: " + test);
            Console.WriteLine(" ");



            //QUESTION 3//

            int minSum(int[] arr)
            {
                int sum = arr[0];
                int maxindex = arr.Length - 1;

                //look through the array and if the index is equal to the index before it indrease the value by 1
                //then add the sum of the array


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

            Console.WriteLine("The first example test array is {2,2,3,5,6}");
            int[] input1 = { 2, 2, 3, 5, 6 };
            Console.WriteLine("Result: " + minSum(input1));
            Console.WriteLine("The second example test array is {40,40}");
            int[] input2 = { 40, 40 };
            Console.WriteLine("Result: " + minSum(input2));
            Console.WriteLine("The third example test array is {4,5,6,9}");
            int[] input3 = { 4, 5, 6, 9 };
            Console.WriteLine("Result: " + minSum(input3));
            Console.WriteLine(" ");



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
                    for (int i = 1; i <= count; i++)
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

            Console.WriteLine("The first example test string is \"Dell\"");
            Console.WriteLine("Result: " + FreqSort("Dell"));
            Console.WriteLine("The first example test string is \"eebhhh\"");
            Console.WriteLine("Result: " + FreqSort("eebhhh"));
            Console.WriteLine("The first example test string is \"yYkk\"");
            Console.WriteLine("Result: " + FreqSort("yYkk"));
            Console.WriteLine(" ");

            //QUESTION 5//

            static int[] Intersect1(int[] nums1, int[] nums2)
            {

                Array.Sort(nums1);
                Array.Sort(nums2);

                //sorted the array and will create list for our intersect variables search through the array and identify
                //index values from nums2 that are equal to the index values for nums1 and add them to the list

                int index = 0;
                List<int> intersect = new List<int>();
                for (int i = 0; i <= nums1.Length - 1; i++)
                {
                    while ((index < nums2.Length) && (nums2[index] < nums1[i]))
                        index++;
                    if (nums2[index] == nums1[i])
                    {
                        intersect.Add(nums2[index]);
                        index++;
                    }
                }
                int[] final = intersect.ToArray();
                return final;
            }
            //this code is to run the example sets from the question

            Console.WriteLine("Question 5 Output for sort version:");
            Console.WriteLine("=======================");

            Console.WriteLine("The first sample test arrays are nums1 = [2,5,5,2], nums2 = [5,5]");
            int[] numbers1 = { 2, 5, 5, 2 };
            int[] numbers2 = { 5, 5 };
            Console.WriteLine("Result: " + string.Join("", Intersect1(numbers1, numbers2)));

            Console.WriteLine("The first sample test arrays are nums1 = [3,6,2], nums2 = [6,3,6,7,3]");
            int[] numbers3 = { 3, 6, 2 };
            int[] numbers4 = { 6, 3, 6, 7, 3 };
            Console.WriteLine("Result: " + string.Join("", Intersect1(numbers3, numbers4)));
            Console.WriteLine(" ");

            static int[] Intersect2(int[] nums1, int[] nums2)
            {
                //turn first array into dictionary 
                Dictionary<int, int> dict = new Dictionary<int, int>();

                int maxindex = nums1.Length - 1;

                for (int i = 0; i <= maxindex; i++)
                {
                    //check if key is in dictionary already and if so increment the
                    //value by 1 and if not add key to dictionary with value 1
                    if (dict.ContainsKey(nums1[i]))
                        dict[nums1[i]] = dict[nums1[i]] + 1;
                    else dict.Add(nums1[i], 1);
                }
                //for loop through second array checking if values are in dictionary
                List<int> intersect = new List<int>();
                for (int i = 0; i <= nums2.Length - 1; i++)
                {
                    if (dict.ContainsKey(nums2[i]))
                    {
                        intersect.Add(nums2[i]);
                        dict[nums2[i]] = dict[nums2[i]] - 1;
                        if (dict[nums2[i]] == 0)
                            dict.Remove(nums2[i]);
                    }
                }
                int[] final = intersect.ToArray();
                return final;
            }
            Console.WriteLine("Question 5 Output for dictionary version:");
            Console.WriteLine("=======================");

            Console.WriteLine("The first sample test arrays are nums1 = [2,5,5,2], nums2 = [5,5]");
            Console.WriteLine("Result: " + string.Join("", Intersect2(numbers1, numbers2)));
            Console.WriteLine("The first sample test arrays are nums1 = [3,6,2], nums2 = [6,3,6,7,3]");
            Console.WriteLine("Result: " + string.Join("", Intersect2(numbers3, numbers4)));
            Console.WriteLine(" ");


            //QUESTION 6//

            bool ContainsDuplicate(char[] arr, int k)
            {
                //Create a dictionary adding keys when they char key does not exist: when the key already exist identify if the
                // the index value I am currently looking at - the value of the key already in the dictionary is less than or equal to 
                //the integer value- if it is return true if continue through the array return false if the if statement never returns true
                Dictionary<char, int> dict = new Dictionary<char, int>();

                for (int i = 0; i <= arr.Length - 1; i++)
                {
                    if (dict.ContainsKey(arr[i]))
                    {
                        if ((i - dict[arr[i]]) <= k)
                            return true;
                        dict[arr[i]] = i;
                    }
                    else dict.Add(arr[i], i);

                }
                return false;
            }

            //This next code is to test the method using the examples provided in the question
            Console.WriteLine("Question 6 Output:");
            Console.WriteLine("=======================");
            char[] test1 = { 'a', 'g', 'h', 'a' };
            char[] test2 = { 'k', 'y', 'k', 'k' };
            char[] test3 = { 'a', 'b', 'c', 'a', 'b', 'c' };

            Console.WriteLine("This first test sample is arr=[a,g,h,a], k=3");
            Console.WriteLine("Result: " + ContainsDuplicate(test1, 3));

            Console.WriteLine("This first test sample is arr=[k,y,k,k], k=1");
            Console.WriteLine("Result: " + ContainsDuplicate(test1, 3));

            Console.WriteLine("This first test sample is [a,b,c,a,b,c], k=2");
            Console.WriteLine("Result: " + ContainsDuplicate(test3, 3));

            //    Example 2: arr =[k, y, k, k], k = 1

        }
    }
}










