using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Question5
    {
        public void Answer()
        {
            //this code is to run the example sets from the question

            Console.WriteLine("Question 5 Output for sort version:");
            Console.WriteLine("=======================");

            Console.WriteLine("The first sample test arrays are nums1 = [2,5,5,2], nums2 = [5,5]");
            int[] numbers1 = { 2, 5, 5, 2 };
            int[] numbers2 = { 5, 5 };
            Console.WriteLine("Result: " + string.Join(" ", Intersect1(numbers1, numbers2)));

            Console.WriteLine("The first sample test arrays are nums1 = [3,6,2], nums2 = [6,3,6,7,3]");
            int[] numbers3 = { 3, 6, 2 };
            int[] numbers4 = { 6, 3, 6, 7, 3 };
            Console.WriteLine("Result: " + string.Join(" ", Intersect1(numbers3, numbers4)));
            Console.WriteLine(" ");

            Console.WriteLine("Question 5 Output for dictionary version:");
            Console.WriteLine("=======================");

            Console.WriteLine("The first sample test arrays are nums1 = [2,5,5,2], nums2 = [5,5]");
            Console.WriteLine("Result: " + string.Join(" ", Intersect2(numbers1, numbers2)));
            Console.WriteLine("The first sample test arrays are nums1 = [3,6,2], nums2 = [6,3,6,7,3]");
            Console.WriteLine("Result: " + string.Join(" ", Intersect2(numbers3, numbers4)));
            Console.WriteLine(" ");

        }
        public static int[] Intersect1(int[] nums1, int[] nums2)
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

        public static int[] Intersect2(int[] nums1, int[] nums2)
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

    }
}
