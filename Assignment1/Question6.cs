using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Question6
    {
        public void Answer()
        {
            //This next code is to test the method using the examples provided in the question
            Console.WriteLine("Question 6 Output:");
            Console.WriteLine("=======================");
            char[] test1 = { 'a', 'g', 'h', 'a' };
            char[] test2 = { 'k', 'y', 'k', 'k' };
            char[] test3 = { 'a', 'b', 'c', 'a', 'b', 'c' };

            Console.WriteLine("This first test sample is arr=[a,g,h,a], k=3");
            Console.WriteLine("Result: " + ContainsDuplicate(test1, 3));

            Console.WriteLine("This first test sample is arr=[k,y,k,k], k=1");
            Console.WriteLine("Result: " + ContainsDuplicate(test2, 1));

            Console.WriteLine("This first test sample is [a,b,c,a,b,c], k=2");
            Console.WriteLine("Result: " + ContainsDuplicate(test3, 2));

            

        }
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
    }
}
