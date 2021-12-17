using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    static class Extension
    {
        public static int Kub(this int a)
        {
            if (a == 1) return a;
            for (int i = 0; i <= a/3; i++)
            {
                if(i*i*i == a)
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
