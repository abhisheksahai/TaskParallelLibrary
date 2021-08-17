using System;
using System.Collections.Generic;

namespace StockAnalyzer.AdvancedTopic
{
    static class MyUtility
    {
        //int count = 0;
        //private static MyUtility()
        //{
        //    ///count++;
        //}

        public static void GetInstance()
        {
           // MyUtility myUtility = new MyUtility();

        }

        public static void Count()
        {
            string str = "abcdeabc";
            char[] allItems = str.ToCharArray();
            Array.Sort(allItems);
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            foreach (var item in allItems)
            {
                int count = 0;
                foreach (var currentItem in allItems)
                {
                    if (item == currentItem)
                    {
                        count++;

                        charCount.Add(item, count);
                    }
                }
            }
            Console.WriteLine(charCount);
        }
    }


    abstract class MyAbstract
    {
        private abc()
        {

        }
    }
}
