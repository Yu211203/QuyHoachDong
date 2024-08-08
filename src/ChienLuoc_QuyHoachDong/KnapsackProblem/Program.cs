using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnapsackProblem
{
    public class Program
    {
        public static int Knapsack(int[] weights, int[] values, int capacity)
        {
            int n = weights.Length;
            int[] dp = new int[capacity + 1];

            for (int i = 0; i < n; i++)
            {
                for (int w = capacity; w >= weights[i]; w--)
                {
                    dp[w] = Math.Max(dp[w], dp[w - weights[i]] + values[i]);
                }
            }

            return dp[capacity];
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Định nghĩa trọng lượng và giá trị của các vật phẩm
            int[] weights = { 10, 20, 30 };
            int[] values = { 60, 100, 120 };
            int capacity = 50;

            // In thông tin trọng lượng, giá trị và trọng lượng tối đa ban đầu
            Console.WriteLine("Thông tin các vật phẩm:");
            for (int i = 0; i < weights.Length; i++)
            {
                Console.WriteLine($"Vật phẩm {i + 1}: Trọng lượng = {weights[i]}, Giá trị = {values[i]}");
            }
            Console.WriteLine($"Trọng lượng tối đa của balo: {capacity}");

            // Tính giá trị lớn nhất có thể đạt được
            int maxValue = Knapsack(weights, values, capacity);

            // In kết quả
            Console.WriteLine("Giá trị lớn nhất có thể đạt được: " + maxValue);
            Console.ReadLine();
        }
    }
}
