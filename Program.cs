using System;

namespace massiv
{
    class Program
    {
        static int Main(string[] args)
        {
            int[] numbers = new int[10];
            var left = numbers.GetLowerBound(0);
            var right = numbers.GetUpperBound(0);
            if (left == right)
                return left;
            while (true)
            {
                if (right - left == 1)
                {
                    if (numbers[left] == 0)
                        return left;
                    if (numbers[right] == 0)
                        return right;
                    return -1;  
                }
                else
                {
                    var middle = left + (right - left) / 2;
                    var result = numbers[middle];
                    if (result == 0)
                    {
                        Console.WriteLine("Нашел число :" + middle);
                        return middle;
                    } 
                    if (result < 0)
                        left = middle;
                    if (result > 0)
                        right = middle;
                }
            }
        }
    }
}
