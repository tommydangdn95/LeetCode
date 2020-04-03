using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arra = new int[] { 2, 7, 11, 15 };
            int[] pairIndicesNumber = FindIndicesTwoNumber(arra, 9);
            for(int i = 0;i < pairIndicesNumber.Length;i++)
            {
                Console.WriteLine(pairIndicesNumber[i]);
            }
        }

        private static int[] FindIndicesTwoNumber(int[] arrays, int sum)        
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int[] arraIndices = new int[2];
            for(int i = 0;i < arrays.Length; i++)
            {
                map.Add(arrays[i], i);
            }


            for(int i = 0;i < arrays.Length; i++)
            {
                var numberToFind = sum - arrays[i];
                if (map.ContainsKey(numberToFind))
                {
                    arraIndices[0] = i;
                    arraIndices[1] = map[numberToFind];
                    break;
                }
            }

            return arraIndices;
        }
    }
}
