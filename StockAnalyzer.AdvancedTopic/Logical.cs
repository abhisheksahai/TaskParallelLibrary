using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzer.AdvancedTopic
{
    enum Gender
    {
        Male,
        Female
    }

    interface IFace
    {
        public void TestMe();
    }
    abstract class MyAbstract : IFace
    {
        public void TestMe()
        {
            throw new NotImplementedException();
        }
    }

    public class Logical : BaseLogical
    {
        public Logical() : base()
        {
            Console.WriteLine("Executing Logical Ctor");
        }



        public override void TestMe()
        {
            base.TestMe();
        }

        public void SortArray1()
        {
            int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };
            Array.Sort(arr);
            Array.Reverse(arr);
        }

        public void SortArray2()
        {
            int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };
            Array.Sort(arr, new Comparison<int>((i1, i2) => i1.CompareTo(i2)));
        }

        public void SortArray3()
        {
            int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };
            Array.Sort(arr, delegate (int x, int y) { return y - x; });
        }

        public void SortArray4()
        {
            int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };
            Array.Sort(arr, delegate (int x, int y) { return y - x; });
        }

        public void SortArray5()
        {
            int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };
            arr = arr.OrderByDescending(c => c).ToArray();
        }

        public void SortArray6()
        {
            int[] arr = new int[] { 1, 9, 6, 7, 5, 9 };
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        public void Fibonacci1(int num)
        {
            int x = 0;
            int y = 1;
            int z;
            if (num == 1)
            {
                Console.Write($" {x} ");
                return;
            }
            else if (num > 1)
            {
                for (int i = 2; i < num; i++)
                {
                    z = x + y;
                    x = y;
                    y = z;

                    Console.Write($" {z} ");
                }
            }

        }

        public int NthFibonacciNumber(int num)
        {
            if ((num == 0) || (num == 1))
            {
                return num;
            }
            else
            {
                return (NthFibonacciNumber(num - 1) + NthFibonacciNumber(num - 2));
            }
        }

        public void CheckArmStrong()
        {
            int num = 371;
            int temp = num;
            int sum = 0;
            int rem = 0;
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + rem * rem * rem;
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Armstrong");
            }
        }
    }
}
