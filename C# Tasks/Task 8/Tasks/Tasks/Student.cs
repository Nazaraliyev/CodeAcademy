using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    class Student
    {
        private static int instanceCount { get; set; }
        public Student()
        {
            instanceCount++;
        }
        public static void ShowInstanceCount()
        {
            Console.WriteLine("InstanceCount deyeri : " + instanceCount);
        }
    }
}
