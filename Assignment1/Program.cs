using System;


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
                while (marks[index] < target)
                    index++;
                if (marks[index] > target)
                    return output;
                output[0] = index;
                while (marks[index] == target)
                    index++;
                output[1] = index - 1;
                return output;

            }
            //This is to test and show the output of the method working.
            Console.WriteLine("Question 1 Output:");
            
            int[] testarray = { 5, 6, 6, 9, 9, 12 };
            int[] outputarray = targetRange(testarray, 9);
            Console.WriteLine("Test array marks are [5, 6, 6, 9, 9, 12] and the test " +
                "target is 9");
            Console.WriteLine(outputarray[0].ToString() + (",") + outputarray[1].ToString());

            //QUESTION 1//

            //string StringReverse(string s) need to figure out why this method title line gives errors when I have it here.
            {
                string sentense = "University of South Florida";
                char[] arr = sentense.ToCharArray();
                int temp = 0;

                for (int i = 0; i <= arr.Length - 1; i++)
                {
                    int count = temp;
                    int num1 = 1;

                    if (arr[i] == ' ' || i == arr.Length - 1)
                    {
                        if (i == arr.Length - 1)
                        {
                            for (int c = i; c >= temp; c--)
                            {
                                
                                if (num1 <= (i - temp) / 2)
                                {
                                    char tempC = arr[count];
                                    arr[count] = arr[c];
                                    arr[c] = tempC;
                                    count++;
                                    num1++;
                                }
                            }
                        }
                        else
                        {
                            for (int c = i - 1; c >= temp; c--)
                            {
                                if (num1 <= (i - temp) / 2)
                                {
                                    char tempC = arr[count];
                                    arr[count] = arr[c];
                                    arr[c] = tempC;
                                    count++;
                                    num1++;
                                }
                            }
                        }
                        temp = i + 1;
                    }
                }
                string newLine = new string(arr);
                Console.WriteLine("Question 2 Output:");
                Console.WriteLine(sentense);
                Console.WriteLine(newLine);
            }

            //QUESTION 3//

            static int minSum(int[] arr, int n)
            {
                int sum = arr[0];

                //create a loop to go through the array and if an array index is equal to the
                //index before it replaces it with j which is the array index value +1
                for (int i = 1; i < n; i++)
                {
                    if (arr[i] == arr[i - 1])
                    {
                        int j = i;
                        while (j < n && arr[j] <= arr[j - 1])
                        {
                            arr[j] = arr[j] + 1;
                            j++;
                        }
                    }
                    sum = sum + arr[i];
                }
                //once you run through the whole array have it return the sum of the array
                return sum;
            }
           
           // Public static void Main()  **again need to figure out why the method title gives me an error when I place it there.
            {
                //This is a test of the example provided.
                Console.WriteLine("Question 3 Output:");
                int[] arr = { 2, 2, 3, 5, 6 };
                int n = arr.Length;
                Console.WriteLine("[2, 2, 3, 5, 6]");
                Console.WriteLine(minSum(arr, n));
            }
        }
    }
}







