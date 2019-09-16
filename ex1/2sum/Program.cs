using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[5] { -1, -2, -3, -4, -5 };
            
            int[] results = TwoSum(input, -8);

            Console.WriteLine("[{0}]", string.Join(", ", results));
            Console.ReadKey();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length > 0)
            {
                int aux = 0;
                int j;

                for (int i = 0; i < nums.Length; i++)
                {
                    aux = nums[i];
                    j = Array.LastIndexOf(nums, target - aux);

                    if (i != j && j != -1)
                        return new int[2] { i, j };
                }
            }
            return new int[0];
        }
    }
}
