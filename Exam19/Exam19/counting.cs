using System;
using System.Collections.Generic;
using System.Text;

namespace Exam19
{
    class counting
    {
        public int sum = 0;

        public int Sum
        {
            set
            {
                sum += value;
            }
            get
            {
                return sum;
            }
        }
    }
}
