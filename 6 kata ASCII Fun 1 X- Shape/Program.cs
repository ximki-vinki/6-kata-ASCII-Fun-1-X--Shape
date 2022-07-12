using System;
using System.Text;

namespace _6_kata_ASCII_Fun_1_X__Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

        }
    }
    public static class Kata
    {
        public static string X(int n)
        {
            StringBuilder bd = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                StringBuilder motherString = new StringBuilder(new string('□', n));
                bd.Append(motherString.Replace('□', '■', i, 1).Replace('□', '■', n - i - 1, 1).ToString() + "\n");
            }
            return bd.Remove((n + 1) * n - 1, 1).ToString();
        }
    }
}
