using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Question3
    {
        public void Answer()
        {

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
        }
        public int minSum(int[] arr)
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
    }
}
