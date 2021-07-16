using System;
using System.Collections.Generic;
using System.Linq;

namespace BYM
{
    class Program
    {
            //        Sample data:
            //Timberline Lodge = [0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1]
            //Elm Street = [1, 0, 0, 0, 1, 0, 1, 0, 0, 1, 1, 0]
            //Cloverfiel = [1,1,1,0,1,0,0,1,0,1,0,0]
        static void Main(string[] args)
        {
            int[] timberLodge = { 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 1 };
            int[] elmStreet = { 1, 0, 0, 0, 1, 0, 1, 0, 0, 1, 1, 0 };
            int[] cloverField = { 1, 1, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0 };

            foreach(int month in returnListOfMonths(timberLodge, elmStreet, cloverField))
            {
                Console.WriteLine((Months)Enum.ToObject(typeof(Months), month));
            }
        }

        static List<int> returnListOfMonths(int[] yearOne, int[] yearTwo, int[] yearThree)
        {
            List<int> yearOneIndexes= new List<int>();
            List<int> yearTwoIndexes = new List<int>();
            List<int> yearThreeIndexes = new List<int>();
            for (int i = 0; i < yearOne.Length; i++)
            {
                if(yearOne[i] == 1)
                {
                    yearOneIndexes.Add(i);
                }
            }
            for (int i = 0; i < yearTwo.Length; i++)
            {
                if (yearTwo[i] == 1)
                {
                    yearTwoIndexes.Add(i);
                }
            }
            for (int i = 0; i < yearThree.Length; i++)
            {
                if (yearThree[i] == 1)
                {
                    yearThreeIndexes.Add(i);
                }
            }
            var result = yearThreeIndexes.Intersect((yearOneIndexes.Intersect(yearTwoIndexes))).ToList();
            return result;
        }
    }
}
