using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5._3._2
{
    internal class Stairs
    {
        static void Main(string[] args)
        {

        }

        public int ClimbingStairs(int n)
        {
            if (n == 1)
            {
                return 1;
            }
                
            if (n == 2)
            {
                return 2;
            }

            int first = 1;
            int second = 2;
            int result = 0;

            for (int i = 3; i <= n; i++)
            {
                result = first + second;
                first = second;
                second = result;
            }
            return result;
        }
    }
}
