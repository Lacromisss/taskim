using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp18
{
    internal class Group
    {

        private static int _no1 = 100;
        private static int _no2 = 100;
        private static int _no3 = 100;
        private string _words = "";
        public Group(Groups grp)
        {
            this.Type = grp;
            switch (grp)
            {
                case Groups.System:
                    _no3++;
                    _words =  _words+("S" + _no3);
                    break;
                case Groups.Programming:
                    _no1++;
                    _words = _words+ ("P" + _no1);
                    break;
                case Groups.Design:
                    _no2++;
                    _words =_words+ ("D" + _no2);
                    break;
               
            }
            this.No = _words;
        }
        public string No { get; }
     
        public Groups Type { get; set; }
        public Student[] student { get; set; }
        public object Student3 { get; internal set; }

        public Student FindStudentByNo(int input)
        {
            foreach (Student student in this.student)
            {
                if (student.No == input)
                {
                    return student;
                }
            }
            return null;
        }
    }
}
