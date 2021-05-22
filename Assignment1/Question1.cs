using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Question1
    {
        public void Answer()
        {
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
        }
        //QUESTION 1//
        public int[] targetRange(int[] marks, int target)
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



    }
}
