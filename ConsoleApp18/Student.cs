using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
    internal class Student
    {
        public int No { get; }
      
        private static int _no;
        public Student()
        {
            _no++;
            this.No = _no;
        }
        public string FullName { get; set; }
    }
}