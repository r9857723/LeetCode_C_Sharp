using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


/*



 */

namespace LeetCode_C_Sharp
{
    public class Problem_1342 : Solution 
    {
        private readonly int num;

        public Problem_1342(int num) {
            this.num = num;
        }

        private int NumberOfSteps(int num)
        {
            int count = 0;
            while (num != 0)
            {
                num = num % 2 == 1 ? num - 1 : num / 2;
                count++;
            }
            return count;
        }

        public override void Do()
        {
            NumberOfSteps(this.num);
        }
    }
}
