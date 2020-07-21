using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace RectangleIntoSquares
{
    public class SqInRect
    {
        static List<int> sqListReturn = new List<int>();

        public static List<int> sqInRect(int lng, int wdth)
        {
            sqListReturn.Clear();

            int less = 0, more = 1;
            

            if (lng < wdth)
            {
                less = lng;
                more = wdth;
            }
            else if (lng == wdth)
            {
                return null;
            }
            else
            {
                less = wdth;
                more = lng;
            }
            while (less <= more) 
            {
                if(less!=0)
                sqListReturn.Add(less);

                int tmp = more - less;
                if (tmp < less)
                {
                    more = less;
                    less = tmp;
                }
                else if(tmp==more)
                {
                    break;
                }
                else
                {
                    more = tmp;
                }
            }
           
            return sqListReturn;
        }

        public static void print()
        {
            int size = sqListReturn.Count;
            if (size != 0)
            {
                Console.Write("{");
                for (int i = 0; i < size; i++)
                {
                    if (i < size - 1)
                    {
                        Console.Write(sqListReturn[i] + ",");
                    }
                    else
                    {
                        Console.Write(sqListReturn[i]);
                    }

                }
                Console.WriteLine("}");
            }
            else
            {
                Console.WriteLine("First define the list using SqInRect.sqInRect(x,y)");
            }
        }

        public static void defineAndPrint(int x, int y)
        {
            sqInRect(x, y);
            print();
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            SqInRect.print();
            SqInRect.sqInRect(5, 3);
            SqInRect.print();

            SqInRect.defineAndPrint(6, 3);

            Console.ReadKey();
        }
    }
}
